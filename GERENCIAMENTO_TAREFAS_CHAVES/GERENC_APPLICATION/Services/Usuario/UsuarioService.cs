using GERENC_APPLICATION.Criptografia;
using GERENC_APPLICATION.DTOs.Usuario;
using GERENC_APPLICATION.Exceptions;
using GERENC_APPLICATION.Interfaces.Usuario;
using GERENC_DOMAIN.Entities.Pessoas;
using GERENC_DOMAIN.Entities.Usuario;
using GERENC_DOMAIN.Enum;
using GERENC_INFRAESTRUTURA.Exception;
using GERENC_INFRAESTRUTURA.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.Services.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;
        private readonly IAuthService _authService;

        public UsuarioService(AppDbContext context, IAuthService authService)
        {
            _authService = authService;
            _context = context;
        }

        public void CriarUsuario(UsuarioCreateDto dto)
        {
            try
            {
                //VERIFICAR SE O NOME DE USUARIO EXISTE
                var exiteUsuario = _context.Usuarios
                    .FirstOrDefault(u => u.Usuario == dto.Usuario);

                //SE EXISTE, RETORNA UMA EXEPTION
                if (exiteUsuario != null)
                {
                    throw new AppException("'Usuario' já existe!");
                }


                //Verificar o tipo e cadastrar pelo tipo
                switch (dto.Tipo)
                {
                    case TipoUsuarioEnum.Agente:
                        cadastrarAgente(dto);
                        break;
                    case TipoUsuarioEnum.Adm:
                        cadastrarAdm(dto);
                        break;
                    case TipoUsuarioEnum.Porteiro:
                        cadastrarPorteiro(dto);
                        break;

                    default:
                        throw new AppException("Tipo de usuario invalido");
                }

            }
            catch (AppException ex)
            {
                throw;
            }
            catch (Exception ep)
            {
                throw new InfraestruturaException("Erro ao cadastrar usuario.\n", ep);
            }
     
        }

        private void cadastrarAdm(UsuarioCreateDto dto)
        {
            //VERIFICAR SE O CPF DO USUARIO EXISTE
            var exiteCpf = _context.Administradores
                .FirstOrDefault(a => a.Pessoa.Cpf == dto.Cpf);

            if (exiteCpf != null)
            {
                throw new AppException("Cpf do Administrador já cadastrado!");
            }

            var pessoa = new PessoaBaseModel(dto.Nome, dto.Cpf, TipoPessoaEnum.Adm);

            var usuario = new UsuarioBaseModel(dto.Usuario, dto.Senha, dto.Cpf, dto.Tipo);

            var adm = new Adm(pessoa, usuario);

            _context.Administradores.Add(adm);
            _context.SaveChanges();
        }

        private void cadastrarPorteiro(UsuarioCreateDto dto)
        {
            //VERIFICAR SE O CPF DO USUARIO EXISTE
            var exiteCpf = _context.Porteiros
                .FirstOrDefault(a => a.Pessoa.Cpf == dto.Cpf);

            if (exiteCpf != null)
            {
                throw new AppException("Cpf do usuario já cadastrado!");
            }

            var pessoa = new PessoaBaseModel(dto.Nome, dto.Cpf, TipoPessoaEnum.Porteiro);
            
            var usuario = new UsuarioBaseModel(dto.Usuario, dto.Senha, dto.Cpf, dto.Tipo);

            var porteiro = new PorteiroModel(pessoa, usuario);

            _context.Porteiros.Add(porteiro);
            _context.SaveChanges();
        }

        private void cadastrarAgente(UsuarioCreateDto dto)
        {
            //VERIFICAR SE O CPF DO USUARIO EXISTE
            var exiteCpf = _context.Agentes
                .FirstOrDefault(a => a.Pessoa.Cpf == dto.Cpf);

            if (exiteCpf != null)
            {
                throw new AppException("Cpf do agente já cadastrado!");
            }

            var pessoaAgente = new PessoaBaseModel(dto.Nome, dto.Cpf, TipoPessoaEnum.Agente);
            foreach (var codCategoria in dto.CategoriasCodigos)
            {
                var categoria = _context.Categorias.Find(codCategoria);
                if (categoria != null)
                {
                    pessoaAgente.AdicionarCategoria(categoria);
                }
                else
                {
                    throw new AppException("Categoria inexistente");
                }
            }
            var usuarioAgente = new UsuarioBaseModel(dto.Usuario, dto.Senha, dto.Cpf, dto.Tipo);

            var agente = new AgenteModel(pessoaAgente, usuarioAgente);
            
            _context.Agentes.Add(agente);
            _context.SaveChanges();
        }


        public async Task<UsuarioRetornoDto> Logar(UsuarioLogarDto dto)
        {
            try
            {
                var usuario = _context.Usuarios.FirstOrDefault(u => u.Usuario == dto.Usuario);
                if (usuario == null)
                {
                    throw new AppException("Usuario inexistente");
                }

                var senhaOk = await _authService.VerificarSenhaAsync(dto.Senha, usuario.Senha);
                if (!senhaOk)
                {
                    throw new AppException("Senha inválida");
                }


                var usuarioRetorno = new UsuarioRetornoDto
                {
                    Id = usuario.Id,
                    Usuario = usuario.Usuario,
                    Tipo = usuario.Tipo
                };

                switch (usuario.Tipo)
                {
                    case TipoUsuarioEnum.Adm:

                        var adm = _context.Administradores
                            .Include(a => a.Pessoa)
                            .FirstOrDefault(a => a.UsuarioId == usuario.Id);

                        usuarioRetorno.Nome = adm.Pessoa.Nome;
                        break;
                    case TipoUsuarioEnum.Agente:

                        var agente = _context.Agentes
                            .Include(a => a.Pessoa)
                            .FirstOrDefault(a => a.UsuarioId == usuario.Id);

                        usuarioRetorno.Nome = agente.Pessoa.Nome;
                        break;
                    case TipoUsuarioEnum.Porteiro:
                        var porteiro = _context.Porteiros
                            .Include(a => a.Pessoa)
                            .FirstOrDefault(a => a.UsuarioId == usuario.Id);
                        usuarioRetorno.Nome = porteiro.Pessoa.Nome;
                        break;
                    default:
                        throw new AppException("Erro interno.\n Verifique o tipo de usuario");
                }

                return usuarioRetorno;

            }
            catch (AppException ex)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new InfraestruturaException("Erro interno", e);
            }
        }

        public async Task<IEnumerable<UsuarioListDto>> ListUsuariosAsync()
        {
            try
            {
                IQueryable<UsuarioBaseModel> list = _context.Usuarios;

                return await list.Select(u => new UsuarioListDto
                {
                    Id = u.Id,
                    UsuarioLogin = u.Usuario,
                    Tipo = u.Tipo
                }).ToListAsync();

            } catch (DbUpdateException ex)
            {
                throw new InfraestruturaException("Erro ao buscar usuarios no banco", ex);
            }

        }

       
    }
}

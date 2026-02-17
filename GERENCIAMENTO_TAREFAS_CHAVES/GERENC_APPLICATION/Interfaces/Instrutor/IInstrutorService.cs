using GERENC_APPLICATION.DTOs.Instrutor;

namespace GERENC_APPLICATION.Services.Instrutor
{
    public interface IInstrutorService
    {
        void CriarConstrutor(InstrutorCreateDto dto);

        Task<IEnumerable<InstrutorListDto>> ListarInstrutorAsync(IEnumerable<int> idCatAgente);

        Task<IEnumerable<InstrutorListDto>> ListarInstrutorPorNomeAsync(string nome, IEnumerable<int> idCatAgente);
    }
}
using GERENC_DOMAIN.Entities.Curso;
using GERENC_DOMAIN.Entities.Pessoas;
using GERENC_DOMAIN.Entities.Sala;


namespace GERENC_DOMAIN.Entities.Tarefa
{
    public class TarefaModel
    {
        public int Id { get; private set; }
        public int InstrutorId { get; private set; }
        public int AgenteId { get; private set; }
        public int CursoId { get; private set; }
        public int ChaveId { get; private set; }
        public string Obs { get; private set; }
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }

        public InstrutorModel Instrutor { get; private set; }
        public AgenteModel Agente { get; private set; }
        public CursoModel Curso { get; private set; }
        public ChaveModel Chave { get; private set; }
       


        
    }
}

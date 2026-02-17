using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Tarefa
{
    public class TarefaDiaHorario
    {
        public int Id { get; private set; }
        public int TarefaId { get; private set; }
        // 1 = segunda 2 = terça....
        public DayOfWeek DiaSemana { get; private set; }
        public TimeSpan HoraInicio { get; private set; }
        public TimeSpan HoraFim { get; private set; }

        public TarefaModel Tarefa {  get; private set; }
    }
}

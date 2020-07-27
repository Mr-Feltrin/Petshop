using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entities
{
    class Agenda
    {
        public int IdAgenda { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Procedimento { get; set; }
        public Cliente Cliente { get; set; }
        public TimeSpan Horario { get; set; }




    }
}

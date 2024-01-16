using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAdmin.MODELS
{
    public class Odpowiedz
    {
        [Key]
        public int IdOdpowiedzi { get; set; }

        public string TrescOdpowiedzi { get; set; }
        public DateTime CreationTime { get; set; }

        public int IdPytania { get; set; }
        public Pytanie Pytanie { get; set; }
    }
}

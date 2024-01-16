using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAdmin.MODELS
{
    public class Ankieta
    {
        [Key]
        public int IdAnkiety { get; set; }

        public string NazwaAnkiety { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Pytanie> Pytania { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SduCyberForm.Models
{
    
    public class EventTypeModel
    {
        [Key]
        public int Id { get; set; }

        public bool Ddos { get; set; }
        public bool BilgiSizdirma { get; set; }
        public bool Dolandırıcılık { get; set; }
        public bool PortTarama { get; set; }
        public bool VeriSaldırı { get; set; }
        public bool WebGuvenlik { get; set; }
        public bool SosyalMuh { get; set; }
        public bool VeriKaybı { get; set; }
        public bool Spam { get; set; }
        public bool ParolaEleGec { get; set; }
        public bool CihazKaybı { get; set; }
        public bool KimlikTaklidi { get; set; }
        public bool Oltalama { get; set; }
        public bool KisiselKotuKullanım { get; set; }
       
    }
}

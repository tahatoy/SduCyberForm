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
        public bool Malware { get; set; }
        public bool BilgiSizdirma { get; set; }
        public bool Dolandiricilik { get; set; }
        public bool PortTarama { get; set; }
        public bool VeriSaldiri { get; set; }
        public bool WebGuvenlik { get; set; }
        public bool SosyalMuh { get; set; }
        public bool VeriKaybi { get; set; }
        public bool Spam { get; set; }
        public bool ParolaEleGec { get; set; }
        public bool CihazKaybi { get; set; }
        public bool KimlikTaklidi { get; set; }
        public bool Oltalama { get; set; }
        public bool KisiselKotuKullanim { get; set; }
       
    }
}

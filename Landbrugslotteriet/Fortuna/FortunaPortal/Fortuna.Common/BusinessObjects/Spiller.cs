using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Common.BusinessObjects
{
    public class Spiller : BusinessObject
    {
        public int Id { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string PostNummerId { get; set; }
        public string By { get; set; }
        public string Land { get; set; }
        public long? Telefon { get; set; }
        public long? Mobil { get; set; }
        public string Mail { get; set; }
        public string Web { get; set; }
        public DateTime? OprettelsesDato { get; set; }
        public DateTime? AfgangsDato { get; set; }
        public string Noter { get; set; }
        public string FoedtDato { get; set; }
        public int? BemaerkningsId { get; set; }
        public string OprettetAf { get; set; }
        public string AendretAf { get; set; }
        public DateTime? AendretDato { get; set; }
    }
}

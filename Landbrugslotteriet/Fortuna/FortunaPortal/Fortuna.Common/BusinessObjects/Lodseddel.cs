using System;

namespace Fortuna.Common.BusinessObjects
{
    public class Lodseddel : BusinessObject
    {
        public new int Id { get; set; }
        public int LodNummer { get; set; }
        public string Kategori { get; set; }
        public int Periode { get; set; }
        public int? Serie { get; set; }
        public int? Traekning { get; set; }
        public bool? Udfaset { get; set; }
        public int? SpillerId { get; set; }
        public int? SalgsBerretigetForhandlerId { get; set; }
        public decimal? PrisLow { get; set; }
        public decimal? PrisHigh { get; set; }
        public bool? Solgt { get; set; }
        public int? Kontrolciffer { get; set; }
        public bool? LodseddelPrintet { get; set; }
        public int? SaelgendeForhandlerId { get; set; }
        public DateTime? SalgsDato { get; set; }
        public bool? Reserveret { get; set; }
        public bool? Blokeret { get; set; }
        public bool? PbsSpiller { get; set; }
        public int? PbsAftaleNummer { get; set; }
        public int? PbsRegNr { get; set; }
        public long? PbsKontoNummer { get; set; }
        public string PbsBankId { get; set; }
        public int? PbsProvisionsForhandlerId { get; set; }
        public DateTime? PbsProvisionsDato { get; set; }
        public decimal? PbsProvisionsSats { get; set; }
        public decimal Gevinst1 { get; set; }
        public bool? GevinstUdbetaltManuelt1 { get; set; }
        public DateTime? GevinstUdbetaltDato1 { get; set; }
        public DateTime? GevinstAfregningsDato1 { get; set; }
        public bool? ForaeldetGevinst1 { get; set; }
        public DateTime? ForaeldetGevinsDato1 { get; set; }
        public int? GevinstUdbetaltForhandler1 { get; set; }
        public decimal Gevinst2 { get; set; }
        public bool? GevinstUdbetaltManuelt2 { get; set; }
        public DateTime? GevinstUdbetaltDato2 { get; set; }
        public DateTime? GevinstAfregningsDato2 { get; set; }
        public bool? ForaeldetGevinst2 { get; set; }
        public DateTime? ForaeldetGevinsDato2 { get; set; }
        public int? GevinstUdbetaltForhandler2 { get; set; }
        public DateTime? SidstVist { get; set; }
        public bool? TagetTilIndtaegt { get; set; }
        public DateTime? AfregningsDato { get; set; }
        public int? HistorikId { get; set; }
        public string OprettetAf { get; set; }
        public string AendretAf { get; set; }
        public DateTime? AendretDato { get; set; }
        public bool? ResNySerie { get; set; }
        public bool? PbsAfmeldtBank { get; set; }
        public string RegSalg { get; set; }
        public decimal? SavePris { get; set; }
        public string SaveGevinst { get; set; }

        public Lodseddel()
        {

        }
    }


}

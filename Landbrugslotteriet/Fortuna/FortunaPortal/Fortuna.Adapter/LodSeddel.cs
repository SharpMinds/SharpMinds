//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fortuna.Adapter
{
    using System;
    using System.Collections.Generic;
    
    public partial class LodSeddel
    {
        public int idLodSeddel { get; set; }
        public int LodNummer { get; set; }
        public string Kategori { get; set; }
        public int Periode { get; set; }
        public Nullable<int> Serie { get; set; }
        public Nullable<int> Traekning { get; set; }
        public Nullable<bool> Udfaset { get; set; }
        public Nullable<int> SpillerId { get; set; }
        public Nullable<int> SalgsBerretigetForhandlerId { get; set; }
        public Nullable<decimal> PrisLow { get; set; }
        public Nullable<decimal> PrisHigh { get; set; }
        public Nullable<bool> Solgt { get; set; }
        public Nullable<int> Kontrolciffer { get; set; }
        public Nullable<bool> LodseddelPrintet { get; set; }
        public Nullable<int> SaelgendeForhandlerId { get; set; }
        public Nullable<System.DateTime> SalgsDato { get; set; }
        public Nullable<bool> Reserveret { get; set; }
        public Nullable<bool> Blokeret { get; set; }
        public Nullable<bool> PbsSpiller { get; set; }
        public Nullable<int> PbsAftaleNummer { get; set; }
        public Nullable<int> PbsRegNr { get; set; }
        public Nullable<long> PbsKontoNummer { get; set; }
        public string PbsBankId { get; set; }
        public Nullable<int> PbsProvisionsForhandlerId { get; set; }
        public Nullable<System.DateTime> PbsProvisionsDato { get; set; }
        public Nullable<decimal> PbsProvisionsSats { get; set; }
        public decimal Gevinst1 { get; set; }
        public Nullable<bool> GevinstUdbetaltManuelt1 { get; set; }
        public Nullable<System.DateTime> GevinstUdbetaltDato1 { get; set; }
        public Nullable<System.DateTime> GevinstAfregningsDato1 { get; set; }
        public Nullable<bool> ForaeldetGevinst1 { get; set; }
        public Nullable<System.DateTime> ForaeldetGevinsDato1 { get; set; }
        public Nullable<int> GevinstUdbetaltForhandler1 { get; set; }
        public decimal Gevinst2 { get; set; }
        public Nullable<bool> GevinstUdbetaltManuelt2 { get; set; }
        public Nullable<System.DateTime> GevinstUdbetaltDato2 { get; set; }
        public Nullable<System.DateTime> GevinstAfregningsDato2 { get; set; }
        public Nullable<bool> ForaeldetGevinst2 { get; set; }
        public Nullable<System.DateTime> ForaeldetGevinsDato2 { get; set; }
        public Nullable<int> GevinstUdbetaltForhandler2 { get; set; }
        public Nullable<System.DateTime> SidstVist { get; set; }
        public Nullable<bool> TagetTilIndtaegt { get; set; }
        public Nullable<System.DateTime> AfregningsDato { get; set; }
        public Nullable<int> HistorikId { get; set; }
        public string OprettetAf { get; set; }
        public string AendretAf { get; set; }
        public Nullable<System.DateTime> AendretDato { get; set; }
        public Nullable<bool> ResNySerie { get; set; }
        public Nullable<bool> PbsAfmeldtBank { get; set; }
        public string RegSalg { get; set; }
    }
}

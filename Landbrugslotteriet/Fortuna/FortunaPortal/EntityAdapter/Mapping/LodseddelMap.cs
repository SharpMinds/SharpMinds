using System.Data.Entity.ModelConfiguration;
using Fortuna.Common.BusinessObjects;

namespace EntityAdapter.Mapping
{
    class LodseddelMap : EntityTypeConfiguration<Lodseddel>
    {
        public LodseddelMap()
        {
            // Primary key
            HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            ToTable("LodSeddel");
            Property(t => t.LodNummer).HasColumnName("LodNummer");
            Property(t => t.Kategori).HasColumnName("Kategori");
            Property(t => t.Periode).HasColumnName("Periode");
            Property(t => t.Serie).HasColumnName("Serie");
            Property(t => t.Traekning).HasColumnName("Traekning");
            Property(t => t.Udfaset).HasColumnName("Udfaset");
            Property(t => t.SpillerId).HasColumnName("SpillerId");
            Property(t => t.SalgsBerretigetForhandlerId).HasColumnName("SalgsBerretigetForhandlerId");
            Property(t => t.PrisLow).HasColumnName("PrisLow");
            Property(t => t.PrisHigh).HasColumnName("PrisHigh");
            Property(t => t.Solgt).HasColumnName("Solgt");
            Property(t => t.Kontrolciffer).HasColumnName("Kontrolciffer");
            Property(t => t.LodseddelPrintet).HasColumnName("LodseddelPrintet");
            Property(t => t.SaelgendeForhandlerId).HasColumnName("SaelgendeForhandlerId");
            Property(t => t.SalgsDato).HasColumnName("SalgsDato");
            Property(t => t.Reserveret).HasColumnName("Reserveret");
            Property(t => t.Blokeret).HasColumnName("Blokeret");
            Property(t => t.PbsSpiller).HasColumnName("PbsSpiller");
            Property(t => t.PbsAftaleNummer).HasColumnName("PbsAftaleNummer");
            Property(t => t.PbsRegNr).HasColumnName("PbsRegNr");
            Property(t => t.PbsKontoNummer).HasColumnName("PbsKontoNummer");
            Property(t => t.PbsBankId).HasColumnName("PbsBankId");
            Property(t => t.PbsProvisionsForhandlerId).HasColumnName("PbsProvisionsForhandlerId");
            Property(t => t.PbsProvisionsDato).HasColumnName("PbsProvisionsDato");
            Property(t => t.PbsProvisionsSats).HasColumnName("PbsProvisionsSats");
            Property(t => t.Gevinst1).HasColumnName("Gevinst1");
            Property(t => t.GevinstUdbetaltManuelt1).HasColumnName("GevinstUdbetaltManuelt1");
            Property(t => t.GevinstUdbetaltDato1).HasColumnName("GevinstUdbetaltDato1");
            Property(t => t.GevinstAfregningsDato1).HasColumnName("GevinstAfregningsDato1");
            Property(t => t.ForaeldetGevinst1).HasColumnName("ForaeldetGevinst1");
            Property(t => t.ForaeldetGevinsDato1).HasColumnName("ForaeldetGevinsDato1");
            Property(t => t.GevinstUdbetaltForhandler1).HasColumnName("GevinstUdbetaltForhandler1");
            Property(t => t.Gevinst2).HasColumnName("Gevinst2");
            Property(t => t.GevinstUdbetaltManuelt2).HasColumnName("GevinstUdbetaltManuelt2");
            Property(t => t.GevinstUdbetaltDato2).HasColumnName("GevinstUdbetaltDato2");
            Property(t => t.GevinstAfregningsDato2).HasColumnName("GevinstAfregningsDato2");
            Property(t => t.ForaeldetGevinst2).HasColumnName("ForaeldetGevinst2");
            Property(t => t.ForaeldetGevinsDato2).HasColumnName("ForaeldetGevinsDato2");
            Property(t => t.GevinstUdbetaltForhandler2).HasColumnName("GevinstUdbetaltForhandler2");
            Property(t => t.SidstVist).HasColumnName("SidstVist");
            Property(t => t.TagetTilIndtaegt).HasColumnName("TagetTilIndtaegt");
            Property(t => t.AfregningsDato).HasColumnName("AfregningsDato");
            Property(t => t.HistorikId).HasColumnName("HistorikId");
            Property(t => t.OprettetAf).HasColumnName("OprettetAf");
            Property(t => t.AendretAf).HasColumnName("AendretAf");
            Property(t => t.AendretDato).HasColumnName("AendretDato");
            Property(t => t.ResNySerie).HasColumnName("ResNySerie");
            Property(t => t.PbsAfmeldtBank).HasColumnName("PbsAfmeldtBank");
            Property(t => t.RegSalg).HasColumnName("RegSalg");
            Property(t => t.SavePris).HasColumnName("SavePris");
            Property(t => t.SaveGevinst).HasColumnName("SaveGevinst");   
        }
    }
}

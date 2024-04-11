using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer.Models;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Metingrund> Metingrunds { get; set; }

    public virtual DbSet<Metingvarken> Metingvarkens { get; set; }

    public virtual DbSet<Rund> Runds { get; set; }

    public virtual DbSet<Varken> Varkens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SID=IVB)));Persist Security Info=True;User Id=IVBUSER;Password=IVB;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("IVBUSER")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Metingrund>(entity =>
        {
            entity.HasKey(e => e.Seqmeting);

            entity.ToTable("METINGRUND");

            entity.HasIndex(e => e.Seqrund, "IDX_METINGRUND_SEQRUND");

            entity.HasIndex(e => e.Codclass, "IDX_M_CODCLASS");

            entity.Property(e => e.Seqmeting)
                .HasPrecision(8)
                .ValueGeneratedNever()
                .HasColumnName("SEQMETING");
            entity.Property(e => e.Codabdvorm)
                .HasPrecision(2)
                .HasColumnName("CODABDVORM");
            entity.Property(e => e.Codasynchmed)
                .HasPrecision(2)
                .HasDefaultValueSql("NULL")
                .HasColumnName("CODASYNCHMED");
            entity.Property(e => e.Codasynchmet)
                .HasPrecision(3)
                .HasColumnName("CODASYNCHMET");
            entity.Property(e => e.Codbevklasse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODBEVKLASSE");
            entity.Property(e => e.Codbevsubklasse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODBEVSUBKLASSE");
            entity.Property(e => e.Codcat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODCAT");
            entity.Property(e => e.Codclass)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CODCLASS");
            entity.Property(e => e.Codgeenmet)
                .HasPrecision(3)
                .HasColumnName("CODGEENMET");
            entity.Property(e => e.Codidentificatieletter)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODIDENTIFICATIELETTER");
            entity.Property(e => e.Codlbh)
                .HasPrecision(1)
                .HasColumnName("CODLBH");
            entity.Property(e => e.Codonvkar)
                .HasPrecision(3)
                .HasColumnName("CODONVKAR");
            entity.Property(e => e.Codsankwal)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODSANKWAL");
            entity.Property(e => e.Codvetklasse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODVETKLASSE");
            entity.Property(e => e.Codvetsubklasse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODVETSUBKLASSE");
            entity.Property(e => e.Credat)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("CREDAT");
            entity.Property(e => e.Creusr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CREUSR");
            entity.Property(e => e.Dnacode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNACODE");
            entity.Property(e => e.Etiketnr)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ETIKETNR");
            entity.Property(e => e.IdWeegtoestel)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("ID_WEEGTOESTEL");
            entity.Property(e => e.Karkasgroei)
                .HasPrecision(4)
                .HasColumnName("KARKASGROEI");
            entity.Property(e => e.Klantnr)
                .HasPrecision(8)
                .HasColumnName("KLANTNR");
            entity.Property(e => e.Levendgewicht)
                .HasDefaultValueSql("NULL")
                .HasColumnType("NUMBER(5,1)")
                .HasColumnName("LEVENDGEWICHT");
            entity.Property(e => e.Levgewicht)
                .HasPrecision(8)
                .HasColumnName("LEVGEWICHT");
            entity.Property(e => e.Malsheid)
                .HasColumnType("NUMBER(20)")
                .HasColumnName("MALSHEID");
            entity.Property(e => e.Omgwarmgewicht)
                .HasColumnType("NUMBER(5,1)")
                .HasColumnName("OMGWARMGEWICHT");
            entity.Property(e => e.Reflexie)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("REFLEXIE");
            entity.Property(e => e.Reinheid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("REINHEID");
            entity.Property(e => e.Reserve1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("RESERVE1");
            entity.Property(e => e.Reserve2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("RESERVE2");
            entity.Property(e => e.Reserve3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("RESERVE3");
            entity.Property(e => e.Reserve4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("RESERVE4");
            entity.Property(e => e.Reserve5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("RESERVE5");
            entity.Property(e => e.Reserve6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("RESERVE6");
            entity.Property(e => e.Seqrund)
                .HasPrecision(8)
                .ValueGeneratedOnAdd()
                .HasColumnName("SEQRUND");
            entity.Property(e => e.Tarra)
                .HasColumnType("NUMBER(3,1)")
                .HasColumnName("TARRA");
            entity.Property(e => e.UniekIdArsGew1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("UNIEK_ID_ARS_GEW1");
            entity.Property(e => e.UniekIdArsGew2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("UNIEK_ID_ARS_GEW2");
            entity.Property(e => e.UniekIdArsInd)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("NULL")
                .HasColumnName("UNIEK_ID_ARS_IND");
            entity.Property(e => e.Upddat)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("UPDDAT");
            entity.Property(e => e.Updusr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPDUSR");
            entity.Property(e => e.Warmgewicht)
                .HasColumnType("NUMBER(5,1)")
                .HasColumnName("WARMGEWICHT");
        });

        modelBuilder.Entity<Metingvarken>(entity =>
        {
            entity.HasKey(e => e.Seqmeting);

            entity.ToTable("METINGVARKEN");

            entity.HasIndex(e => new { e.Seqvarken, e.Germagvls }, "IDX_METINGVARKEN_GERMAGVLS").IsUnique();

            entity.HasIndex(e => e.Seqvarken, "IDX_METINGVARKEN_SEQVARKEN").IsUnique();

            entity.HasIndex(e => e.UniekIdArsInd, "IDX_M_CODCLASS2");

            entity.Property(e => e.Seqmeting)
                .HasPrecision(9)
                .ValueGeneratedNever()
                .HasColumnName("SEQMETING");
            entity.Property(e => e.Alarm1)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ALARM1");
            entity.Property(e => e.Alarm2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ALARM2");
            entity.Property(e => e.Alarm3)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ALARM3");
            entity.Property(e => e.Asynchmet)
                .HasPrecision(2)
                .HasColumnName("ASYNCHMET");
            entity.Property(e => e.Basispse)
                .HasPrecision(3)
                .HasColumnName("BASISPSE");
            entity.Property(e => e.Codabdvorm)
                .HasPrecision(2)
                .HasColumnName("CODABDVORM");
            entity.Property(e => e.Codasynchmet)
                .HasPrecision(3)
                .HasColumnName("CODASYNCHMET");
            entity.Property(e => e.Codclass1)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CODCLASS1");
            entity.Property(e => e.Codimpgewmet)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODIMPGEWMET");
            entity.Property(e => e.Codinvgewmet)
                .HasPrecision(2)
                .HasColumnName("CODINVGEWMET");
            entity.Property(e => e.Codlbh)
                .HasPrecision(1)
                .HasColumnName("CODLBH");
            entity.Property(e => e.Codonvkar)
                .HasPrecision(3)
                .HasColumnName("CODONVKAR");
            entity.Property(e => e.Codsankwal)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODSANKWAL");
            entity.Property(e => e.Comclass)
                .HasPrecision(2)
                .HasColumnName("COMCLASS");
            entity.Property(e => e.Comclassman)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COMCLASSMAN");
            entity.Property(e => e.Comklas)
                .HasPrecision(2)
                .HasColumnName("COMKLAS");
            entity.Property(e => e.Comklasman)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COMKLASMAN");
            entity.Property(e => e.Credat)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("CREDAT");
            entity.Property(e => e.Creusr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CREUSR");
            entity.Property(e => e.GeenMetingFysio)
                .HasPrecision(3)
                .HasColumnName("GEEN_METING_FYSIO");
            entity.Property(e => e.GeenMetingTechno)
                .HasPrecision(2)
                .HasColumnName("GEEN_METING_TECHNO");
            entity.Property(e => e.Germagvls)
                .HasColumnType("NUMBER(3,1)")
                .HasColumnName("GERMAGVLS");
            entity.Property(e => e.Germagvlsber)
                .HasColumnType("NUMBER(4,1)")
                .HasColumnName("GERMAGVLSBER");
            entity.Property(e => e.Germagvlsberint)
                .HasColumnType("NUMBER(4,1)")
                .HasColumnName("GERMAGVLSBERINT");
            entity.Property(e => e.Hamhoek)
                .HasColumnType("NUMBER(3,1)")
                .HasColumnName("HAMHOEK");
            entity.Property(e => e.IdIndtoestel)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("'0' ")
                .HasColumnName("ID_INDTOESTEL");
            entity.Property(e => e.IdWeegtoestel)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("'0' ")
                .HasColumnName("ID_WEEGTOESTEL");
            entity.Property(e => e.Indicatiepse)
                .HasPrecision(3)
                .HasColumnName("INDICATIEPSE");
            entity.Property(e => e.Individueelnr)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("INDIVIDUEELNR");
            entity.Property(e => e.Klantnr)
                .HasPrecision(8)
                .HasColumnName("KLANTNR");
            entity.Property(e => e.Levgewicht)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LEVGEWICHT");
            entity.Property(e => e.Maxbreedteham)
                .HasPrecision(4)
                .HasColumnName("MAXBREEDTEHAM");
            entity.Property(e => e.Reflexie)
                .HasColumnType("NUMBER(4,1)")
                .HasColumnName("REFLEXIE");
            entity.Property(e => e.Reserve1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESERVE1");
            entity.Property(e => e.Reserve10)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESERVE10");
            entity.Property(e => e.Reserve2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESERVE2");
            entity.Property(e => e.Reserve3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESERVE3");
            entity.Property(e => e.Reserve4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESERVE4");
            entity.Property(e => e.Reserve5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESERVE5");
            entity.Property(e => e.Reserve6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESERVE6");
            entity.Property(e => e.Reserve7)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESERVE7");
            entity.Property(e => e.Reserve8)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESERVE8");
            entity.Property(e => e.Reserve9)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESERVE9");
            entity.Property(e => e.Seqapp1)
                .HasPrecision(6)
                .HasColumnName("SEQAPP1");
            entity.Property(e => e.Seqapp2)
                .HasPrecision(6)
                .HasColumnName("SEQAPP2");
            entity.Property(e => e.Seqvarken)
                .HasPrecision(9)
                .HasColumnName("SEQVARKEN");
            entity.Property(e => e.Tarra)
                .HasColumnType("NUMBER(3,1)")
                .HasColumnName("TARRA");
            entity.Property(e => e.Tssribwaarde)
                .HasColumnType("NUMBER(4,2)")
                .HasColumnName("TSSRIBWAARDE");
            entity.Property(e => e.Typegetal)
                .HasColumnType("NUMBER(3,2)")
                .HasColumnName("TYPEGETAL");
            entity.Property(e => e.Typegetalber)
                .HasColumnType("NUMBER(3,2)")
                .HasColumnName("TYPEGETALBER");
            entity.Property(e => e.UniekIdArsGew)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("'0' ")
                .HasColumnName("UNIEK_ID_ARS_GEW");
            entity.Property(e => e.UniekIdArsInd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UNIEK_ID_ARS_IND");
            entity.Property(e => e.Upddat)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("UPDDAT");
            entity.Property(e => e.Updusr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPDUSR");
            entity.Property(e => e.Warmgewicht)
                .HasColumnType("NUMBER(4,1)")
                .HasColumnName("WARMGEWICHT");
            entity.Property(e => e.X1).HasColumnType("NUMBER(3,1)");
            entity.Property(e => e.X1eersteprik)
                .HasColumnType("NUMBER(4,2)")
                .HasColumnName("X1EERSTEPRIK");
            entity.Property(e => e.X2).HasColumnType("NUMBER(4,1)");
            entity.Property(e => e.X3totalewaarde)
                .HasColumnType("NUMBER(4,2)")
                .HasColumnName("X3TOTALEWAARDE");
        });

        modelBuilder.Entity<Rund>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RUND");

            entity.HasIndex(e => e.Codlandbeslag, "IDX_R_CODLANDBESLAG");

            entity.HasIndex(e => e.Codlandofwn, "IDX_R_CODLANDOFWN");

            entity.HasIndex(e => e.Codslachthuis, "IDX_R_CODSLACHTHUIS");

            entity.HasIndex(e => new { e.Codslachthuis, e.Filenr, e.Weegnr }, "IDX_R_FILENR").IsUnique();

            entity.HasIndex(e => e.Oormerk, "IDX_R_OORMERK");

            entity.HasIndex(e => e.Datgeslacht, "IDX_R_SLACHTDATUM");

            entity.HasIndex(e => e.Codveebeslag, "IDX_R_VEEBESLAG");

            entity.Property(e => e.Btwnrbestemmeling)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BTWNRBESTEMMELING");
            entity.Property(e => e.Codgeslacht)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODGESLACHT");
            entity.Property(e => e.Codgroothandel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODGROOTHANDEL");
            entity.Property(e => e.Codland)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODLAND");
            entity.Property(e => e.Codlandbeslag)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODLANDBESLAG");
            entity.Property(e => e.Codlandofgeboorte)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODLANDOFGEBOORTE");
            entity.Property(e => e.Codlandofwn)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODLANDOFWN");
            entity.Property(e => e.Codleverancier)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CODLEVERANCIER");
            entity.Property(e => e.Codslachthuis)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODSLACHTHUIS");
            entity.Property(e => e.Codveebeslag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CODVEEBESLAG");
            entity.Property(e => e.Credat)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("CREDAT");
            entity.Property(e => e.Creusr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CREUSR");
            entity.Property(e => e.Datgeboorte)
                .HasColumnType("DATE")
                .HasColumnName("DATGEBOORTE");
            entity.Property(e => e.Datgeslacht)
                .HasColumnType("DATE")
                .HasColumnName("DATGESLACHT");
            entity.Property(e => e.Filenr)
                .HasPrecision(5)
                .HasColumnName("FILENR");
            entity.Property(e => e.Fileseq)
                .HasPrecision(6)
                .HasColumnName("FILESEQ");
            entity.Property(e => e.Fileupdnr)
                .HasPrecision(5)
                .HasColumnName("FILEUPDNR");
            entity.Property(e => e.Lotnr)
                .HasPrecision(8)
                .HasColumnName("LOTNR");
            entity.Property(e => e.Oormerk)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("OORMERK");
            entity.Property(e => e.Seqlot)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQLOT");
            entity.Property(e => e.Seqrund)
                .HasPrecision(8)
                .HasColumnName("SEQRUND");
            entity.Property(e => e.Tonen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TONEN");
            entity.Property(e => e.Upddat)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("UPDDAT");
            entity.Property(e => e.Updusr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPDUSR");
            entity.Property(e => e.Verzenden)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERZENDEN");
            entity.Property(e => e.Weegnr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("WEEGNR");
        });

        modelBuilder.Entity<Varken>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VARKEN");

            entity.HasIndex(e => e.Seqlot, "IDX_V_SEQLOT");

            entity.HasIndex(e => e.Datgeslacht, "IDX_V_SLACHTDATUM");

            entity.HasIndex(e => e.Codveebeslag, "IDX_V_VEEBESLAG");

            entity.Property(e => e.Codgeslacht)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODGESLACHT");
            entity.Property(e => e.Codlandbeslag)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CODLANDBESLAG");
            entity.Property(e => e.Codleverancier)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CODLEVERANCIER");
            entity.Property(e => e.Codslachthuis)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODSLACHTHUIS");
            entity.Property(e => e.Codveebeslag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CODVEEBESLAG");
            entity.Property(e => e.Credat)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("CREDAT");
            entity.Property(e => e.Creusr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CREUSR");
            entity.Property(e => e.Datgeslacht)
                .HasColumnType("DATE")
                .HasColumnName("DATGESLACHT");
            entity.Property(e => e.Filenr)
                .HasPrecision(5)
                .HasColumnName("FILENR");
            entity.Property(e => e.Fileseq)
                .HasPrecision(6)
                .HasColumnName("FILESEQ");
            entity.Property(e => e.Fileupdnr)
                .HasPrecision(5)
                .HasColumnName("FILEUPDNR");
            entity.Property(e => e.Klophamer)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KLOPHAMER");
            entity.Property(e => e.Lotnr)
                .HasPrecision(8)
                .HasColumnName("LOTNR");
            entity.Property(e => e.Oormerk)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OORMERK");
            entity.Property(e => e.OperKlant)
                .HasColumnType("NUMBER(25)")
                .HasColumnName("OPER_KLANT");
            entity.Property(e => e.Seqlot)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQLOT");
            entity.Property(e => e.Seqvarken)
                .HasPrecision(9)
                .HasColumnName("SEQVARKEN");
            entity.Property(e => e.Tonen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TONEN");
            entity.Property(e => e.Upddat)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("UPDDAT");
            entity.Property(e => e.Updusr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UPDUSR");
            entity.Property(e => e.Verzenden)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERZENDEN");
            entity.Property(e => e.Weegnr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("WEEGNR");
        });
        modelBuilder.HasSequence("ANALYTICSSEQ");
        modelBuilder.HasSequence("BELBEEFSEQ");
        modelBuilder.HasSequence("CERTIFICAATSEQ");
        modelBuilder.HasSequence("CW3C_RUBO_FILENR");
        modelBuilder.HasSequence("CW3C_RUBO_WEEGNR");
        modelBuilder.HasSequence("CW3C_VAPO_WEEGNR");
        modelBuilder.HasSequence("DOCUMENTSEQ");
        modelBuilder.HasSequence("EMAILCONFIRMATIONSEQ");
        modelBuilder.HasSequence("INVOICEBATCHSEQ");
        modelBuilder.HasSequence("IVBSEQ");
        modelBuilder.HasSequence("IVBSRVFLDSEQ");
        modelBuilder.HasSequence("IVBSRVUSRSEQ");
        modelBuilder.HasSequence("LOGSEQ");
        modelBuilder.HasSequence("LOTDASHBOARDSEQ");
        modelBuilder.HasSequence("LOTSEQ");
        modelBuilder.HasSequence("MAILQUEUEITEMSEQ");
        modelBuilder.HasSequence("MERITUSSEQ");
        modelBuilder.HasSequence("NOTIFICATIONCONFIRMATIONSEQ");
        modelBuilder.HasSequence("REPORTSEQ");
        modelBuilder.HasSequence("RUNDSEQ");
        modelBuilder.HasSequence("SEQ_ATTACHMENT");
        modelBuilder.HasSequence("SEQ_LOTEN");
        modelBuilder.HasSequence("SLACHTRAPPORTENSEQ");
        modelBuilder.HasSequence("VARKSEQ");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

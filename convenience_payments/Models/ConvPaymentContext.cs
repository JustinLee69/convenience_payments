using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace convenience_payments.Models
{
    public partial class ConvPaymentContext : DbContext
    {
        public ConvPaymentContext()
        {
        }

        public ConvPaymentContext(DbContextOptions<ConvPaymentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OlpsOnlineTradeD> OlpsOnlineTradeD { get; set; }
        public virtual DbSet<StoreM> StoreM { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=P10231871\\SQLEXPRESS;Database=ConvPayment; User ID = sa; Password = 123456; Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<OlpsOnlineTradeD>(entity =>
            {
                entity.ToTable("OLPS_ONLINE_TRADE_D");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OiNo)
                    .IsRequired()
                    .HasColumnName("oi_no")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OlAmount)
                    .HasColumnName("ol_amount")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.OlCode1)
                    .HasColumnName("ol_code_1")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.OlCode2)
                    .HasColumnName("ol_code_2")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OlCode3)
                    .HasColumnName("ol_code_3")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OlCode4)
                    .HasColumnName("ol_code_4")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OlCode5)
                    .HasColumnName("ol_code_5")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OlPaytype)
                    .HasColumnName("ol_paytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Store)
                    .IsRequired()
                    .HasColumnName("store")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Systemdate)
                    .HasColumnName("systemdate")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Systemtime)
                    .HasColumnName("systemtime")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Termino)
                    .IsRequired()
                    .HasColumnName("termino")
                    .HasMaxLength(26)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreM>(entity =>
            {
                entity.ToTable("STORE_M");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate)
                    .HasColumnName("close_date")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DoCd)
                    .HasColumnName("do_cd")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EffDateFrom)
                    .IsRequired()
                    .HasColumnName("eff_date_from")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EffDateTo)
                    .HasColumnName("eff_date_to")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("fax_no")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FmCd)
                    .HasColumnName("fm_cd")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceFlag)
                    .HasColumnName("invoice_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JournalFlag)
                    .HasColumnName("journal_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("numeric(11, 5)");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("numeric(11, 5)");

                entity.Property(e => e.OldStore)
                    .HasColumnName("old_store")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OpTime)
                    .HasColumnName("op_time")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OpType)
                    .HasColumnName("op_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OpenDate)
                    .HasColumnName("open_date")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDate)
                    .HasColumnName("sales_date")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialFlag)
                    .HasColumnName("special_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StNameLong)
                    .HasColumnName("st_name_long")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.StNameShort)
                    .HasColumnName("st_name_short")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Store)
                    .IsRequired()
                    .HasColumnName("store")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StoreType)
                    .HasColumnName("store_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SysDate)
                    .HasColumnName("sys_date")
                    .HasColumnType("date");

                entity.Property(e => e.TelArea)
                    .HasColumnName("tel_area")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TelNo)
                    .HasColumnName("tel_no")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TestStoreFlag)
                    .HasColumnName("test_store_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate)
                    .HasColumnName("upd_date")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpdId)
                    .HasColumnName("upd_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UpdTime)
                    .HasColumnName("upd_time")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ZoCd)
                    .HasColumnName("zo_cd")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });
        }
    }
}

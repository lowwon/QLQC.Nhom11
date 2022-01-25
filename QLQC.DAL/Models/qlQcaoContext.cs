using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QLQC.DAL.Models
{
    public partial class qlQcaoContext : DbContext
    {
        public qlQcaoContext()
        {
        }

        public qlQcaoContext(DbContextOptions<qlQcaoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiQc> LoaiQcs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhomNv> NhomNvs { get; set; }
        public virtual DbSet<QcLqc> QcLqcs { get; set; }
        public virtual DbSet<QuangCao> QuangCaos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=qlQcao;Persist Security Info=True;User ID=sa;Password=sa;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HopDong>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.ToTable("HopDong");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(10)
                    .HasColumnName("MaHD")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKh)
                    .HasMaxLength(10)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNv)
                    .HasMaxLength(10)
                    .HasColumnName("MaNV")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayKy).HasColumnType("date");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HopDongs)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_HopDong_Khach_Hang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HopDongs)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_HopDong_NhanVien1");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.ToTable("Khach_Hang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(10)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gt)
                    .HasMaxLength(10)
                    .HasColumnName("GT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(60)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<LoaiQc>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.ToTable("Loai_QC");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.HinhThuc).HasMaxLength(50);

                entity.Property(e => e.MoTa).HasMaxLength(500);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(10)
                    .HasColumnName("MaNV")
                    .IsFixedLength(true);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gt)
                    .HasMaxLength(10)
                    .HasColumnName("GT");

                entity.Property(e => e.MaNhom)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NgSinh).HasColumnType("date");

                entity.Property(e => e.NgVaoLam).HasColumnType("date");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(60)
                    .HasColumnName("TenNV");

                entity.HasOne(d => d.MaNhomNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaNhom)
                    .HasConstraintName("FK_NhanVien_Nhom_NV");
            });

            modelBuilder.Entity<NhomNv>(entity =>
            {
                entity.HasKey(e => e.MaNhom);

                entity.ToTable("Nhom_NV");

                entity.Property(e => e.MaNhom)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaNT)
                    .HasMaxLength(10)
                    .HasColumnName("MaNT")
                    .IsFixedLength(true);

                entity.Property(e => e.TenNhom).HasMaxLength(50);

                entity.HasOne(d => d.MaNtNavigation)
                    .WithMany(p => p.NhomNvs)
                    .HasForeignKey(d => d.MaNT)
                    .HasConstraintName("FK_Nhom_NV_NhanVien");
            });

            modelBuilder.Entity<QcLqc>(entity =>
            {
                entity.HasKey(e => new { e.MaQc, e.MaLoai });

                entity.ToTable("QC_LQC");

                entity.Property(e => e.MaQc)
                    .HasMaxLength(10)
                    .HasColumnName("MaQC")
                    .IsFixedLength(true);

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.QcLqcs)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QC_LQC_Loai_QC");

                entity.HasOne(d => d.MaQcNavigation)
                    .WithMany(p => p.QcLqcs)
                    .HasForeignKey(d => d.MaQc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QC_LQC_Quang_Cao");
            });

            modelBuilder.Entity<QuangCao>(entity =>
            {
                entity.HasKey(e => e.MaQc);

                entity.ToTable("Quang_Cao");

                entity.Property(e => e.MaQc)
                    .HasMaxLength(10)
                    .HasColumnName("MaQC")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKh)
                    .HasMaxLength(10)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNhom)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NgBd)
                    .HasColumnType("date")
                    .HasColumnName("NgBD");

                entity.Property(e => e.NgKt)
                    .HasColumnType("date")
                    .HasColumnName("NgKT");

                entity.Property(e => e.SoTien).HasColumnType("money");

                entity.Property(e => e.YeuCau).HasMaxLength(500);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.QuangCaos)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_Quang_Cao_Khach_Hang");

                entity.HasOne(d => d.MaNhomNavigation)
                    .WithMany(p => p.QuangCaos)
                    .HasForeignKey(d => d.MaNhom)
                    .HasConstraintName("FK_Quang_Cao_Nhom_NV");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

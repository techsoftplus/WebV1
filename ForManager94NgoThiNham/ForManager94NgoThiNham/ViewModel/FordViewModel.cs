namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FordViewModel : DbContext
    {
        public FordViewModel()
            : base("name=FordViewModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AnhChuyenMuc> AnhChuyenMucs { get; set; }
        public virtual DbSet<AnhSanPham> AnhSanPhams { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<BaiViet> BaiViets { get; set; }
        public virtual DbSet<BaiVietTag> BaiVietTags { get; set; }
        public virtual DbSet<BangGiaShip> BangGiaShips { get; set; }
        public virtual DbSet<BoLoc> BoLocs { get; set; }
        public virtual DbSet<BoLocEx> BoLocExes { get; set; }
        public virtual DbSet<BoSuuTap> BoSuuTaps { get; set; }
        public virtual DbSet<Cache> Caches { get; set; }
        public virtual DbSet<ChuyenMuc> ChuyenMucs { get; set; }
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<DonHangItem> DonHangItems { get; set; }
        public virtual DbSet<FolderStorage> FolderStorages { get; set; }
        public virtual DbSet<GiamGia> GiamGias { get; set; }
        public virtual DbSet<HistorySanPham> HistorySanPhams { get; set; }
        public virtual DbSet<ImageStorage> ImageStorages { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LienHe> LienHes { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<MaVach> MaVaches { get; set; }
        public virtual DbSet<MaVachSanPham> MaVachSanPhams { get; set; }
        public virtual DbSet<NguoiDungCuaHang> NguoiDungCuaHangs { get; set; }
        public virtual DbSet<NhomLoc> NhomLocs { get; set; }
        public virtual DbSet<QuanHuyen> QuanHuyens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SanPhamBoLoc> SanPhamBoLocs { get; set; }
        public virtual DbSet<SanPhamChuyenMuc> SanPhamChuyenMucs { get; set; }
        public virtual DbSet<SanPhamTag> SanPhamTags { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TimKiem> TimKiems { get; set; }
        public virtual DbSet<Tinh> Tinhs { get; set; }
        public virtual DbSet<TinNhanKichHoat> TinNhanKichHoats { get; set; }
        public virtual DbSet<TrangThaiDonHang> TrangThaiDonHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<BaiViet>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<BaiViet>()
                .Property(e => e.UrlAlias)
                .IsUnicode(false);

            modelBuilder.Entity<BaiViet>()
                .HasMany(e => e.BaiVietTags)
                .WithRequired(e => e.BaiViet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BoLoc>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<BoLoc>()
                .HasMany(e => e.BoLocExes)
                .WithRequired(e => e.BoLoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cache>()
                .Property(e => e.Key)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenMuc>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenMuc>()
                .Property(e => e.ChuyenMucCon)
                .IsUnicode(false);

            modelBuilder.Entity<CuaHang>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaDonHang)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaGiamGia)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.DonHangItems)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FolderStorage>()
                .HasMany(e => e.FolderStorage1)
                .WithOptional(e => e.FolderStorage2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<FolderStorage>()
                .HasMany(e => e.ImageStorages)
                .WithRequired(e => e.FolderStorage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiamGia>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<HistorySanPham>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<HistorySanPham>()
                .HasMany(e => e.MaVachSanPhams)
                .WithOptional(e => e.HistorySanPham)
                .HasForeignKey(e => e.HistoryPrintSanPhamId);

            modelBuilder.Entity<HistorySanPham>()
                .HasMany(e => e.MaVachSanPhams1)
                .WithOptional(e => e.HistorySanPham1)
                .HasForeignKey(e => e.HistoryActiveSanPhamId);

            modelBuilder.Entity<LienHe>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<MauSac>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<MauSac>()
                .HasMany(e => e.DonHangItems)
                .WithRequired(e => e.MauSac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaVach>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<MaVachSanPham>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<MaVachSanPham>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<NhomLoc>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<NhomLoc>()
                .HasMany(e => e.BoLocs)
                .WithRequired(e => e.NhomLoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuanHuyen>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.UrlAlias)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.ChuyenMucs)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MauSacs)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Tags)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.AnhSanPhams)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.KhoHangs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.MaVachSanPhams)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.SanPhamBoLocs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.SanPhamChuyenMucs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.SanPhamTags)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.BaiVietTags)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.KhuyenMais)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.SanPhamTags)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tinh>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<Tinh>()
                .HasMany(e => e.QuanHuyens)
                .WithRequired(e => e.Tinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TinNhanKichHoat>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<TinNhanKichHoat>()
                .Property(e => e.MaVach)
                .IsUnicode(false);

            modelBuilder.Entity<TrangThaiDonHang>()
                .Property(e => e.Ma)
                .IsUnicode(false);
        }
    }
}

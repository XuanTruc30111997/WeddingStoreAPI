using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;

namespace WeddingStoreAPI.Context
{
    public class WeddingStoreContext : DbContext
    {
        public WeddingStoreContext(DbContextOptions<WeddingStoreContext> options)
            : base(options)
        {
        }

        public DbSet<VatLieuModel> KhoVatLieu { get; set; }
        public DbSet<SanPhamModel> SanPham { get; set; }
        public DbSet<PhatSinhModel> PhatSinh { get; set; }
        public DbSet<PhanCongModel> PhanCong { get; set; }
        public DbSet<NhanVienModel> NhanVien { get; set; }
        public DbSet<NhaCungCapModel> NhaCungCap { get; set; }
        public DbSet<LoaiDichVuModel> LoaiDichVu { get; set; }
        public DbSet<KhachHangModel> KhachHang { get; set; }
        public DbSet<HoaDonModel> HoaDon { get; set; }
        public DbSet<DonGiaNhapHangModel> DonGiaNhapHang { get; set; }
        public DbSet<DichVuModel> DichVu { get; set; }
        public DbSet<ChiTietSanPhamModel> ChiTietSanPham { get; set; }
        public DbSet<ChiTietHoaDonModel> ChiTietHoaDon { get; set; }
        public DbSet<ChiTietDonGiaNhapHangModel> ChiTietDonGiaNhapHang { get; set; }
        public DbSet<TaiKhoanModel> TaiKhoan { get; set; }
        public DbSet<DatLichModel> DatLich { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many to Many
            modelBuilder.Entity<PhatSinhModel>()
                .HasKey(ps => new { ps.MaHD, ps.MaVL });

            modelBuilder.Entity<PhanCongModel>()
                .HasKey(pc => new { pc.MaHD, pc.MaNV, pc.Ngay });

            modelBuilder.Entity<ChiTietDonGiaNhapHangModel>()
                .HasKey(ct => new { ct.MaDG, ct.MaVL });

            modelBuilder.Entity<ChiTietSanPhamModel>()
                .HasKey(ct => new { ct.MaSP, ct.MaVL });

            modelBuilder.Entity<ChiTietHoaDonModel>()
                .HasKey(ct => new { ct.MaHD, ct.MaSP });

            // One to Many
            modelBuilder.Entity<DichVuModel>()
                .HasOne<LoaiDichVuModel>(dv => dv.LoaiDichVu)
                .WithMany(ldv => ldv.DichVus)
                .HasForeignKey(dv => dv.LoaiDV);

            modelBuilder.Entity<PhanCongModel>()
                .HasOne<NhanVienModel>(pc => pc.NhanVien)
                .WithMany(nv => nv.PhanCongs)
                .HasForeignKey(pc => pc.MaNV);

            // One to One
            modelBuilder.Entity<KhachHangModel>()
                .HasOne<HoaDonModel>(kh => kh.HoaDon)
                .WithOne(hd => hd.KhachHang)
                .HasForeignKey<HoaDonModel>(hd => hd.MaKH);

            modelBuilder.Entity<NhaCungCapModel>()
                .HasOne<DonGiaNhapHangModel>(ncc => ncc.DonGiaNhapHang)
                .WithOne(dg => dg.NhaCungCap)
                .HasForeignKey<DonGiaNhapHangModel>(dg => dg.MaNCC);

            modelBuilder.Entity<TaiKhoanModel>()
                .HasOne<NhanVienModel>(tk => tk.NhanVien)
                .WithOne(nv => nv.TaiKhoan)
                .HasForeignKey<NhanVienModel>(nv => nv.MaNV);

            modelBuilder.Entity<DatLichModel>()
                .HasOne<KhachHangModel>(dl => dl.KhachHang)
                .WithOne(kh => kh.DatLich)
                .HasForeignKey<KhachHangModel>(kh => kh.MaKH);
        }
    }
}

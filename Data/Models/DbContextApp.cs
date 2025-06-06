﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class DbContextApp : DbContext
    {
        public DbContextApp()
        {
            
        }

        public DbContextApp(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=DuanNhom11;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GiayDotGiamGia>()
      .HasKey(gdg => gdg.GiayDotGiamGiaId);

            // Quan hệ GiayDotGiamGia - Giay (N-1)
            modelBuilder.Entity<GiayDotGiamGia>()
                .HasOne(gdg => gdg.Giay)
                .WithMany(g => g.GiayDotGiamGias)
                .HasForeignKey(gdg => gdg.GiayId);

            // Quan hệ GiayDotGiamGia - GiamGia (N-1)
            modelBuilder.Entity<GiayDotGiamGia>()
                .HasOne(gdg => gdg.GiamGia)
                .WithMany(g => g.GiayDotGiamGias)
                .HasForeignKey(gdg => gdg.GiamGiaId);
            modelBuilder.Entity<TaiKhoan_ChucVu>()
        .HasOne(tc => tc.TaiKhoan)
        .WithMany(tk => tk.TaiKhoan_ChucVus)
        .HasForeignKey(tc => tc.TaiKhoanId)
        .OnDelete(DeleteBehavior.Cascade);

            // Thiết lập quan hệ: TaiKhoan_ChucVu - ChucVu (N-1)
            modelBuilder.Entity<TaiKhoan_ChucVu>()
                .HasOne(tc => tc.ChucVu)
                .WithMany(cv => cv.TaiKhoan_ChucVus)
                .HasForeignKey(tc => tc.ChucVuId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<HoaDon>()

                .HasOne(h => h.taiKhoan)
                .WithMany(t => t.HoaDons)
                .HasForeignKey(h => h.TaiKhoanId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.khachHang)
                .WithMany(t => t.HoaDons)

                .HasForeignKey(h => h.KhachHangId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDon>()

                .HasOne(h => h.hinhThucThanhToan)
                .WithMany(t => t.HoaDons)

                .HasForeignKey(h => h.HinhThucThanhToanId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDon>()

                .HasOne(h => h.voucher)
                .WithMany(t => t.HoaDons) 

                .HasForeignKey(h => h.VoucherId)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<KhachHang>()
           .HasOne(kh => kh.TaiKhoan)
           .WithMany()
           .HasForeignKey(kh => kh.TaiKhoanId)
           .OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<TaiKhoan_ChucVu> TaiKhoan_ChucVus { get; set; }
        public DbSet<Giay> Giays { get; set; }
        public DbSet<GiayChiTiet> GiayChiTiets { get; set; }
        public DbSet<ChatLieu> ChatLieus { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<KichCo> KichCos { get; set; }
        public DbSet<DeGiay> DeGiays { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<GiamGia> GiamGias { get; set; }
        public DbSet<GiayDotGiamGia> GiayDotGiamGias { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<KieuDang> KieuDangs { get; set; }
        public DbSet<TheLoaiGiay> TheLoaiGiays { get; set; }
        public DbSet<Anh> Anhs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }
        public DbSet<HinhThucThanhToan> hinhThucThanhToans { get; set; }
        public DbSet<DiaChiKhachHang> diaChiKhachHangs { get; set; }


    }
}

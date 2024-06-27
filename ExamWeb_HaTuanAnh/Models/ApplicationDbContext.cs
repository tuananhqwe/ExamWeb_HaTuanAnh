using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ExamWeb_HaTuanAnh.Models
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        base(options)
        {
        }
        public DbSet<Phim> Phims { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //De 2
            modelBuilder.Entity<Phim>().HasData(
               new Phim { Id = 1, TuaDe = "Chúng ta của 8 năm sau", DienVien = "Huyền Lizzie, Mạnh Trường", TrongNuoc = true, GiaVe = 150000, ThoiLuong = 110 },
               new Phim { Id = 2, TuaDe = "Avatar", DienVien = "Sam Worthington", TrongNuoc = false, GiaVe = 250000, ThoiLuong = 161 },
               new Phim { Id = 3, TuaDe = "Gặp em ngày nắng", DienVien = "Đình Tú, Anh Đào", TrongNuoc = true, GiaVe = 160000, ThoiLuong = 105 },
               new Phim { Id = 4, TuaDe = "Không ngại cưới", DienVien = "Hoàng Thùy Linh, Nhan Phúc Vinh", TrongNuoc = true, GiaVe = 120000, ThoiLuong = 150 },
               new Phim { Id = 5, TuaDe = "Gia đình đại chiến", DienVien = "Đức Khuê, Nguyệt Hằng", TrongNuoc = true, GiaVe = 130000, ThoiLuong = 120 },
               new Phim { Id = 6, TuaDe = "Kẻ Huỷ Diệt ", DienVien = "Arnold Schwarzenegger", TrongNuoc = false, GiaVe = 210000, ThoiLuong = 107 }
             );
        }
    }
}

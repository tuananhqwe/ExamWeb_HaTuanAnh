using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_HaTuanAnh.Models
{
    public class Phim
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string TuaDe { get; set; }
        public string DienVien { get; set; }
        public bool TrongNuoc { get; set; }
        public double GiaVe { get; set; }

        public int ThoiLuong { get; set; }

    }
}

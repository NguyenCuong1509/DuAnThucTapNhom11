using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class HoaDon
    {
        [Key]
        public Guid HoaDonId { get; set; } = Guid.NewGuid();

        public Guid? TaiKhoanId { get; set; }
        public Guid? VoucherId { get; set; }
        public Guid? KhachHangId { get; set; }
        public Guid? HinhThucThanhToanId { get; set; }

        [MaxLength(50)]
        public string TenCuaKhachHang { get; set; }

        [MaxLength(20)]
        public string SDTCuaKhachHang { get; set; }

        public Guid? DiaChiId { get; set; }

        [MaxLength(50)]
        public string EmailCuaKhachHang { get; set; }

        public DateTime NgayTao { get; set; }
        public DateTime? NgayNhanHang { get; set; }

        public float TongTienSauKhiGiam { get; set; }

        public bool TrangThai { get; set; }

        [MaxLength(200)]
        public string GhiChu { get; set; }
    }

}

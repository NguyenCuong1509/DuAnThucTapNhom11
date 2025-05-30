using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class HoaDon
    {
        [Key]
        public Guid HoaDonId { get; set; } = Guid.NewGuid();

        public Guid TaiKhoanId { get; set; }

        [ForeignKey("Voucher")]
        public Guid ? VoucherId { get; set; }
        public Guid KhachHangId { get; set; }
        public Guid DiaChiKhachHangId { get; set; }
        public Guid HinhThucThanhToanId { get; set; }

        [MaxLength(50)]
        public string TenCuaKhachHang { get; set; }

        [MaxLength(20)]
        public string SDTCuaKhachHang { get; set; }

        [MaxLength(50)]
        public string EmailCuaKhachHang { get; set; }

        public DateTime NgayTao { get; set; }
        public DateTime NgayNhanHang { get; set; }

        public float TongTienSauKhiGiam { get; set; }

        public bool TrangThai { get; set; }

        [MaxLength(200)]
        public string GhiChu { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual DiaChiKhachHang DiaChiKhachHang { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Voucher
    {
        [Key]
        [MaxLength(20)]
        public string VoucherId { get; set; } = Guid.NewGuid().ToString("N").Substring(0, 20);

        [Required]
        [MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Tên không hợp lệ.")]
        public string TenVoucher { get; set; }

        [Required]
        public DateTime NgayBatDau { get; set; }

        [Required]
        public DateTime NgayKetThuc { get; set; }

        [Range(0, 100)]
        public float PhanTram { get; set; }

        public bool TrangThai { get; set; }

        public int SoLuong { get; set; }

        public string MaTaiKhoan { get; set; }

        public void Validate()
        {
            if (NgayBatDau.Date < DateTime.Today)
                throw new Exception("Ngày bắt đầu không hợp lệ.");
            if (NgayKetThuc <= NgayBatDau)
                throw new Exception("Ngày kết thúc phải sau ngày bắt đầu.");
        }
    }

}

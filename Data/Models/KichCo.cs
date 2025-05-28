using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class KichCo
    {
        public Guid KichCoId { get; set; }

        [Required(ErrorMessage = "Tên kích cỡ không được để trống")]
        [StringLength(50, ErrorMessage = "Tên kích cỡ tối đa 50 ký tự")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Tên kích cỡ không được chứa ký tự đặc biệt")]
        public string TenKichCo { get; set; }

        public string MoTa { get; set; }

        public bool TrangThai { get; set; }
    }
}

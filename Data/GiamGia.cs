using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    internal class GiamGia : IValidatableObject
    {
        [Key]
        public Guid GiamGiaId { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Tên không được chứa ký tự đặc biệt.")]
        public string TenGiamGia { get; set; }

        public string SanPhamKhuyenMai { get; set; }
        public float PhanTramKhuyenMai { get; set; }

        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public bool TrangThai { get; set; }

        public virtual ICollection<Giay> Giays { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (NgayBatDau < DateTime.Now)
            {
                yield return new ValidationResult("Ngày bắt đầu không được ở trong quá khứ.", new[] { nameof(NgayBatDau) });
            }

            if (NgayKetThuc <= NgayBatDau)
            {
                yield return new ValidationResult("Ngày kết thúc phải sau ngày bắt đầu.", new[] { nameof(NgayKetThuc) });
            }
        }
    }


}

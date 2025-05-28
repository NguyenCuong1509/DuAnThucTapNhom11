using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    internal class Giay
    {
        [Key]
        public Guid GiayId { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Tên giày không được chứa ký tự đặc biệt.")]
        public string TenGiay { get; set; }

        [Required]
        public Guid GiamGiaId { get; set; }

        public bool TrangThai { get; set; }

        public virtual GiamGia GiamGia { get; set; }
        public virtual ICollection<GiayChiTiet> GiayChiTiets { get; set; }
    }

}

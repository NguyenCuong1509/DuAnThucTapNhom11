using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class DeGiay
    {
        [Key]
        public Guid DeGiayId { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$")]
        public string TenDeGiay { get; set; }

        public string KichCo { get; set; }

        public string MoTa { get; set; }

        public bool TrangThai { get; set; }

        public Guid TaiKhoanId { get; set; }
    }
}

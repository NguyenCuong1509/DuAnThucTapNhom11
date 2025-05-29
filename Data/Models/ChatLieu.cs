using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ChatLieu
    {
        [Key]
        public Guid ChatLieuId { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$")]
        public string TenChatLieu { get; set; }

        public string MoTa { get; set; }

        public bool TrangThai { get; set; }

        public Guid TaiKhoanId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    internal class GioHangChiTiet
    {
        public Guid GioHangChiTietId { get; set; }
        public Guid? GioHangId { get; set; }
        public Guid? GiayChiTietId { get; set; }
        public bool TrangThai { get; set; }
    }
}

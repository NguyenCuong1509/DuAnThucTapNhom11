using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class DiaChiKhachHang
    {
        public Guid DiaChiKhachHangId { get; set; } = Guid.NewGuid();
        public Guid? KhachHangId { get; set; }
        public string TenDiaChi { get; set; }

        public string ThanhPho { get; set; }

        public string QuanHuyen { get; set; }

        public string PhuongXa { get; set; }

        public string MoTa { get; set; }

        public bool TrangThai { get; set; } = true;

       

    }
}

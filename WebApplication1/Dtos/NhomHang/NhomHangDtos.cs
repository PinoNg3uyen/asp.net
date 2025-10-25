using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Dtos.NhomHang
{
    public class NhomHangDtos : Controller
    {
        public int NhomId { get; set; }
        public string TenNhom { get; set; } = "";

        public string GhiChu { get; set; } = string.Empty;

        internal object TolistAsync()
        {
            throw new NotImplementedException();
        }
    }
}


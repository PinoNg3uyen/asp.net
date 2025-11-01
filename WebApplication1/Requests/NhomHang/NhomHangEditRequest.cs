using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.NhomHang
{
    public class NhomHangEditRequest : Controller
    {
        public int NhomId { get; set; }
        [StringLength(200)]
        public string TenNhom { get; set; } = null!;

        public string GhiChu { get; set; } = "";
    }
}

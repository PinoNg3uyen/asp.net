using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.NhomHang
{
    public class NhomHangAddRequest : Controller
    {
        [StringLength(200)]
        public string TenNhom { get; set; } = null!;

        [StringLength(500)]

        public string GhiChu { get; set; } = "";
    }
}

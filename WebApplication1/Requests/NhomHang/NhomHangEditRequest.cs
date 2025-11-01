using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.NhomHang
{
    public class NhomHangEditRequest
    {
        public int NhomId { get; set; }
        [StringLength(200)]
        public string TenNhom { get; set; } = null!;
        [StringLength(500)]
        public string GhiChu { get; set; } = "";
    }
}

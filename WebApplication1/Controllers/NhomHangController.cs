using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using WebApplication1.Database;
using WebApplication1.Database.Entities;
using WebApplication1.Models;
using WebApplication1.Requests.NhomHang;

namespace WebApplication1.Controllers;
[Route("nhom-hang")]
public class NhomHangController(DatabaseContext db) : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet("get-all")]
    public async Task <IActionResult> GetAll()
    {
        ResponseModel response = new();

        var nhomhang = await db.NhomHangs
           .Select(n => new
           {
               n.NhomId,
               n.TenNhom,
               n.GhiChu
           })
           .ToListAsync();
        response.Data = nhomhang;
        response.IsSuccess = true;

        return Json(response);


    }
}
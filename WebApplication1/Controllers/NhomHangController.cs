using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Database.Entities;
using WebApplication1.Dtos.NhomHang;
using WebApplication1.Models;
using WebApplication1.Requests.NhomHang;

namespace WebApplication1.Controllers;

[Route("nhom-hang")]
public class NhomHangController(DatabaseContext db) : Controller
{
    [HttpGet("list")]
    public async Task<IActionResult> Index()
    {
        var data = await db.NhomHangs
            .Select(n => new NhomHangDtos()
            {
                NhomId = n.NhomId,
                TenNhom = n.TenNhom,
                GhiChu = n.GhiChu
            })
            .ToListAsync();

        ViewData["nhomHangs"] = data;

        return View();
    }

    [HttpGet("them-moi")]
    public IActionResult Add()
    {
        return View();
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAll()
    {
        ResponseModel response = new();

        var nhomHang = await db.NhomHangs
            .Select(n => new
            {
                n.NhomId,
                n.TenNhom,
                n.GhiChu
            })
            .ToListAsync();

        response.Data = nhomHang;
        response.IsSuccess = true;

        return Json(response);
    }
    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] NhomHangAddRequest request)
    {
        ResponseModel response = new();

        bool isExists = await db.NhomHangs.Where(n => n.TenNhom == request.TenNhom).AnyAsync();

        if (isExists)
        {
            response.Message = "Nhóm hàng đã tồn tại trong hệ thống";
            return Json(response);
        }

        NhomHangEntity newNhomHang = new()
        {
            TenNhom = request.TenNhom,
            GhiChu = request.GhiChu
        };

        await db.NhomHangs.AddAsync(newNhomHang);
        await db.SaveChangesAsync();

        response.IsSuccess = true;

        return Json(response);
    }
}
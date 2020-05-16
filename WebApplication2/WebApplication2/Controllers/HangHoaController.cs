using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index()
        {
            var hh = new HangHoa
            {
                DonGia = 1,
                TenHangHoa = "aa"
            };
            return View(hh);
        }

        public IActionResult DanhSach() 
        {
            List<HangHoa> danhsach = new List<HangHoa>();
            HangHoa tmp;

            var rd = new Random();
            var SoPhanTu = rd.Next(3, 10);

            for (int i = 0; i < SoPhanTu; i++)
            {
                tmp = new HangHoa
                {
                    TenHangHoa = $"Samsung {rd.Next()}",
                    DonGia = rd.NextDouble() * 10,
                };
                danhsach.Add(tmp);
            }

            return View(danhsach);
        }
    }
}
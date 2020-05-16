using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class HinhHoc
    {
        public double ChuVi { get; set; }
        public double DienTich { get; set; }

        public virtual void TinhDienTichChuVi()
        { }
        public override string ToString()
        {
            return $"S = {DienTich} ,  P = {ChuVi}";
        }

    }

    public class HinhChuNhat : HinhHoc
    {
        public int  ChieuDai { get; set; }
        public int ChieuRong { get; set; }

        public override void TinhDienTichChuVi()
        {
            DienTich = ChieuDai * ChieuRong;
            ChuVi = (ChieuDai + ChieuRong) * 2;
        }
    }

    public class HinhTron : HinhHoc
    {
        public double BanKinh { get; set; }
        public override void TinhDienTichChuVi()
        {
            DienTich = BanKinh * BanKinh;
            ChuVi = 2 * 3.14 * BanKinh;
        }
    }

}


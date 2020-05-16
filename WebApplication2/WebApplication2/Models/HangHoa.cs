using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class HangHoa
    {
        public double DonGia { get; set; }
        public string  TenHangHoa { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return $"{TenHangHoa} - {DonGia.ToString()} đ";
        }
    }
}
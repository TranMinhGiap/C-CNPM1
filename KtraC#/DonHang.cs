using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop
{
    internal class DonHang
    {
        private int madh;
        private int makh;
        private int masp;
        private int soluong;
        private string ngaymua;
        public DonHang() { }
        public DonHang(int madh, int makh, int masp, int soluong, string ngaymua)
        {
            this.madh = madh;
            this.makh = makh;
            this.masp = masp;
            this.soluong = soluong;
            this.ngaymua = ngaymua;
        }
        public int MaDH
        {
            get { return madh; }
            set { madh = value; }
        }
        public int MaKH {  get { return makh; } set { makh = value; } }
        public int MaSP { get { return masp; } set { masp = value; } }
        public int Soluong { get { return soluong; } set { soluong = value; } }
        public string NgayMua
        {
            get { return ngaymua; }
            set { ngaymua = value; }
        }
    }
}

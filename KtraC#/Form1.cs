using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Connect dbConnect = new Connect();
            string sql = $"SELECT COUNT(*) AS SoLuong FROM Nguoidung WHERE ten = '{txtUser.Text}' AND matkhau = '{txtPass.Text}'";
            DataSet ds = dbConnect.GetData(sql);
            DataTable dt = ds.Tables[0];
            int value = int.Parse(dt.Rows[0][0].ToString());
            if (value > 0)
            {
                this.Hide();
                Function frm = new Function();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                Console.WriteLine("Không có tài khoản");
            }
            //this.Hide();
            //Function frm = new Function();
            //frm.ShowDialog();
            //this.Close();

        }
    }
}

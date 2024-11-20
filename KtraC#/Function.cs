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
    public partial class Function : Form
    {
        public Function()
        {
            InitializeComponent();
            LoadDataSP();
            LoadDataKH();
            LoadDataDH();
            pnDanhmucsanpham.BringToFront();
        }
        public void LoadDataSP()
        {
            Connect dbConnect = new Connect(); // Tạo đối tượng Connect
            string sql = "SELECT * FROM Product";
            DataSet dataSet = dbConnect.GetData(sql); // Gọi GetData từ lớp Connect

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgvSanPham.DataSource = dataSet.Tables[0]; // Gắn DataTable vào DataGridView
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }
        public void LoadDataKH()
        {
            Connect dbConnect = new Connect(); // Tạo đối tượng Connect
            string sql = "SELECT * FROM KhachHang";
            DataSet dataSet = dbConnect.GetData(sql); // Gọi GetData từ lớp Connect

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgvKhachHang.DataSource = dataSet.Tables[0]; // Gắn DataTable vào DataGridView
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }
        public void LoadDataDH()
        {
            Connect dbConnect = new Connect(); // Tạo đối tượng Connect
            string sql = "SELECT * FROM DonHang";
            DataSet dataSet = dbConnect.GetData(sql); // Gọi GetData từ lớp Connect

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dgvDonHang.DataSource = dataSet.Tables[0]; // Gắn DataTable vào DataGridView
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnDanhmucsanpham.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnKhachHang.BringToFront();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connect dbConnect = new Connect();
            string sql = $"INSERT INTO DonHang VALUES ('{txtMaHD.Text}', '{txtMaKH.Text}', '{txtMaSP.Text}', '{txtSoLuong.Text}', '{txtNgayMua.Text}')";
            if(dbConnect.setData(sql))
            {
                MessageBox.Show("add successful");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            LoadDataDH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connect dbConnect = new Connect();
            string sql = $"UPDATE DonHang SET Khachhangid = '{txtMaKH.Text}', sanphamid = '{txtMaSP.Text}', soluong = '{txtSoLuong.Text}', ngaymua = '{txtNgayMua.Text}' WHERE id = '{txtMaHD.Text}'";
            if (dbConnect.setData(sql))
            {
                MessageBox.Show("update successful");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            LoadDataDH();
            button1.Enabled = true;
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvDonHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaKH.Text = dgvDonHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaSP.Text = dgvDonHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvDonHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNgayMua.Text = dgvDonHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMaHD.Enabled = false;
            txtMaKH.Enabled = false;
            txtMaSP.Enabled = false;
            button1.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connect dbConnect = new Connect();
            string sql = $"DELETE FROM DonHang WHERE id = '{txtMaHD.Text}'";
            if (dbConnect.setData(sql))
            {
                MessageBox.Show("Delete ok");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            LoadDataDH();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnDonHang.BringToFront();
        }
    }
}

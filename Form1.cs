using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_24_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<SinhVien> lst = new List<SinhVien>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            else
            {
                String ID = textBox1.Text;
                String NAME = textBox2.Text;

                String DATE = textBox6.Text;
                String ADDRESS = textBox5.Text;
                String EMAIL = textBox4.Text;
                String NUMBERPHONE = txtNUMBERPHONE.Text;
                var GENDER = cbx1.SelectedItem;
                var KHOA = cbx2.SelectedItem;

                foreach (var a in lst)
                {
                    if (ID.Equals(a.id))
                    {
                        a.id = ID;
                        a.name = NAME;
                        a.date = DATE;
                        a.address = ADDRESS;
                        a.email = EMAIL;
                        a.numberphone = NUMBERPHONE;
                        a.gender = GENDER.ToString();
                        a.khoa = KHOA.ToString();
                    }
                }


                textBox1.ReadOnly = false;
                button1.Enabled = true;
                button4.Enabled = true;
                
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lst;

                dataGridView1.ClearSelection();

                MessageBox.Show("UPDATE STUDENT SUCCESSFULL !");
            }
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String ID = textBox1.Text;
                String NAME = textBox2.Text;
                String DATE = textBox6.Text;
                String ADDRESS = textBox5.Text;
                String EMAIL = textBox4.Text;
                String NUMBERPHONE = txtNUMBERPHONE.Text;
                var GENDER = cbx1.SelectedItem;
                var KHOA = cbx2.SelectedItem;
                if (string.IsNullOrWhiteSpace(ID) || lst.Any(sv => sv.id == ID))
                    MessageBox.Show("ID NULL OR ID ALREADY EXISTS");
                else if (string.IsNullOrWhiteSpace(NAME))
                    MessageBox.Show("NAME NULL");
                else if (string.IsNullOrWhiteSpace(DATE) || (DATE.Length != 10 || DATE[2] != '/' || DATE[5] != '/'))
                    MessageBox.Show("DATE WANNING IS FORMAT");
                else if (string.IsNullOrWhiteSpace(ADDRESS))
                    MessageBox.Show("ADDRESS NULL");
                else if (!EMAIL.EndsWith("@gmail.com"))
                    MessageBox.Show("EMAIL INVALID, EMAIL MUST END WITH @gmail.com");
                else if (NUMBERPHONE.Length < 10 || NUMBERPHONE.Length > 11 || !NUMBERPHONE.All(char.IsDigit))
                    MessageBox.Show("NUMBER PHONE INVALID");
                else if (GENDER == null)
                    MessageBox.Show("GENDER NULL");
                else if (KHOA == null)
                    MessageBox.Show("KHOA NULL");
                else
                {
                    SinhVien sinhVien = new SinhVien();
                    sinhVien.id = ID;
                    sinhVien.name = NAME;
                    sinhVien.date = DATE;
                    sinhVien.address = ADDRESS;
                    sinhVien.email = EMAIL;
                    sinhVien.numberphone = NUMBERPHONE;
                    sinhVien.gender = GENDER.ToString();
                    sinhVien.khoa = KHOA.ToString();

                    lst.Add(sinhVien);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = lst;

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox6.Text = "";
                    textBox5.Text = "";
                    textBox4.Text = "";
                    txtNUMBERPHONE.Text = "";
                    cbx1.SelectedIndex = -1;
                    cbx2.SelectedIndex = -1;

                    dataGridView1.ClearSelection();

                    MessageBox.Show("ADD STUDENT SUCCESSFULL !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("PLEASE SELECT A ROW TO DELETE.");
                return;
            }
            else
            {
                String ID = textBox1.Text;

                List<SinhVien> sinhVienToRemove = new List<SinhVien>();

                foreach (var a in lst)
                {
                    if (ID.Equals(a.id))
                    {
                        sinhVienToRemove.Add(a);
                    }
                }

                foreach (var sv in sinhVienToRemove)
                {
                    lst.Remove(sv);
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lst;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                txtNUMBERPHONE.Text = "";
                cbx1.SelectedIndex = -1;
                cbx2.SelectedIndex = -1;

                MessageBox.Show("DELETE STUDENT SUCCESSFULLY!");
            }

            dataGridView1.ClearSelection();

            textBox1.ReadOnly = false;
            button1.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text= "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            txtNUMBERPHONE.Text = "";
            cbx1.SelectedIndex = -1;
            cbx2.SelectedIndex = -1;
            //textBox1.ReadOnly=false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = selectRow.Cells[0].Value.ToString();
                textBox2.Text = selectRow.Cells[1].Value.ToString();
                textBox6.Text = selectRow.Cells[5].Value.ToString();
                textBox5.Text = selectRow.Cells[2].Value.ToString();
                textBox4.Text = selectRow.Cells[4].Value.ToString();
                txtNUMBERPHONE.Text = selectRow.Cells[3].Value.ToString();
                cbx1.SelectedItem = selectRow.Cells[6].Value.ToString();
                cbx2.SelectedItem = selectRow.Cells[7].Value.ToString();

                textBox1.ReadOnly = true;
                button4.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("CHOICE STUDENT WANT UPDATE IN TABLE !");
            }
        }
    }
}

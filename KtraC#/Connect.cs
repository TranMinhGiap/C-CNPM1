using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    internal class Connect
    {
        SqlConnection conn;
        string constr = "Data Source=DESKTOP-VDPSTNV;Initial Catalog=MobileShop;User ID=sa;Password=123456";

        public Connect() { 
            conn = new SqlConnection(constr);
        }
        public DataSet GetData(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();

                SqlDataAdapter dap  = new SqlDataAdapter(sql, conn);
                dap.Fill(ds);
                return ds;
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }


        public bool setData(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

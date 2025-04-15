using MobileShop.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    internal class MainClass
    {
        //Connection string
        public static readonly string con_string = "Data Source = MSIGRATDRAGON; Initial Catalog = DBMobile; Integrated Security = True; Encrypt=False";
        public static SqlConnection con = new SqlConnection(con_string);
        private static Image blurredBackground;

        //User Validation
        public static bool IsValidUser(string username, String password)
        {
            bool isValid = false;

            string qry = @"Select * from users where username ='" + username + "' and upass = '" + password + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
            }
            return isValid;
        }

        // for Insert, Update, Delete
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }
        // Get the datatable for edit

        public static DataTable GetData(string qry)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        //Load Data into datagridview
        public static void LoadData(string qry, DataGridView gv)
        {
            // Serial no in gridview

            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_llFormatting);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private static void gv_llFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.guna2DataGridView gv = (Guna.UI2.WinForms.guna2DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        //clear controls an form

        public static void ClearAll(Form F)
        {
            foreach (Control c in F.Controls)
            {
                Type type = c.GetType();

                if (type == typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                    t.Text = "";
                }
                else if (type == typeof(Guna.UI2.WinForms.Guna2CheckBox))
                {
                    Guna.UI2.WinForms.Guna2ComboBox cb = (Guna.UI2.WinForms.Guna2ComboBox)c;
                    cb.SelectedIndex = 0;
                    cb.SelectedIndex = -1;
                }
                else if (type == typeof(CheckBox))
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }
        // ComboBox Fill
        public static void CBFill(string qry, ComboBox cb)
        {
            using (SqlCommand cmd = new SqlCommand(qry, con))
            {
                cmd.CommandType = CommandType.Text;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cb.DisplayMember = "name";     // column name in your query result
                    cb.ValueMember = "id";         // column value in your query result
                    cb.DataSource = dt;
                    cb.SelectedIndex = -1;         // no item selected initially
                }
            }
        }

        internal static void BlurBackground(FormUserView formUserView)
        {
            throw new NotImplementedException();
        }
    }
}

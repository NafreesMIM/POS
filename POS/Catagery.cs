using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Catagery : Form
    {
        SqlConnection cnct = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PosSys;Integrated Security=True");
        DataTable dt;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        int catID;
        public Catagery()
        {
            InitializeComponent();
            dataCode();

        }
        void dataCode()
        {
            cnct.Open();
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM cat_Tbl", cnct);
            adapter.Fill(dt);
            dgvCat.DataSource = dt;
            cnct.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            cnct.Open();

            if (textBoxCatName.Text != string.Empty)
            {
                cmd = new SqlCommand("SELECT * FROM cat_Tbl WHERE catName='" + textBoxCatName.Text + "' ", cnct);
                adapter = new SqlDataAdapter(cmd);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    MessageBox.Show("This Data Already Exist!");
                    ds.Clear();
                    rdr.Close();
                    cnct.Close();
                    return;
                }

                cnct.Close();
                cnct.Open();
                cmd = new SqlCommand("INSERT INTO cat_Tbl(catName)  Values(@catname)", cnct);
                cmd.Parameters.AddWithValue("@catname", textBoxCatName.Text);
                cmd.ExecuteNonQuery();
                cnct.Close();


                MessageBox.Show("Saved Successfully!");
                dataCode();
                textBoxCatName.Clear();
                textBoxCatName.Select();

            }
            else
            {
                MessageBox.Show("Please Enter the Catagory Name!");
            }
        }

        private void dgv2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cnct.Open();
            catID = int.Parse(dgvCat.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxCatName.Text = dgvCat.Rows[e.RowIndex].Cells[1].Value.ToString();
            cnct.Close() ;
        }

        private void buttonDlt_Click(object sender, EventArgs e)
        {
            cnct.Open();
            cmd = new SqlCommand("DELETE FROM  cat_Tbl WHERE ctaID = @catID", cnct);
            cmd.Parameters.AddWithValue("@catID", catID);
            cmd.Parameters.AddWithValue("@catname", textBoxCatName.Text);
            cmd.ExecuteNonQuery();
            cnct.Close();
            MessageBox.Show("Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataCode();
            textBoxCatName.Clear();
            textBoxCatName.Select();
        }
    }
}

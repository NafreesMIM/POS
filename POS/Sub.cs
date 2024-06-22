using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Sub : Form
    {
        SqlConnection cnct = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PosSys;Integrated Security=True");
        DataTable dt;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        int sID;
        public Sub()
        {
            InitializeComponent();
            dataCode();
        }
        void dataCode()
        {
            cnct.Open();
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM sub_Tbl", cnct);
            adapter.Fill(dt);
            dgv2.DataSource = dt;
            cnct.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            cnct.Open();
            if (textBoxSubName.Text != string.Empty)
            {
                cmd = new SqlCommand("SELECT * FROM sub_Tbl WHERE subName='" + textBoxSubName.Text + "' ", cnct);
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
                cmd = new SqlCommand("INSERT INTO sub_Tbl(subName)  Values(@subName)", cnct);
                cmd.Parameters.AddWithValue("@subName", textBoxSubName.Text);
                cmd.ExecuteNonQuery();
                cnct.Close();


                MessageBox.Show("Saved Successfully!");
                dataCode();
                textBoxSubName.Clear();
                textBoxSubName.Select();

            }
            else
            {
                MessageBox.Show("Please Enter the Catagory Name!");
            }
        }

        private void buttonDlt_Click(object sender, EventArgs e)
        {
            cnct.Open();
            cmd = new SqlCommand("DELETE  FROM  sub_Tbl WHERE subId = @bID", cnct);
            cmd.Parameters.AddWithValue("@bID", sID);
            cmd.Parameters.AddWithValue("@bname", textBoxSubName.Text);
            cmd.ExecuteNonQuery();
            cnct.Close();
            MessageBox.Show("Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataCode();
            textBoxSubName.Clear();
            textBoxSubName.Select();
        }

        private void dgv2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cnct.Open();
            sID = int.Parse(dgv2.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxSubName.Text = dgv2.Rows[e.RowIndex].Cells[1].Value.ToString();
            cnct.Close();
        }
    }
}

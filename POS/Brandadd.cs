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
    public partial class Brandadd : Form
    {

        SqlConnection cnct = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PosSys;Integrated Security=True");
        DataTable dt;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        int bID;
        public Brandadd()
        {
            InitializeComponent();
            dataCode();
        }
        void dataCode()
        {
            cnct.Open();
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM brand_Tbl", cnct);
            adapter.Fill(dt);
            dgvBrd.DataSource = dt;
            cnct.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            cnct.Open();
            if (textBoxbName.Text != string.Empty)
            {
                cmd = new SqlCommand("SELECT * FROM brand_Tbl WHERE bName='" + textBoxbName.Text + "' ", cnct);
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
                cmd = new SqlCommand("INSERT INTO brand_Tbl(bName)  Values(@bName)", cnct);
                cmd.Parameters.AddWithValue("@bName", textBoxbName.Text);
                cmd.ExecuteNonQuery();
                cnct.Close();


                MessageBox.Show("Saved Successfully!");
                dataCode();
                textBoxbName.Clear();
                textBoxbName.Select();

            }
            else
            {
                MessageBox.Show("Please Enter the Catagory Name!");
            }
        }

        private void dgvBrd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            cnct.Open();
            bID = int.Parse(dgvBrd.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxbName.Text = dgvBrd.Rows[e.RowIndex].Cells[1].Value.ToString();
            cnct.Close();
        }

        private void buttonDlt_Click(object sender, EventArgs e)
        {
            cnct.Open();
            cmd = new SqlCommand("DELETE FROM  brand_Tbl WHERE bID = @bID", cnct);
            cmd.Parameters.AddWithValue("@bID", bID);
            cmd.Parameters.AddWithValue("@bName", textBoxbName.Text);
            cmd.ExecuteNonQuery();
            cnct.Close();
            MessageBox.Show("Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataCode();
            textBoxbName.Clear();
            textBoxbName.Select();
        }
    }
}

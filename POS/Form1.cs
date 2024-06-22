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
    public partial class Form1 : Form
    {
        SqlConnection cnct = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PosSys;Integrated Security=True");
        DataTable dt;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
            dataCode();
            catdisplayData();
            bddisplayData();
            subdisplayData();
            textBoxPmargin.Clear();
            textBoxPname.Select();
            dgv.Columns[0].Visible = false;

        }
        void dataCode()
        {
            cnct.Open();
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM pEntry_Tbl", cnct);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            cnct.Close();
        }
        void catdisplayData()
        {
            cnct.Open();
            string query = "SELECT * FROM cat_Tbl";


            using (SqlCommand command = new SqlCommand(query, cnct))
            {
                // Execute the query and retrieve data
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add each item to the ComboBox
                    comboBoxCat.Items.Add(reader["catName"].ToString());
                }


                // Close the SqlDataReader
                reader.Close();
            }
            cnct.Close();
        }
        void bddisplayData()
        {
            cnct.Open();
            string query = "SELECT * FROM brand_Tbl";


            using (SqlCommand command = new SqlCommand(query, cnct))
            {
                // Execute the query and retrieve data
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add each item to the ComboBox
                    comboBoxBraand.Items.Add(reader["bName"].ToString());
                }


                // Close the SqlDataReader
                reader.Close();
            }
            cnct.Close();
        }
        void subdisplayData()
        {
            cnct.Open();
            string query = "SELECT * FROM sub_Tbl";


            using (SqlCommand command = new SqlCommand(query, cnct))
            {
                // Execute the query and retrieve data
                SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add each item to the ComboBox
                        comboBoxSub.Items.Add(reader["subName"].ToString());
                    }
                

                // Close the SqlDataReader
                reader.Close();
            }
            cnct.Close();
        }
      
            void clear()
        {
             textBoxPname.Clear();
             textBoxTtCost.Clear();
            textBoxUprice.Clear();
            textBoxPmargin.Clear();
            textBoxQty.Clear();
            textBoxTtCost.Clear();
            textBoxTprofit.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            cnct.Open();

            if (textBoxPname.Text != string.Empty && textBoxUcost.Text != string.Empty && textBoxUprice.Text != string.Empty && textBoxPmargin.Text != string.Empty && textBoxQty.Text != string.Empty && textBoxTtCost.Text != string.Empty && textBoxTprofit.Text != string.Empty && comboBoxCat.Text != string.Empty && comboBoxBraand.Text != string.Empty && textBoxBrCode.Text != string.Empty && comboBoxSub.Text != string.Empty)
            {
              
                cmd = new SqlCommand("INSERT INTO pEntry_Tbl(proName,unitCost,unitPrice,profitMargin,qtt,ttCost,ttProfit,catgary,brand,barccod,Sublier) " +
                    " Values(@proName,@unitCost,@unitPrice,@profitMargin,@qtt,@ttcost,@ttProfit,@catagary,@brand,@barcode,@Sublier)", cnct);
                cmd.Parameters.AddWithValue("@proName", textBoxPname.Text);
                cmd.Parameters.AddWithValue("@unitCost", textBoxTtCost.Text);
                cmd.Parameters.AddWithValue("@unitPrice", textBoxUprice.Text);
                cmd.Parameters.AddWithValue("@profitMargin", textBoxPmargin.Text);
                cmd.Parameters.AddWithValue("@qtt", textBoxQty.Text);
                cmd.Parameters.AddWithValue("@ttcost", textBoxTtCost.Text);
                cmd.Parameters.AddWithValue("@ttProfit", textBoxTprofit.Text);
                cmd.Parameters.AddWithValue("@catagary", comboBoxCat.Text);
                cmd.Parameters.AddWithValue("@brand", comboBoxBraand.Text);
                cmd.Parameters.AddWithValue("@barcode", textBoxBrCode.Text);
                cmd.Parameters.AddWithValue("@Sublier", comboBoxSub.Text);
                cmd.ExecuteNonQuery();
                cnct.Close();
                //MessageBox.Show("Saved Successfully!");
                dataCode();
                clear();
                textBoxPname.Select();

            }
            else
            {
                MessageBox.Show("Please Enter All Details!");
                textBoxPname.Select();
            }
            cnct.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonGnrt_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textBoxBrCode.Text=random.Next().ToString();
        }
        private void textBoxUprice_TextChanged(object sender, EventArgs e)
        {

            if (textBoxUcost.Text != string.Empty && textBoxUprice.Text != string.Empty)
            {
                int ucost = int.Parse(textBoxUcost.Text);
                int uprc = int.Parse(textBoxUprice.Text);
                int tot = uprc - ucost;
                textBoxPmargin.Text = tot.ToString();
            }
            else
            {
                textBoxPmargin.Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catagery frm=new Catagery();
            frm.ShowDialog();
        }

        private void textBoxQty_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUcost.Text != string.Empty && textBoxQty.Text != string.Empty)
            {
                int ucost = int.Parse(textBoxUcost.Text);
                int qtt = int.Parse(textBoxQty.Text);
                int tot = qtt * ucost;
                textBoxTtCost.Text =  tot.ToString();
            }
            else
            {

                textBoxTtCost.Clear();
            }
            if (textBoxUcost.Text != string.Empty && textBoxQty.Text != string.Empty)
            {
                int ucost = int.Parse(textBoxPmargin.Text);
                int qtt = int.Parse(textBoxQty.Text);
                int tot = qtt * ucost;
                textBoxTprofit.Text = tot.ToString();
            }
            else
            {
                textBoxTprofit.Clear();

            }

        }

        private void textBoxUcost_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUcost.Text != string.Empty && textBoxUprice.Text != string.Empty)
            {
                int ucost = int.Parse(textBoxUcost.Text);
                int uprc = int.Parse(textBoxUprice.Text);
                int tot = uprc - ucost;
                textBoxPmargin.Text = tot.ToString();
            }
            else
            {
                textBoxPmargin.Clear() ;

            }
            if (textBoxUcost.Text != string.Empty && textBoxQty.Text != string.Empty)
            {
                int ucost = int.Parse(textBoxUcost.Text);
                int qtt = int.Parse(textBoxQty.Text);
                int tot = qtt * ucost;
                textBoxTtCost.Text =tot.ToString();
            }
            else
            {
                textBoxTtCost.Clear();
            }
        }

        private void textBoxUcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Connot contain Letters!");
            }
        }

        private void textBoxUprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Connot contain Letters!");
            }
        }

        private void textBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Connot contain Letters!");
            }
        }

        private void textBoxPmargin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Connot contain Letters!");
            }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catagery frm=new Catagery();
            frm.ShowDialog();
            comboBoxCat.Items.Clear();
            catdisplayData();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brandadd frm = new Brandadd();
            frm.ShowDialog();
            comboBoxBraand.Items.Clear();
            bddisplayData();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sub frm = new Sub();
            frm.ShowDialog();
            comboBoxSub.Items.Clear();
            subdisplayData();
        }
    }
}

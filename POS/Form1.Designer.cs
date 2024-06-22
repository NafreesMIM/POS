namespace POS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.textBoxUcost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPmargin = new System.Windows.Forms.TextBox();
            this.textBoxTtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.textBoxTprofit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.comboBoxBraand = new System.Windows.Forms.ComboBox();
            this.textBoxBrCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxSub = new System.Windows.Forms.ComboBox();
            this.buttonGnrt = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPID
            // 
            this.textBoxPID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPID.Enabled = false;
            this.textBoxPID.Location = new System.Drawing.Point(38, 36);
            this.textBoxPID.Name = "textBoxPID";
            this.textBoxPID.Size = new System.Drawing.Size(163, 20);
            this.textBoxPID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pro_Name";
            // 
            // textBoxPname
            // 
            this.textBoxPname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPname.Location = new System.Drawing.Point(207, 36);
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(224, 20);
            this.textBoxPname.TabIndex = 2;
            // 
            // textBoxUcost
            // 
            this.textBoxUcost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUcost.Location = new System.Drawing.Point(437, 36);
            this.textBoxUcost.Name = "textBoxUcost";
            this.textBoxUcost.Size = new System.Drawing.Size(274, 20);
            this.textBoxUcost.TabIndex = 3;
            this.textBoxUcost.TextChanged += new System.EventHandler(this.textBoxUcost_TextChanged);
            this.textBoxUcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUcost_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit_Cost";
            // 
            // textBoxUprice
            // 
            this.textBoxUprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUprice.Location = new System.Drawing.Point(717, 36);
            this.textBoxUprice.Name = "textBoxUprice";
            this.textBoxUprice.Size = new System.Drawing.Size(167, 20);
            this.textBoxUprice.TabIndex = 4;
            this.textBoxUprice.TextChanged += new System.EventHandler(this.textBoxUprice_TextChanged);
            this.textBoxUprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUprice_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit_Price";
            // 
            // textBoxPmargin
            // 
            this.textBoxPmargin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPmargin.Enabled = false;
            this.textBoxPmargin.Location = new System.Drawing.Point(38, 98);
            this.textBoxPmargin.Name = "textBoxPmargin";
            this.textBoxPmargin.Size = new System.Drawing.Size(163, 20);
            this.textBoxPmargin.TabIndex = 0;
            this.textBoxPmargin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPmargin_KeyPress);
            // 
            // textBoxTtCost
            // 
            this.textBoxTtCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTtCost.Enabled = false;
            this.textBoxTtCost.Location = new System.Drawing.Point(437, 98);
            this.textBoxTtCost.Name = "textBoxTtCost";
            this.textBoxTtCost.Size = new System.Drawing.Size(274, 20);
            this.textBoxTtCost.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Profit Margin";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Cost";
            // 
            // textBoxQty
            // 
            this.textBoxQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQty.Location = new System.Drawing.Point(207, 98);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(224, 20);
            this.textBoxQty.TabIndex = 5;
            this.textBoxQty.TextChanged += new System.EventHandler(this.textBoxQty_TextChanged);
            this.textBoxQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQty_KeyPress);
            // 
            // textBoxTprofit
            // 
            this.textBoxTprofit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTprofit.Enabled = false;
            this.textBoxTprofit.Location = new System.Drawing.Point(717, 98);
            this.textBoxTprofit.Name = "textBoxTprofit";
            this.textBoxTprofit.Size = new System.Drawing.Size(167, 20);
            this.textBoxTprofit.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Qty";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(717, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total Profit";
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(38, 160);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCat.TabIndex = 8;
            // 
            // comboBoxBraand
            // 
            this.comboBoxBraand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBraand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBraand.FormattingEnabled = true;
            this.comboBoxBraand.Location = new System.Drawing.Point(207, 160);
            this.comboBoxBraand.Name = "comboBoxBraand";
            this.comboBoxBraand.Size = new System.Drawing.Size(224, 21);
            this.comboBoxBraand.TabIndex = 9;
            // 
            // textBoxBrCode
            // 
            this.textBoxBrCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBrCode.Enabled = false;
            this.textBoxBrCode.Location = new System.Drawing.Point(717, 160);
            this.textBoxBrCode.Name = "textBoxBrCode";
            this.textBoxBrCode.Size = new System.Drawing.Size(167, 20);
            this.textBoxBrCode.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Catagory";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(717, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Barcode";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Brand";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(274, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Supplier";
            // 
            // comboBoxSub
            // 
            this.comboBoxSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSub.FormattingEnabled = true;
            this.comboBoxSub.Location = new System.Drawing.Point(437, 160);
            this.comboBoxSub.Name = "comboBoxSub";
            this.comboBoxSub.Size = new System.Drawing.Size(274, 21);
            this.comboBoxSub.TabIndex = 10;
            // 
            // buttonGnrt
            // 
            this.buttonGnrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGnrt.Location = new System.Drawing.Point(717, 190);
            this.buttonGnrt.Name = "buttonGnrt";
            this.buttonGnrt.Size = new System.Drawing.Size(167, 23);
            this.buttonGnrt.TabIndex = 12;
            this.buttonGnrt.Text = "Generate";
            this.buttonGnrt.UseVisualStyleBackColor = true;
            this.buttonGnrt.Click += new System.EventHandler(this.buttonGnrt_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(717, 222);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(167, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save Data";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 332);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1009, 252);
            this.dgv.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.02092F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.64017F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.21758F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.12134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxUprice, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTprofit, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBrCode, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonGnrt, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUcost, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTtCost, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSub, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPname, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxQty, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBraand, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPmargin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCat, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 250);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.brandToolStripMenuItem,
            this.supplierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.brandToolStripMenuItem.Text = "Brand";
            this.brandToolStripMenuItem.Click += new System.EventHandler(this.brandToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.supplierToolStripMenuItem.Text = "supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 584);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodect Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.TextBox textBoxUcost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPmargin;
        private System.Windows.Forms.TextBox textBoxTtCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.TextBox textBoxTprofit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.ComboBox comboBoxBraand;
        private System.Windows.Forms.TextBox textBoxBrCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxSub;
        private System.Windows.Forms.Button buttonGnrt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
    }
}


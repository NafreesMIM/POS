namespace POS
{
    partial class Catagery
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCatName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDlt = new System.Windows.Forms.Button();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Catogery Name:";
            // 
            // textBoxCatName
            // 
            this.textBoxCatName.Location = new System.Drawing.Point(110, 27);
            this.textBoxCatName.Name = "textBoxCatName";
            this.textBoxCatName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCatName.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Blue;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(29, 62);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Add";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDlt
            // 
            this.buttonDlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDlt.Location = new System.Drawing.Point(110, 62);
            this.buttonDlt.Name = "buttonDlt";
            this.buttonDlt.Size = new System.Drawing.Size(75, 23);
            this.buttonDlt.TabIndex = 4;
            this.buttonDlt.Text = "Remove";
            this.buttonDlt.UseVisualStyleBackColor = true;
            this.buttonDlt.Click += new System.EventHandler(this.buttonDlt_Click);
            // 
            // dgvCat
            // 
            this.dgvCat.AllowUserToAddRows = false;
            this.dgvCat.AllowUserToDeleteRows = false;
            this.dgvCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCat.Location = new System.Drawing.Point(0, 109);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.ReadOnly = true;
            this.dgvCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCat.Size = new System.Drawing.Size(218, 173);
            this.dgvCat.TabIndex = 5;
            this.dgvCat.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv2_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ctaID";
            this.Column1.HeaderText = "catID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "catName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Catagery
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 282);
            this.Controls.Add(this.dgvCat);
            this.Controls.Add(this.buttonDlt);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCatName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Catagery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catagery Entry";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCatName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDlt;
        private System.Windows.Forms.DataGridView dgvCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
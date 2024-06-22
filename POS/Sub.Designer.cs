namespace POS
{
    partial class Sub
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
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.buttonDlt = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSubName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv2.Location = new System.Drawing.Point(0, 109);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(218, 173);
            this.dgv2.TabIndex = 16;
            this.dgv2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv2_RowHeaderMouseClick);
            // 
            // buttonDlt
            // 
            this.buttonDlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDlt.Location = new System.Drawing.Point(115, 56);
            this.buttonDlt.Name = "buttonDlt";
            this.buttonDlt.Size = new System.Drawing.Size(75, 23);
            this.buttonDlt.TabIndex = 15;
            this.buttonDlt.Text = "Remove";
            this.buttonDlt.UseVisualStyleBackColor = true;
            this.buttonDlt.Click += new System.EventHandler(this.buttonDlt_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Blue;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(29, 56);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Add";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSubName
            // 
            this.textBoxSubName.Location = new System.Drawing.Point(115, 13);
            this.textBoxSubName.Name = "textBoxSubName";
            this.textBoxSubName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Brand Name:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "subId";
            this.Column1.HeaderText = "Sublier ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "subName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Sub
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 282);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.buttonDlt);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSubName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sublier Entry";
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button buttonDlt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSubName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
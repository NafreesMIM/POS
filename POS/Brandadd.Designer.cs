namespace POS
{
    partial class Brandadd
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
            this.dgvBrd = new System.Windows.Forms.DataGridView();
            this.buttonDlt = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBrd
            // 
            this.dgvBrd.AllowUserToAddRows = false;
            this.dgvBrd.AllowUserToDeleteRows = false;
            this.dgvBrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvBrd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBrd.Location = new System.Drawing.Point(0, 109);
            this.dgvBrd.Name = "dgvBrd";
            this.dgvBrd.ReadOnly = true;
            this.dgvBrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrd.Size = new System.Drawing.Size(218, 173);
            this.dgvBrd.TabIndex = 11;
            this.dgvBrd.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBrd_RowHeaderMouseClick);
            // 
            // buttonDlt
            // 
            this.buttonDlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDlt.Location = new System.Drawing.Point(115, 65);
            this.buttonDlt.Name = "buttonDlt";
            this.buttonDlt.Size = new System.Drawing.Size(75, 23);
            this.buttonDlt.TabIndex = 10;
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
            this.buttonSave.Location = new System.Drawing.Point(29, 65);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Add";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxbName
            // 
            this.textBoxbName.Location = new System.Drawing.Point(115, 26);
            this.textBoxbName.Name = "textBoxbName";
            this.textBoxbName.Size = new System.Drawing.Size(100, 20);
            this.textBoxbName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Brand Name:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "bID";
            this.Column1.HeaderText = "Brand Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "bName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Brandadd
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 282);
            this.Controls.Add(this.dgvBrd);
            this.Controls.Add(this.buttonDlt);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxbName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Brandadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brand Entry";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBrd;
        private System.Windows.Forms.Button buttonDlt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
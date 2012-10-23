namespace TPVTAC
{
    partial class FEntraus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Uno = new System.Windows.Forms.DataGridViewImageColumn();
            this.Dos = new System.Windows.Forms.DataGridViewImageColumn();
            this.Tres = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cuatro = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cinco = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 69);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uno,
            this.Dos,
            this.Tres,
            this.Cuatro,
            this.Cinco});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(818, 311);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Uno
            // 
            this.Uno.HeaderText = "Uno";
            this.Uno.Name = "Uno";
            this.Uno.ReadOnly = true;
            // 
            // Dos
            // 
            this.Dos.HeaderText = "Dos";
            this.Dos.Name = "Dos";
            this.Dos.ReadOnly = true;
            // 
            // Tres
            // 
            this.Tres.HeaderText = "Tres";
            this.Tres.Name = "Tres";
            this.Tres.ReadOnly = true;
            // 
            // Cuatro
            // 
            this.Cuatro.HeaderText = "Cuatro";
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.ReadOnly = true;
            // 
            // Cinco
            // 
            this.Cinco.HeaderText = "Cinco";
            this.Cinco.Name = "Cinco";
            this.Cinco.ReadOnly = true;
            // 
            // FEntraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FEntraus";
            this.Text = "FEntraus";
            this.Load += new System.EventHandler(this.FEntraus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Uno;
        private System.Windows.Forms.DataGridViewImageColumn Dos;
        private System.Windows.Forms.DataGridViewImageColumn Tres;
        private System.Windows.Forms.DataGridViewImageColumn Cuatro;
        private System.Windows.Forms.DataGridViewImageColumn Cinco;
    }
}
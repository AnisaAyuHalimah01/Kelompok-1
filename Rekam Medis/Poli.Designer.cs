namespace Rekam_Medis
{
    partial class Poli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poli));
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtkodepoli = new System.Windows.Forms.TextBox();
            this.dgvkelas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtcaridata = new System.Windows.Forms.ToolStripTextBox();
            this.btncari = new System.Windows.Forms.ToolStripButton();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkelas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnama
            // 
            this.txtnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtnama.Location = new System.Drawing.Point(210, 232);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(248, 26);
            this.txtnama.TabIndex = 15;
            // 
            // txtkodepoli
            // 
            this.txtkodepoli.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkodepoli.Location = new System.Drawing.Point(210, 183);
            this.txtkodepoli.Name = "txtkodepoli";
            this.txtkodepoli.Size = new System.Drawing.Size(165, 30);
            this.txtkodepoli.TabIndex = 14;
            // 
            // dgvkelas
            // 
            this.dgvkelas.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dgvkelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkelas.GridColor = System.Drawing.Color.OliveDrab;
            this.dgvkelas.Location = new System.Drawing.Point(61, 299);
            this.dgvkelas.Name = "dgvkelas";
            this.dgvkelas.RowTemplate.Height = 28;
            this.dgvkelas.Size = new System.Drawing.Size(535, 246);
            this.dgvkelas.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(78, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nama Poli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(78, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kode Poli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(302, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "FORM POLI";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtcaridata,
            this.btncari});
            this.toolStrip1.Location = new System.Drawing.Point(387, 114);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(302, 31);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(160, 28);
            this.toolStripLabel1.Text = "Pencarian Data    ";
            // 
            // txtcaridata
            // 
            this.txtcaridata.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaridata.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtcaridata.Name = "txtcaridata";
            this.txtcaridata.Size = new System.Drawing.Size(100, 31);
            this.txtcaridata.Text = "no pasien";
            // 
            // btncari
            // 
            this.btncari.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncari.Image = ((System.Drawing.Image)(resources.GetObject("btncari.Image")));
            this.btncari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(28, 28);
            this.btncari.Text = "toolStripButton1";
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.OliveDrab;
            this.btnhapus.FlatAppearance.BorderSize = 0;
            this.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhapus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.Image = ((System.Drawing.Image)(resources.GetObject("btnhapus.Image")));
            this.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhapus.Location = new System.Drawing.Point(640, 438);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(162, 40);
            this.btnhapus.TabIndex = 21;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.OliveDrab;
            this.btnubah.FlatAppearance.BorderSize = 0;
            this.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnubah.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnubah.Image = ((System.Drawing.Image)(resources.GetObject("btnubah.Image")));
            this.btnubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnubah.Location = new System.Drawing.Point(640, 368);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(162, 40);
            this.btnubah.TabIndex = 20;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.OliveDrab;
            this.btnsimpan.FlatAppearance.BorderSize = 0;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnsimpan.Image")));
            this.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsimpan.Location = new System.Drawing.Point(641, 299);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(161, 40);
            this.btnsimpan.TabIndex = 19;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.OliveDrab;
            this.btntambah.FlatAppearance.BorderSize = 0;
            this.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntambah.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.Image = ((System.Drawing.Image)(resources.GetObject("btntambah.Image")));
            this.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntambah.Location = new System.Drawing.Point(641, 505);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(161, 40);
            this.btntambah.TabIndex = 18;
            this.btntambah.Text = "Reset";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(21, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 43);
            this.button4.TabIndex = 22;
            this.button4.Text = " ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Poli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(861, 590);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtkodepoli);
            this.Controls.Add(this.dgvkelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Poli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelas";
            this.Load += new System.EventHandler(this.Kelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkelas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtkodepoli;
        private System.Windows.Forms.DataGridView dgvkelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtcaridata;
        private System.Windows.Forms.ToolStripButton btncari;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button button4;
    }
}
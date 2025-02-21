namespace Kasir_Restoran
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
            this.lblNamaMakanan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtNamaMakanan = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lstPesanan = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBayar = new System.Windows.Forms.Button();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.lblBayar = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNamaMakanan
            // 
            this.lblNamaMakanan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNamaMakanan.AutoSize = true;
            this.lblNamaMakanan.Location = new System.Drawing.Point(63, 89);
            this.lblNamaMakanan.Name = "lblNamaMakanan";
            this.lblNamaMakanan.Size = new System.Drawing.Size(103, 16);
            this.lblNamaMakanan.TabIndex = 0;
            this.lblNamaMakanan.Text = "Nama Makanan";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 12;
            // 
            // lblHarga
            // 
            this.lblHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(736, 39);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(45, 16);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "Harga";
            // 
            // lblJumlah
            // 
            this.lblJumlah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(52, 110);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(50, 16);
            this.lblJumlah.TabIndex = 3;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(736, 331);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(102, 16);
            this.lblSubTotal.TabIndex = 4;
            this.lblSubTotal.Text = "Sub Total: Rp. 0";
            // 
            // txtNamaMakanan
            // 
            this.txtNamaMakanan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNamaMakanan.Location = new System.Drawing.Point(324, 80);
            this.txtNamaMakanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamaMakanan.Name = "txtNamaMakanan";
            this.txtNamaMakanan.Size = new System.Drawing.Size(273, 22);
            this.txtNamaMakanan.TabIndex = 5;
            // 
            // txtHarga
            // 
            this.txtHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHarga.Location = new System.Drawing.Point(909, 37);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(273, 22);
            this.txtHarga.TabIndex = 6;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJumlah.Location = new System.Drawing.Point(315, 106);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(273, 22);
            this.txtJumlah.TabIndex = 7;
            // 
            // btnHitung
            // 
            this.btnHitung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHitung.BackColor = System.Drawing.Color.Orange;
            this.btnHitung.Location = new System.Drawing.Point(739, 87);
            this.btnHitung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(136, 38);
            this.btnHitung.TabIndex = 8;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.Orange;
            this.btnReset.Location = new System.Drawing.Point(635, 455);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 38);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKeluar.BackColor = System.Drawing.Color.Red;
            this.btnKeluar.Location = new System.Drawing.Point(1181, 11);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(136, 36);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // lstPesanan
            // 
            this.lstPesanan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstPesanan.FormattingEnabled = true;
            this.lstPesanan.ItemHeight = 16;
            this.lstPesanan.Location = new System.Drawing.Point(20, 150);
            this.lstPesanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPesanan.Name = "lstPesanan";
            this.lstPesanan.Size = new System.Drawing.Size(1265, 164);
            this.lstPesanan.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnBayar);
            this.groupBox1.Controls.Add(this.lblKembalian);
            this.groupBox1.Controls.Add(this.txtBayar);
            this.groupBox1.Controls.Add(this.lblBayar);
            this.groupBox1.Controls.Add(this.lblTax);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lstPesanan);
            this.groupBox1.Controls.Add(this.lblHarga);
            this.groupBox1.Controls.Add(this.txtHarga);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.lblJumlah);
            this.groupBox1.Controls.Add(this.btnHitung);
            this.groupBox1.Controls.Add(this.txtJumlah);
            this.groupBox1.Controls.Add(this.lblSubTotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1307, 521);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaksi Kasir";
            // 
            // btnBayar
            // 
            this.btnBayar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBayar.BackColor = System.Drawing.Color.Orange;
            this.btnBayar.Location = new System.Drawing.Point(492, 455);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(136, 38);
            this.btnBayar.TabIndex = 17;
            this.btnBayar.Text = "Simpan";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // lblKembalian
            // 
            this.lblKembalian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Location = new System.Drawing.Point(1001, 364);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(108, 16);
            this.lblKembalian.TabIndex = 16;
            this.lblKembalian.Text = "Kembalian: Rp. 0";
            // 
            // txtBayar
            // 
            this.txtBayar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBayar.Location = new System.Drawing.Point(1091, 325);
            this.txtBayar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(195, 22);
            this.txtBayar.TabIndex = 15;
            // 
            // lblBayar
            // 
            this.lblBayar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBayar.AutoSize = true;
            this.lblBayar.Location = new System.Drawing.Point(1001, 331);
            this.lblBayar.Name = "lblBayar";
            this.lblBayar.Size = new System.Drawing.Size(49, 16);
            this.lblBayar.TabIndex = 14;
            this.lblBayar.Text = "Bayar :";
            // 
            // lblTax
            // 
            this.lblTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(736, 364);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(67, 16);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "Tax: Rp. 0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(736, 399);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 16);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total: Rp. 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 582);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.txtNamaMakanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNamaMakanan);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Kasir Restoran";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamaMakanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtNamaMakanan;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.ListBox lstPesanan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Label lblBayar;
    }
}


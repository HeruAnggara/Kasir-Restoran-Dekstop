using System;
using System.Windows.Forms;

namespace Kasir_Restoran
{
    public partial class Form1 : Form
    {
        // Deklarasi variabel untuk sub total harga
        double subTotalHarga = 0;

        // Deklarasi variabel untuk tax harga
        double taxHarga = 0;
        double taxDefault = 0.1;

        // Deklarasi variabel untuk total harga
        double totalHarga = 0;

        // Deklarasi variabel untuk kembalian
        double kembalianBayaran = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Event untuk tombol Hitung
        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil data dari TextBox
                string namaMakanan = txtNamaMakanan.Text;
                int jumlah = Convert.ToInt32(txtJumlah.Text);
                double harga = Convert.ToDouble(txtHarga.Text);

                // Hitung subtotal
                double subtotal = jumlah * harga;

                //Hitung Tax
                double tax = subtotal * taxDefault;

                //Hitung total
                double total = subtotal + tax;

                // Tambahkan ke sub total harga
                subTotalHarga += subtotal;

                // Tambahkan ke tax harga
                taxHarga += tax;

                // Tambahkan ke tax harga
                totalHarga += total;

                // Opsional: Tambahkan ke ListBox untuk menampilkan daftar pesanan
                lstPesanan.Items.Add($"{namaMakanan} x{jumlah} @Rp{harga} = Rp{subtotal}");

                // Tampilkan sub total harga
                lblSubTotal.Text = "Sub Total: Rp " + subTotalHarga.ToString("N2");

                // Tampilkan total harga
                lblTax.Text = "Tax: Rp " + taxHarga.ToString("N2");

                // Tampilkan total harga
                lblTotal.Text = "Total: Rp " + totalHarga.ToString("N2");

                // Reset semua
                txtNamaMakanan.Clear();
                txtJumlah.Clear();
                txtHarga.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Terjadi kesalahan input. Pastikan semua data terisi dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event untuk tombol Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset semua input dan total harga
            txtNamaMakanan.Clear();
            txtJumlah.Clear();
            txtHarga.Clear();
            lblSubTotal.Text = "Sub Total: Rp 0";
            lblTax.Text = "Tax: Rp 0";
            lblSubTotal.Text = "Total: Rp 0";
            lblKembalian.Text = "Kembalian: Rp 0";
            lstPesanan.Items.Clear();
            txtBayar.Clear();
            subTotalHarga = 0;
            taxHarga = 0;
            totalHarga = 0;
            kembalianBayaran = 0;
        }

        // Event untuk tombol Keluar
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Tutup aplikasi
            this.Close();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil data dari TextBox
                int bayar = Convert.ToInt32(txtBayar.Text);

                // Hitung subtotal
                double kembalian = bayar - totalHarga;

                // Tambahkan ke sub total harga
                kembalianBayaran += kembalian;

                // Tampilkan total harga
                lblKembalian.Text = "Kembalian: Rp " + kembalianBayaran.ToString("N2");
            }
            catch (Exception)
            {
                MessageBox.Show("Terjadi kesalahan input. Pastikan semua data terisi dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Pastikan ada item dalam ListBox sebelum mencoba menghapus
            if (lstPesanan.Items.Count > 0)
            {
                // Hapus item terakhir
                lstPesanan.Items.RemoveAt(lstPesanan.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Tidak ada item untuk dihapus.");
            }
        }
    }
}
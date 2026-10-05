using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Method Penambahan
        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        // Method Pengurangan
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        // Method Perkalian
        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        // Method Pembagian
        private double Pembagian(int a, int b)
        {
            return (double)a / b;
        }

        // Event tombol Hitung
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click_1(object sender, EventArgs e)
        {
        
            try
            {
                int a = int.Parse(txtNilaiA.Text);
                int b = int.Parse(txtNilaiB.Text);

                switch (cmbOperasi.SelectedItem.ToString())
                {
                    case "Penambahan":
                        txtHasil.Text = Penambahan(a, b).ToString();
                        break;

                    case "Pengurangan":
                        txtHasil.Text = Pengurangan(a, b).ToString();
                        break;

                    case "Perkalian":
                        txtHasil.Text = Perkalian(a, b).ToString();
                        break;

                    case "Pembagian":
                        if (b == 0)
                        {
                            MessageBox.Show("Nilai B tidak boleh 0!");
                            txtHasil.Clear();
                        }
                        else
                        {
                            txtHasil.Text = Pembagian(a, b).ToString();
                        }
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nilai A dan Nilai B harus berupa angka!");
            }
        }
    }
}

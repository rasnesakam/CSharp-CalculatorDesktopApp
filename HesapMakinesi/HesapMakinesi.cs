using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class HesapMakinesi : Form
    {

        bool optDurum = false;
        double sonuc = 0;
        string opt = "";

        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void HesapMakinesi_Load(object sender, EventArgs e)
        {
         
        }

        private void btnBir_Click(object sender, EventArgs e)
        {
        }

        private void btnİki_Click(object sender, EventArgs e)
        {

        }

        private void btnUc_Click(object sender, EventArgs e)
        {

        }

        private void btnDort_Click(object sender, EventArgs e)
        {
        }

        private void btnBes_Click(object sender, EventArgs e)
        {
        }

        private void btnAlti_Click(object sender, EventArgs e)
        {
        }

        private void btnYedi_Click(object sender, EventArgs e)
        {
        }

        private void btnSekiz_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDokuz_Click(object sender, EventArgs e)
        {
        }

        private void btnSıfır_Click(object sender, EventArgs e)
        {

        }

        private void txtHesap_TextChanged(object sender, EventArgs e)
        {

        }

        private void SayiClick(object sender, EventArgs e)
        {
            if(txtHesap.Text == "0" || optDurum)
            {
                txtHesap.Clear();
            }
            optDurum = false;
            Button btn = (Button)sender;
            txtHesap.Text += btn.Text;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtHesap.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtHesap.Text = "0";
            txtSonuc.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false; 
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": 
                    txtHesap.Text = (sonuc + Double.Parse(txtHesap.Text)).ToString(); 
                    break;
                case "-": 
                    txtHesap.Text = (sonuc - Double.Parse(txtHesap.Text)).ToString(); 
                    break;
                case "x": 
                    txtHesap.Text = (sonuc * Double.Parse(txtHesap.Text)).ToString(); 
                    break;
                case "/": 
                    txtHesap.Text = (sonuc / Double.Parse(txtHesap.Text)).ToString(); 
                    break;
                case "√x": 
                    txtHesap.Text = (Math.Sqrt(sonuc)).ToString(); 
                    break;
                case "x²": 
                    txtHesap.Text = (sonuc * sonuc).ToString(); 
                    break;
                case "1/x": 
                    txtHesap.Text = (1 / sonuc).ToString(); 
                    break;
            }
            sonuc = Double.Parse(txtHesap.Text);
            txtHesap.Text = sonuc.ToString();
            opt = "";
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            
            if(txtHesap.Text == "0")
            {
                txtHesap.Text = "0";
            }
            else if (optDurum)
            {
                txtHesap.Text = "0";
            }

            if (!txtHesap.Text.Contains(","))
            {
                txtHesap.Text += ",";
            }
            optDurum = false;
        }

        private void ClickOperator(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            txtSonuc.Text = txtSonuc.Text + " " + yeniOpt + " " + txtHesap.Text;

            switch (opt)
            {
                case "+": txtHesap.Text = (sonuc + Double.Parse(txtHesap.Text)).ToString(); break;
                case "-": txtHesap.Text = (sonuc - Double.Parse(txtHesap.Text)).ToString(); break;
                case "x": txtHesap.Text = (sonuc * Double.Parse(txtHesap.Text)).ToString(); break;
                case "/": txtHesap.Text = (sonuc / Double.Parse(txtHesap.Text)).ToString(); break;
                case "√x": txtHesap.Text = (Math.Sqrt(sonuc)).ToString(); break;
                case "x²": txtHesap.Text = (sonuc * sonuc).ToString(); break;
                case "1/x": txtHesap.Text = (1 / sonuc).ToString(); break;
            }

            sonuc = Double.Parse(txtHesap.Text);
            txtHesap.Text = sonuc.ToString();
            opt = yeniOpt;
        }
    }
}

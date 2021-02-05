using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dörtislem
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecek;
        private int _ilkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecek)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecek = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void Rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecek)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecek = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void Rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecek)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecek = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void Rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecek)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecek = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void Rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecek)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecek = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void Rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecek)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecek = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void Rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecek)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecek = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void Rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecek)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecek = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void Rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecek)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecek = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void Rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecek)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecek = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void ToplamaButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecek = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void EsittirButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch(_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;

          

            }

            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void BolmeButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecek = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void CarpmaButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecek = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void CikarmaButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecek = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void TemizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}

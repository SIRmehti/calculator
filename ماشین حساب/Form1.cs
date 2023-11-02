using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ماشین_حساب
{
    public partial class Form1 : Form
    {
        string s1;
        string s2;
        char amalgar;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text == "0")
                lbl_result.Text = "1";
            else
            lbl_result.Text = lbl_result.Text + "1";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text == "0")
                lbl_result.Text = "3";
            else
                lbl_result.Text = lbl_result.Text + "3";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text == "0")
                lbl_result.Text = "2";
            else
                lbl_result.Text = lbl_result.Text + "2";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text == "0")
                lbl_result.Text = "4";
            else
                lbl_result.Text = lbl_result.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text == "0")
                lbl_result.Text = "5";
            else
                lbl_result.Text = lbl_result.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text == "0")
                lbl_result.Text = "6";
            else
                lbl_result.Text = lbl_result.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text == "0")
                lbl_result.Text = "7";
            else
                lbl_result.Text = lbl_result.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text == "0")
                lbl_result.Text = "8";
            else
                lbl_result.Text = lbl_result.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text == "0")
                lbl_result.Text = "9";
            else
                lbl_result.Text = lbl_result.Text + "9";
        }
private void btn_0_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text == "0")
                lbl_result.Text = "0";
            else
                lbl_result.Text = lbl_result.Text + "0";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            s1 = lbl_result.Text;
            lbl_result.Text = "0";
            amalgar = '+';
        }

        private void btn_mosavi_Click(object sender, EventArgs e)
        { 
            string s2 = lbl_result.Text;
            if(amalgar=='+')
            lbl_result.Text = (int.Parse(s1) + int.Parse(s2)).ToString();
            else if (amalgar == '-')
                lbl_result.Text = (int.Parse(s1) - int.Parse(s2)).ToString();
            else if (amalgar == '/')
                lbl_result.Text = (int.Parse(s1) / int.Parse(s2)).ToString();
            else if (amalgar == '*')
                lbl_result.Text = (int.Parse(s1) *int.Parse(s2)).ToString();
        }

        private void btn_menha_Click(object sender, EventArgs e)
        {
            s1 = lbl_result.Text;
            lbl_result.Text = "0";
            amalgar = '-';
        }

        private void btn_zarb_Click(object sender, EventArgs e)
        {
            s1 = lbl_result.Text;
            lbl_result.Text = "0";
            amalgar = '*';
        }

        private void btn_taghsim_Click(object sender, EventArgs e)
        {
            s1 = lbl_result.Text;
            lbl_result.Text = "0";
            amalgar = '/';
        }

        private void btn_celer_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bk_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text.Length != 0)
                lbl_result.Text = lbl_result.Text.Remove(lbl_result.Text.Length - 1);

        }
    }
}

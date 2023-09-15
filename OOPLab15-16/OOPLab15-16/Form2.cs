using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab15_16
{
    public partial class Form2 : Form
    {
        public Clock Theclock;
        public Form2(Clock s)
        {
            Theclock = s;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(Theclock != null)
            {
                textBox1.Text = Theclock.Brand;
                textBox2.Text = Theclock.Model;
                textBox3.Text = Theclock.TypeOfMechanism;
                textBox4.Text = Theclock.BodyMaterial;
                textBox5.Text = Theclock.TypeOfBracelet;
                textBox6.Text = Theclock.SizeInInches.ToString();
                textBox7.Text = Theclock.Price.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Theclock.Brand = textBox1.Text.Trim();
            Theclock.Model = textBox2.Text.Trim();
            Theclock.TypeOfMechanism = textBox3.Text.Trim();
            Theclock.BodyMaterial = textBox4.Text.Trim();
            Theclock.TypeOfBracelet = textBox5.Text.Trim();
            double d;
            if (double.TryParse(textBox6.Text.Trim(), out d))
            {
                Theclock.SizeInInches = d;
            }
            else
            {
                MessageBox.Show("Неправильно введено розмір", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
                return;
            }
            int p;
            if (int.TryParse(textBox7.Text.Trim(), out p))
            {
                Theclock.Price = p;
            }
           else
            {
                MessageBox.Show("Неправильно введено ціну", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox7.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

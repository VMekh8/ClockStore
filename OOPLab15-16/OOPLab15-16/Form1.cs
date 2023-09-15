using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOPLab15_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridClock.DataSource = bindSrcClock;
            GridClock.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Brand";
            column.HeaderText = "Бренд";
            GridClock.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.HeaderText = "Модель";
            GridClock.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TypeOfMechanism";
            column.HeaderText = "Тип механізму";
            GridClock.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "BodyMaterial";
            column.HeaderText = "Матеріал корпусу";
            GridClock.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TypeOfBracelet";
            column.HeaderText = "Вид браслету";
            GridClock.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SizeInInches";
            column.HeaderText = "Розмір";
            column.Width = 80;
            GridClock.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.HeaderText = "Ціна";
            column.Width = 80;
            GridClock.Columns.Add(column);


        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Прочитати дані у текстовому форматі";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bindSrcClock.Clear();
                sr = new StreamReader(openFileDialog1.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Clock clock = new Clock(split[0], split[1], split[2], split[3], split[4], double.Parse(split[5]), Int32.Parse(split[6]));
                        bindSrcClock.Add(clock);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
                tss1lFileName.Text = openFileDialog1.SafeFileName;
            }

        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (bindSrcClock.List.Count == 0) return;
            saveFileDialog1.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (Clock clock in bindSrcClock.List)
                    {
                        sw.WriteLine(clock.Brand + "\t" + clock.Model + "\t" + clock.TypeOfMechanism + "\t" + clock.BodyMaterial +
                            "\t" + clock.TypeOfBracelet + "\t" + clock.SizeInInches + "\t" + clock.Price);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuAdd_Click(object sender, EventArgs e)
        {
            Clock clock = new Clock();
            Form2 fs = new Form2(clock);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                bindSrcClock.Add(clock);
            }
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Назва програми: Магазин годинників\nВерсія: 1.0\nМех Віталій", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuEdit_Click(object sender, EventArgs e)
        {
            if (bindSrcClock.List.Count == 0) return;
            Clock clock = (Clock)bindSrcClock.List[bindSrcClock.Position];
            Form2 fs = new Form2(clock);
            if (fs.DialogResult == DialogResult.OK)
            {
                bindSrcClock.List[bindSrcClock.Position] = clock;
            }
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            if (bindSrcClock.List.Count == 0) return;
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcClock.RemoveCurrent();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clock clock = new Clock();
            Form2 fs = new Form2(clock);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                bindSrcClock.Add(clock);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bindSrcClock.List.Count == 0) return;
            Clock clock = (Clock)bindSrcClock.List[bindSrcClock.Position];
            Form2 fs = new Form2(clock);
            if (fs.DialogResult == DialogResult.OK)
            {
                bindSrcClock.List[bindSrcClock.Position] = clock;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bindSrcClock.List.Count == 0) return;
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcClock.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (bindSrcClock.List.Count == 0) return;
            if (MessageBox.Show("Очистити таблицю?\nВідновлення неможливе", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcClock.Clear();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Прочитати дані у текстовому форматі";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bindSrcClock.Clear();
                sr = new StreamReader(openFileDialog1.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Clock clock = new Clock(split[0], split[1], split[2], split[3], split[4], double.Parse(split[5]), Int32.Parse(split[6]));
                        bindSrcClock.Add(clock);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
                tss1lFileName.Text = openFileDialog1.SafeFileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bindSrcClock.List.Count == 0) return;
            saveFileDialog1.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (Clock clock in bindSrcClock.List)
                    {
                        sw.WriteLine(clock.Brand + "\t" + clock.Model + "\t" + clock.TypeOfMechanism + "\t" + clock.BodyMaterial +
                            "\t" + clock.TypeOfBracelet + "\t" + clock.SizeInInches + "\t" + clock.Price);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnCalculatePriceWithTax_Click(object sender, EventArgs e)
        {
            if (bindSrcClock.List.Count == 0) return;
            foreach (Clock c in bindSrcClock.List)
            {
                double p = c.CalculatePriceWithTax(textNameBrand.Text, textboxNameModel.Text);
                if (textNameBrand.Text == c.Brand && textboxNameModel.Text == c.Model)
                {

                    MessageBox.Show($"Ціна без податку: {c.Price}\nЦіна з податком: {p}",
                        "Обчислення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnChangeBracelet_Click(object sender, EventArgs e)
        {
            if (bindSrcClock.List.Count == 0) return;
            foreach (Clock c in bindSrcClock.List)
            {
                if (textNameBrand.Text == c.Brand && textboxNameModel.Text == c.Model)
                {
                    
                    c.ChangeBracelet(textboxChangeBracelet.Text);
                    GridClock.Refresh();
                    MessageBox.Show("Дані змінено!", "Оголошення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (bindSrcClock.List.Count == 0) return;
            foreach (Clock c in bindSrcClock.List)
            {
                if (textNameBrand.Text == c.Brand && textboxNameModel.Text == c.Model)
                {
                    string info = c.GetFullInfo();
                    MessageBox.Show(info, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       
    }
}


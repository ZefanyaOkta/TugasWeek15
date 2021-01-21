using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string [] DataMinuman = new string[50];
        public static string [] DataMakanan = new string[50];
        public static int counter1 = 0;
        public static int counter2 = 0;

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if (radioButtonMakanan.Checked == true)
            {
                if (textBoxNamaItem.Text != "" && (!listBoxItem.Items.Contains(textBoxNamaItem.Text.ToString())))
                {
                    listBoxItem.Items.Add(textBoxNamaItem.Text);
                    DataMakanan[counter1] = textBoxNamaItem.Text;
                    textBoxNamaItem.Text = "";
                    radioButtonMakanan.Checked = false;
                    counter1++;
                    labelKategori.Text = DataMakanan[counter1 - 1];
                }
                else if (listBoxItem.Items.Contains(textBoxNamaItem.Text.ToString()))
                {
                    MessageBox.Show("Data Sudah Ada");
                    textBoxNamaItem.Text = "";
                    radioButtonMakanan.Checked = false;
                }
                else
                {
                    MessageBox.Show("Lengkapi Data !");
                    textBoxNamaItem.Text = "";
                    radioButtonMakanan.Checked = false;
                }
            }
            else if (radioButtonMinuman.Checked == true)
            {
                if (textBoxNamaItem.Text != "" && (!listBoxItem.Items.Contains(textBoxNamaItem.Text.ToString())))
                {
                    listBoxItem.Items.Add(textBoxNamaItem.Text);
                    DataMinuman[counter2] = textBoxNamaItem.Text;
                    textBoxNamaItem.Text = "";
                    radioButtonMinuman.Checked = false;
                    counter2++;
                }
                else if (listBoxItem.Items.Contains(textBoxNamaItem.Text.ToString()))
                {
                    MessageBox.Show("Data Sudah Ada");
                    textBoxNamaItem.Text = "";
                    radioButtonMinuman.Checked = false;
                }
                else
                {
                    MessageBox.Show("Lengkapi Data !");
                    textBoxNamaItem.Text = "";
                    radioButtonMinuman.Checked = false;
                }
            }
            else if (radioButtonMinuman.Checked == false && radioButtonMakanan.Checked == false)
            {
                MessageBox.Show("Lengkapi Data !");
                textBoxNamaItem.Text = "";
                radioButtonMakanan.Checked = false;
                radioButtonMinuman.Checked = false;
            }
            textBoxNamaItem.Focus();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxItem.SelectedItems)
            {
                if (!listBoxItemCopy.Items.Contains(item))
                {
                    listBoxItemCopy.Items.Add(item);
                }
            }
            listBoxItem.ClearSelected();
            checkBoxMakanan.Checked = false;
            checkBoxMinuman.Checked = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxItemCopy.SelectedIndex == -1)
            {
                listBoxItemCopy.Items.Clear();
            }
            else
            {
                for (int i = listBoxItemCopy.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBoxItemCopy.Items.Remove(listBoxItemCopy.SelectedItems[i]);
                }
            }
        }

        private void checkBoxMakanan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMakanan.Checked == true)
            {
                listBoxItem.SelectedItem = "Mie Instan";
                listBoxItem.SelectedItem = "Telor";
                listBoxItem.SelectedItem = "Roti";
                listBoxItem.SelectedItem = "Keju";
                listBoxItem.SelectedItem = "Daging Giling";
                foreach (string item in DataMakanan)
                {
                    for (int i = 10; i <= listBoxItem.Items.Count ; i++)
                    {
                        if (listBoxItem.Items[i - 1].ToString() == item)
                        {
                            listBoxItem.SetSelected(i - 1, true);
                        }
                    }
                }
            }
            else if (checkBoxMakanan.Checked == false )
            {
                listBoxItem.ClearSelected();
            }
        }

        private void checkBoxMinuman_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMinuman.Checked == true)
            {
                listBoxItem.SelectedItem = "Susu Sapi";
                listBoxItem.SelectedItem = "Kopi";
                listBoxItem.SelectedItem = "Teh";
                listBoxItem.SelectedItem = "Bir";
                foreach (string item in DataMinuman)
                {
                    for (int i = 10; i <= listBoxItem.Items.Count; i++)
                    {
                        if (listBoxItem.Items[i - 1].ToString() == item)
                        {
                            listBoxItem.SetSelected(i - 1, true);
                        }
                    }
                }
            }
            else if (checkBoxMinuman.Checked == false)
            {
                listBoxItem.ClearSelected();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Yonatan_And_Yonatan_9.BL;

namespace WFA_Yonatan_And_Yonatan_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            
        }


        private void textBox7_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private bool IsEngLetter(char c)
        {
            if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
                return true;
            return false;
        }
        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private bool CheckForm()
        {
            bool flag = true;
            if (textBox_FirstName.Text.Length <2)
            {
                flag = false;
                textBox_FirstName.BackColor = Color.Red;
            }
            else
            {
                textBox_FirstName.BackColor = Color.White;
            }
            if (textBox13.Text.Length != 7)
            {
                flag = false;
                textBox13.BackColor = Color.Red;
            }
            else
            {
                textBox13.BackColor = Color.White;
            }
            return flag;
        }
        private void nudesbutton_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading |
                MessageBoxOptions.RightAlign);
            }
            else
            {
                Client client = FormToClient();
                MessageBox.Show("All Fields OK");
            }
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
        private Client FormToClient()
        {
            Client client = new Client();
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;

            //בדיקה האם יש ערך בשדה להמרה

            if (textBox13.Text != "")
                client.Id = int.Parse(textBox13.Text);
            client.PhoneNumber = int.Parse(textBox3.Text);
            client.firstnum = int.Parse(comboBox1.Text);
            return client;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}


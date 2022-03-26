using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        private bool customSet;
        internal bool customset;
        public int temprow;
        public int tempcol;
        public int tempmines;

        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void custom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Play(object sender, EventArgs e)
        {
            int row=0, col=0,mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
            Form3 f3 = null;
            if (easy.Checked)
            {
                row = col = 9;
                mines = 10;
                text = "Easy";
            }
            else if (medium.Checked)
            {
                row = col = 16;
                mines = 40;
                text = "Medium";
            }
            else if (expert.Checked)
            {
                row = 30;
                col = 16;
                mines = 99;
                text = "Expert";
            }
            else if (custom.Checked)
            {
                customSet = false;
                f3 = new Form3();
                f3.Owner = this;
                while (true)
                {
                    if (f3.ShowDialog() == DialogResult.Cancel)
                        break;
                    if (customSet)
                    {
                        row = temprow;
                        col = tempcol;
                        mines = tempmines;
                        text = "Custom: " + row + " by " + col + " & " + mines + " mines";
                        break;
                    }
                }
                
                //row = 25;
                //col = 20;
                //mines = 20;
                //text = "Custom";
            }
            else
                return;
            if (custom.Checked && !customSet)
                return;
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size,mines);
            f.Show();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count - 1;
            string myString = count.ToString();
            textbox2.Text = myString;
            //textbox2.Text = "Hello";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //String name = Console.ReadLine();
            //textBox1.Text = name;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to close all games?";
            const string caption = "Close";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                const string message = "Do you want to exit?";
                const string caption = "EXIT";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }

            }
        }
    }
}

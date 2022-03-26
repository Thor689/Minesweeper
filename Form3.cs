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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (row.Value * column.Value < 18)
                MessageBox.Show("Field is too small! You must have at leat 18 squares in the field.");
            else if (mine.Value > row.Value * column.Value / 2)
                MessageBox.Show("Too many mines! Half of the squares may have mines.");
            else
            {
                ((MainForm)this.Owner).customset = true;
                ((MainForm)this.Owner).temprow = (int)row.Value;
                ((MainForm)this.Owner).tempcol = (int)column.Value;
                ((MainForm)this.Owner).tempmines = (int)mine.Value;
                
            }
        }
    }
}

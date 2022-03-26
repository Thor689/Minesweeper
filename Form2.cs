using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MineSweeper
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
             
        }
        public Stopwatch Stopwatch { get; set; }
        public Form2(String text,int row, int col,int size,int mines) : this(){
            this.Text = text;
            field = new Field(row, col,mines);
            this.ClientSize = new Size(row * size, col * size);
            buttons = new Button[row][];
            for (int i = 0; i < row; i++)
                buttons[i] = new Button[col];
            foreach (int i in Enumerable.Range(0,row))
                foreach (int j in Enumerable.Range(0,col))
                {
                    buttons[i][j] = new Button();
                    buttons[i][j].Text = "";
                    buttons[i][j].BackColor = Color.White;
                    buttons[i][j].Name = i + "," + j;
                    buttons[i][j].Size = new Size(size, size);
                    buttons[i][j].Location = new Point(size * i, size * j + 30);
                    buttons[i][j].UseVisualStyleBackColor = false;
                    buttons[i][j].MouseUp += new MouseEventHandler(Button_Click);
                    this.Controls.Add(buttons[i][j]);
                }
        }
        private void Button_Click(object sender, MouseEventArgs e) {
            Stopwatch = new Stopwatch();
            Button b = (Button)sender;
            int temp = b.Name.IndexOf(",");
            int click_x = Int16.Parse(b.Name.Substring(0, temp));
            int click_y = Int16.Parse(b.Name.Substring(temp + 1));
            switch (e.Button)
            {
                case MouseButtons.Left:
                    // Left click
                    
                    if (!this.field.Started)
                        this.field.Initialize(click_x, click_y);
                    int n = this.field.CountMines(click_x, click_y);
                    if (this.field.IsMine(click_x, click_y))
                    {
                        b.BackColor = Color.Red;
                        MessageBox.Show("Game Over! You clicked on a mine!");
                        this.Close();
                        break;
                    }
                    if (this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    foreach (int k in this.field.GetSafeIsland(click_x, click_y))
                    {
                        int i = k / buttons[0].Length;
                        int j = k % buttons[0].Length;
                        buttons[i][j].BackColor = Color.LightGray;
                        int m = this.field.CountMines(i, j);
                        if (m > 0) {
                            buttons[i][j].Text = m + "";
                            buttons[i][j].BackColor = Color.LightBlue;
                        }else
                            buttons[i][j].Enabled = false;
                    }
                    if (field.Win())
                    {
                        MessageBox.Show("Congratulations! You discovered all safe squares!");
                        this.Close();
                    }
                        
                                      
                    break;
                case MouseButtons.Right:
                    // Right click
                    if (this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    if(field.Flagged.Contains(click_x * buttons[0].Length + click_y))
                    {
                        b.BackColor = Color.White;
                        field.Flagged.Remove(click_x * buttons[0].Length + click_y);
                    }
                    else
                    {
                        b.BackColor = Color.Green;
                        field.Flagged.Add(click_x * buttons[0].Length + click_y);
                    }  
                    break;
                case MouseButtons.Middle:
                    if (!this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    int Flagged_Count = 0;
                    foreach (int k in this.field.GetNeighbors(click_x, click_y))
                        if (field.Flagged.Contains(k))
                            Flagged_Count++;
                    if (this.field.CountMines(click_x, click_y) != Flagged_Count)
                        break;
                    foreach (int k in this.field.GetNeighbors(click_x, click_y))
                    {
                        if (field.Flagged.Contains(k) || field.Discovered.Contains(k))
                            continue;
                        if (this.field.IsMine(k / buttons[0].Length, k % buttons[0].Length))
                        {
                            b.BackColor = Color.Red;
                            MessageBox.Show("Game Over! You clicked on a mine!");
                            break;
                        }
                        foreach (int l in this.field.GetSafeIsland(k/ buttons[0].Length, k% buttons[0].Length))
                        {
                            int i = l / buttons[0].Length;
                            int j = l % buttons[0].Length;
                            buttons[i][j].BackColor = Color.LightGray;
                            int m = this.field.CountMines(i, j);
                            if (m > 0)
                            {
                                buttons[i][j].Text = m + "";
                                buttons[i][j].BackColor = Color.LightBlue;
                            }
                            else
                                buttons[i][j].Enabled = false;
                        }
                        if (field.Win())
                        {
                            MessageBox.Show("Congratulations! You discovered all safe squares!");
                            
                        }
                       
                    }
                    break;
            }
                

        }
        private Button[][] buttons;
        private Field field;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void closeAllGamesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void playOnANewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 9, col = 9, mines = 10;
            String text = "Easy";
            Form2 f = null;
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            f.Show();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 16, col = 16, mines = 40;
            String text = "Medium";
            Form2 f = null;
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            f.Show();
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 30, col = 16, mines = 99;
            String text = "Expert";
            Form2 f = null;
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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

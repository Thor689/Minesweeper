namespace MineSweeper
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.row = new System.Windows.Forms.NumericUpDown();
            this.mine = new System.Windows.Forms.NumericUpDown();
            this.column = new System.Windows.Forms.NumericUpDown();
            this.Rows = new System.Windows.Forms.Label();
            this.Columns = new System.Windows.Forms.Label();
            this.Mines = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.column)).BeginInit();
            this.SuspendLayout();
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(232, 103);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(120, 20);
            this.row.TabIndex = 0;
            // 
            // mine
            // 
            this.mine.Location = new System.Drawing.Point(232, 209);
            this.mine.Name = "mine";
            this.mine.Size = new System.Drawing.Size(120, 20);
            this.mine.TabIndex = 1;
            // 
            // column
            // 
            this.column.Location = new System.Drawing.Point(232, 155);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(120, 20);
            this.column.TabIndex = 2;
            // 
            // Rows
            // 
            this.Rows.AutoSize = true;
            this.Rows.Location = new System.Drawing.Point(162, 109);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(34, 13);
            this.Rows.TabIndex = 3;
            this.Rows.Text = "Rows";
            this.Rows.Click += new System.EventHandler(this.label1_Click);
            // 
            // Columns
            // 
            this.Columns.AutoSize = true;
            this.Columns.Location = new System.Drawing.Point(162, 155);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(47, 13);
            this.Columns.TabIndex = 4;
            this.Columns.Text = "Columns";
            // 
            // Mines
            // 
            this.Mines.AutoSize = true;
            this.Mines.Location = new System.Drawing.Point(162, 209);
            this.Mines.Name = "Mines";
            this.Mines.Size = new System.Drawing.Size(57, 13);
            this.Mines.TabIndex = 5;
            this.Mines.Text = "# of Mines";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(165, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(277, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(512, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mines);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.column);
            this.Controls.Add(this.mine);
            this.Controls.Add(this.row);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.column)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown row;
        private System.Windows.Forms.NumericUpDown mine;
        private System.Windows.Forms.NumericUpDown column;
        private System.Windows.Forms.Label Rows;
        private System.Windows.Forms.Label Columns;
        private System.Windows.Forms.Label Mines;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
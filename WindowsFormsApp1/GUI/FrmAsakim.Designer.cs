namespace WindowsFormsApp1.GUI
{
    partial class FrmAsakim
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtShem = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvAsakim = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsakim)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(600, 825);
            this.button4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(291, 98);
            this.button4.TabIndex = 15;
            this.button4.Text = "עדכן";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(600, 937);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 98);
            this.button3.TabIndex = 14;
            this.button3.Text = "צפייה";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(227, 825);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 98);
            this.button2.TabIndex = 13;
            this.button2.Text = "הוסף";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtShem
            // 
            this.txtShem.Location = new System.Drawing.Point(1560, 930);
            this.txtShem.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtShem.Name = "txtShem";
            this.txtShem.Size = new System.Drawing.Size(391, 38);
            this.txtShem.TabIndex = 11;
            this.txtShem.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(1560, 835);
            this.txtKod.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(391, 38);
            this.txtKod.TabIndex = 10;
            this.txtKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKod_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1232, 825);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "חיפוש לפי קוד";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAsakim
            // 
            this.dgvAsakim.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvAsakim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsakim.Location = new System.Drawing.Point(176, 29);
            this.dgvAsakim.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvAsakim.MultiSelect = false;
            this.dgvAsakim.Name = "dgvAsakim";
            this.dgvAsakim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAsakim.RowHeadersWidth = 102;
            this.dgvAsakim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsakim.Size = new System.Drawing.Size(1781, 746);
            this.dgvAsakim.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(227, 937);
            this.button5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(291, 98);
            this.button5.TabIndex = 16;
            this.button5.Text = "מחק";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1255, 933);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "חיפוש לפי שם עסק";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(56, 1053);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(315, 90);
            this.button6.TabIndex = 18;
            this.button6.Text = "סגירה";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FrmAsakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(2313, 1159);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtShem);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAsakim);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmAsakim";
            this.Text = "FrmAsakim";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsakim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtShem;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAsakim;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
    }
}
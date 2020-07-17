namespace WindowsFormsApp1.GUI
{
    partial class FrmChanuyot
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
            System.Windows.Forms.Button button5;
            this.dgvChanuyot = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chbMechir = new System.Windows.Forms.CheckBox();
            this.chbShetach = new System.Windows.Forms.CheckBox();
            this.chbMachsan = new System.Windows.Forms.CheckBox();
            this.chbSug = new System.Windows.Forms.CheckBox();
            this.txtMechir = new System.Windows.Forms.TextBox();
            this.txtShetach = new System.Windows.Forms.TextBox();
            this.cmbSug = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChanuyot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Teal;
            button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            button5.Location = new System.Drawing.Point(1901, 29);
            button5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(200, 55);
            button5.TabIndex = 5;
            button5.Text = "סינון";
            button5.UseVisualStyleBackColor = false;
            button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvChanuyot
            // 
            this.dgvChanuyot.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvChanuyot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChanuyot.Location = new System.Drawing.Point(32, 29);
            this.dgvChanuyot.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvChanuyot.MultiSelect = false;
            this.dgvChanuyot.Name = "dgvChanuyot";
            this.dgvChanuyot.RowHeadersWidth = 102;
            this.dgvChanuyot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChanuyot.Size = new System.Drawing.Size(1221, 816);
            this.dgvChanuyot.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(773, 858);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "חדש";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(525, 858);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "עדכון";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(275, 858);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "מחק";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(32, 858);
            this.button4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "צפייה";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chbMechir
            // 
            this.chbMechir.AutoSize = true;
            this.chbMechir.Location = new System.Drawing.Point(512, 21);
            this.chbMechir.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chbMechir.Name = "chbMechir";
            this.chbMechir.Size = new System.Drawing.Size(217, 36);
            this.chbMechir.TabIndex = 6;
            this.chbMechir.Text = "מחיר מקסימלי";
            this.chbMechir.UseVisualStyleBackColor = true;
            this.chbMechir.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbShetach
            // 
            this.chbShetach.AutoSize = true;
            this.chbShetach.Location = new System.Drawing.Point(512, 98);
            this.chbShetach.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chbShetach.Name = "chbShetach";
            this.chbShetach.Size = new System.Drawing.Size(199, 36);
            this.chbShetach.TabIndex = 7;
            this.chbShetach.Text = "שטח מינימלי";
            this.chbShetach.UseVisualStyleBackColor = true;
            this.chbShetach.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chbMachsan
            // 
            this.chbMachsan.AutoSize = true;
            this.chbMachsan.Location = new System.Drawing.Point(512, 174);
            this.chbMachsan.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chbMachsan.Name = "chbMachsan";
            this.chbMachsan.Size = new System.Drawing.Size(114, 36);
            this.chbMachsan.TabIndex = 8;
            this.chbMachsan.Text = "מחסן";
            this.chbMachsan.UseVisualStyleBackColor = true;
            // 
            // chbSug
            // 
            this.chbSug.AutoSize = true;
            this.chbSug.Location = new System.Drawing.Point(512, 258);
            this.chbSug.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chbSug.Name = "chbSug";
            this.chbSug.Size = new System.Drawing.Size(151, 36);
            this.chbSug.TabIndex = 9;
            this.chbSug.Text = "סוג חנות";
            this.chbSug.UseVisualStyleBackColor = true;
            this.chbSug.CheckedChanged += new System.EventHandler(this.chbSug_CheckedChanged);
            // 
            // txtMechir
            // 
            this.txtMechir.Location = new System.Drawing.Point(109, 17);
            this.txtMechir.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMechir.Name = "txtMechir";
            this.txtMechir.Size = new System.Drawing.Size(260, 38);
            this.txtMechir.TabIndex = 10;
            this.txtMechir.Visible = false;
            this.txtMechir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMechir_KeyPress);
            // 
            // txtShetach
            // 
            this.txtShetach.Location = new System.Drawing.Point(109, 93);
            this.txtShetach.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtShetach.Name = "txtShetach";
            this.txtShetach.Size = new System.Drawing.Size(260, 38);
            this.txtShetach.TabIndex = 11;
            this.txtShetach.Visible = false;
            this.txtShetach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShetach_KeyPress);
            // 
            // cmbSug
            // 
            this.cmbSug.FormattingEnabled = true;
            this.cmbSug.Items.AddRange(new object[] {
            "רגיל",
            "דוכן"});
            this.cmbSug.Location = new System.Drawing.Point(109, 258);
            this.cmbSug.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbSug.Name = "cmbSug";
            this.cmbSug.Size = new System.Drawing.Size(316, 39);
            this.cmbSug.TabIndex = 12;
            this.cmbSug.UseWaitCursor = true;
            this.cmbSug.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.chbMechir);
            this.groupBox1.Controls.Add(this.cmbSug);
            this.groupBox1.Controls.Add(this.txtMechir);
            this.groupBox1.Controls.Add(this.chbSug);
            this.groupBox1.Controls.Add(this.txtShetach);
            this.groupBox1.Controls.Add(this.chbMachsan);
            this.groupBox1.Controls.Add(this.chbShetach);
            this.groupBox1.Location = new System.Drawing.Point(1309, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(792, 436);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "ש\"ח";
            this.label1.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(16, 367);
            this.button6.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 55);
            this.button6.TabIndex = 13;
            this.button6.Text = "בצע חפוש";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Teal;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(1629, 29);
            this.button8.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(256, 55);
            this.button8.TabIndex = 15;
            this.button8.Text = "השכרה חדשה";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // FrmChanuyot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(2140, 963);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvChanuyot);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmChanuyot";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChanuyot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChanuyot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chbMechir;
        private System.Windows.Forms.CheckBox chbShetach;
        private System.Windows.Forms.CheckBox chbMachsan;
        private System.Windows.Forms.CheckBox chbSug;
        private System.Windows.Forms.TextBox txtMechir;
        private System.Windows.Forms.TextBox txtShetach;
        private System.Windows.Forms.ComboBox cmbSug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
    }
}
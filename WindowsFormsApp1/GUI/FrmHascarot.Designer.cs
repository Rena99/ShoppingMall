namespace WindowsFormsApp1.GUI
{
    partial class FrmHascarot
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
            this.dgvHascarot = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHascarot)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHascarot
            // 
            this.dgvHascarot.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvHascarot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHascarot.GridColor = System.Drawing.Color.Teal;
            this.dgvHascarot.Location = new System.Drawing.Point(75, 67);
            this.dgvHascarot.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvHascarot.MultiSelect = false;
            this.dgvHascarot.Name = "dgvHascarot";
            this.dgvHascarot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvHascarot.RowHeadersWidth = 102;
            this.dgvHascarot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHascarot.Size = new System.Drawing.Size(1264, 811);
            this.dgvHascarot.TabIndex = 0;
            // 
            // FrmHascarot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1406, 1061);
            this.Controls.Add(this.dgvHascarot);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmHascarot";
            this.Text = "FrmHascarot";
            this.Load += new System.EventHandler(this.FrmHascarot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHascarot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHascarot;
    }
}
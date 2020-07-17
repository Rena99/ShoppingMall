using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
namespace WindowsFormsApp1.GUI
{
    public partial class FrmChanuyot : Form
    {
        chanuyotTable chanuyot = new chanuyotTable();
        chanut chanut;
        DataView d;

        public FrmChanuyot()
        {
            InitializeComponent();
            d = new DataView(chanuyot.GetQuery());
            dgvChanuyot.DataSource = d;
            dgvChanuyot.RightToLeft=RightToLeft.Yes;
            dgvChanuyot.Columns[1].DefaultCellStyle.Format = "N0";
            dgvChanuyot.Columns[2].DefaultCellStyle.Format = "C2";
            dgvChanuyot.Columns[6].DefaultCellStyle.Format = "N0";
            SetHeaderColumn();
            disableButton();
        }

        private void SetHeaderColumn()
        {
            dgvChanuyot.Columns[0].HeaderText = "מס' חנות";
            dgvChanuyot.Columns[1].HeaderText = "גודל";
            dgvChanuyot.Columns[2].HeaderText = "מחיר השכרה חודשי";
            dgvChanuyot.Columns[3].HeaderText = "סוג חנות";
            dgvChanuyot.Columns[4].HeaderText = "קיים חלון ראווה";
            dgvChanuyot.Columns[5].HeaderText = "קיים מחסן";
            dgvChanuyot.Columns[6].HeaderText = "גודל מחסן";
            dgvChanuyot.Columns[7].HeaderText = "קומה";
            dgvChanuyot.Columns[8].HeaderText = "מס' אגף";
            dgvChanuyot.Columns[9].HeaderText = "מושכר";
            dgvChanuyot.Columns[10].HeaderText = "מס' פתחים לחנות";
        }
        private void disableButton()
        {
            if (dgvChanuyot.Rows.Count <= 1)
            {
                button8.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmchanut ff = new Frmchanut();
            ff.Show();
            ff.FormClosed += new FormClosedEventHandler(Ff_FormClosed);
        }

        private void Ff_FormClosed(object sender, FormClosedEventArgs e)
        {
            d = new DataView(chanuyot.GetQuery());
            dgvChanuyot.DataSource = d;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chanut = new chanut(Convert.ToInt32(dgvChanuyot.SelectedRows[0].Cells[0].Value));
            Frmchanut ff = new Frmchanut(chanut);
            ff.Show();
            ff.FormClosed += new FormClosedEventHandler(Ff_FormClosed);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string matzav = "SHOW";
            chanut = new chanut(Convert.ToInt32(dgvChanuyot.SelectedRows[0].Cells[0].Value));
            Frmchanut ff = new Frmchanut(matzav, chanut);
            ff.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chanut c = new chanut(Convert.ToInt32(dgvChanuyot.SelectedRows[0].Cells[0].Value));
            DataView dv = new DataView(new hascarotTable().GetDataTable());
            dv.RowFilter = "misChanut=" + c.MisChanut;
            if (dv.Count > 0)
                MessageBox.Show("לא ניתן למחוק כיוון שיש רשומות מקושרות");
            else
            {
                c.Delete();
                d = new DataView(chanuyot.GetQuery());
                dgvChanuyot.DataSource = d;
                disableButton();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMechir.Checked == true)
            {
                txtMechir.Text = "";
                txtMechir.Visible = true;
                label1.Visible = true;
            }
            else
            {
                txtMechir.Visible = false;
                label1.Visible = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShetach.Checked == true)
            {
                txtShetach.Text = "";
                txtShetach.Visible = true;
            }
            else
            {
                txtShetach.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            d = new DataView(chanuyot.GetQuery());
            dgvChanuyot.DataSource = d;
            string s = "";
            string a = "";
            if (chbMechir.Checked == true)
            {
                s = s + "mechirHascaraChodshi<=" + txtMechir.Text;
                a = " and ";
            }
            if (chbShetach.Checked == true)
            {
                s = s + a + "godel>=" + txtShetach.Text;
                a = " and ";
            }
            if (chbMachsan.Checked == true)
            {
                s = s + a + "kayamMachsan=true";
                a = " and ";
            }
            if (chbSug.Checked == true)
            {
                s = s + a + "sugChanut= '" + cmbSug.Text+"'";
            }
            if (s != "")
            {
                d.RowFilter = s; 
            }
        }

        private void chbSug_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSug.Checked == true)
            {
                cmbSug.Visible = true;
            }
            else
            {
                cmbSug.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chanut=new chanut(Convert.ToInt32(dgvChanuyot.SelectedRows[0].Cells[0].Value));
            FrmHascara ff = new FrmHascara(chanut);
            ff.Show();
            ff.FormClosed += new FormClosedEventHandler(Ff_FormClosed);
        }

        private void txtMechir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtShetach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

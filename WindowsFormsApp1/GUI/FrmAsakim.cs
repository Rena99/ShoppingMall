using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1.GUI
{
    public partial class FrmAsakim : Form
    {
        asakimTable asakim = new asakimTable();
        esek ee;
        DataView dv;
        public FrmAsakim()
        {
            InitializeComponent();
            dv = new DataView(asakim.GetQuery());
            dgvAsakim.DataSource = dv;
            SetHeaderColumn();
        }
        private void SetHeaderColumn()
        {
            dgvAsakim.Columns[0].HeaderText = "מס' עסק";
            dgvAsakim.Columns[1].HeaderText = "שם עסק";
            dgvAsakim.Columns[2].HeaderText = "שם איש קשר";
            dgvAsakim.Columns[3].HeaderText = "נייד";
            dgvAsakim.Columns[4].HeaderText = "קידומת";
            dgvAsakim.Columns[5].HeaderText = "מייל איש קשר";
            dgvAsakim.Columns[6].HeaderText = "כתובת";
            dgvAsakim.Columns[7].HeaderText = "שם עיר";
            dgvAsakim.Columns[8].HeaderText = "מייל עסק";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mazav = "SHOW";
            ee = new esek(Convert.ToInt32(dgvAsakim.SelectedRows[0].Cells[0].Value));
            FrmEsek f = new FrmEsek(mazav, ee);
            f.Show();
            f.FormClosed += new FormClosedEventHandler(Ff_FormClosed);
        }

        private void Ff_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvAsakim.DataSource = new DataView(asakim.GetQuery());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEsek ff = new FrmEsek();
            ff.Show();
            ff.FormClosed += new FormClosedEventHandler(Ff_FormClosed);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "shemEsek like'" + txtShem.Text + "*'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKod.Text == "")
            {
                dv = new DataView(asakim.GetQuery());
                dgvAsakim.DataSource = dv;
            }
            else
            {
                dv.RowFilter = "misEsek=" + txtKod.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ee = new esek(Convert.ToInt32(dgvAsakim.SelectedRows[0].Cells[0].Value));
            FrmEsek f = new FrmEsek(ee);
            f.Show();
            f.FormClosed += new FormClosedEventHandler(Ff_FormClosed);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            esek esek = new esek(Convert.ToInt32(dgvAsakim.SelectedRows[0].Cells[0].Value));
            DataView dv = new DataView(new hascarotTable().GetDataTable());
            dv.RowFilter = "misEsek =" + esek.MisEsek;
            if (dv.Count > 0)
                MessageBox.Show("לא ניתן למחוק כיוון שיש רשומות מקושרות");
            else
            {
                esek.Delete();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

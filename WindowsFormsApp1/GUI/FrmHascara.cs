using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1.GUI
{
    public partial class FrmHascara : Form
    {
        hascarotTable hascarot = new hascarotTable();
        hascara hascara;
        chanut ch;
        DataTable sh=new sherutimTable().GetDataTable();
        DataTable asakim = new asakimTable().GetDataTable();
        tashlumimLehascaraTable tashlumim = new tashlumimLehascaraTable();
        tashlumLehascara tashlum;
        sherutimBehascaraTable sherutim = new sherutimBehascaraTable();
        sherutBehascara sherut=new sherutBehascara();
        public void AvBenTash()
        {
            DataView dvTash = new DataView(new tashlumimLehascaraTable().GetDataTable());
            dgvTashlumim.DataSource = dvTash;
            dgvTashlumim.Visible = true;
            dvTash.RowFilter = "MisHascara=" + hascara.MisHascara;
            SetHeaderColumnTash();
        }

        public void AvBenSh()
        {
            DataView dvsh = new DataView(new sherutimBehascaraTable().GetPQuery());
            dvsh.RowFilter= "MisHascara=" + hascara.MisHascara;
            DataGridView dataGridView = new DataGridView();
            dataGridView.DataSource = dvsh;
            tabPage1.Controls.Add(dataGridView);
            dataGridView.RightToLeft = RightToLeft.Yes;
            dataGridView.BackgroundColor = Color.Snow;
            DataView temp = new DataView(new sherutimBehascaraTable().GetTQuery());
            temp.RowFilter = "MisHascara=" + hascara.MisHascara;
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.DataSource = temp;
            tabPage2.Controls.Add(dataGridView1);
            tabControl1.Visible = true;
            dataGridView.Columns[0].HeaderText = "מס' פירוט שרות בהשכרה";
            dataGridView.Columns[1].HeaderText = "מס' שרות";
            dataGridView.Columns[2].HeaderText = "שם שרות";
            dataGridView.Columns[3].HeaderText = "מחיר חודשי";
            dataGridView.Columns[2].DefaultCellStyle.Format = "C2";
            dataGridView.Columns[4].HeaderText = "מס' השכרה";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.Columns[0].HeaderText = "מס' פירוט שרות בהשכרה";
            dataGridView1.Columns[1].HeaderText = "מס' שרות";
            dataGridView1.Columns[2].HeaderText = "שם שרות";
            dataGridView1.Columns[3].HeaderText = "מחיר חודשי";
            dataGridView1.Columns[2].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns[4].HeaderText = "מס' השכרה";
        }

        public FrmHascara(chanut ch)
        {
            InitializeComponent();
            MiluyCombo();
            hascara = new hascara();
            this.ch = ch;
        }

        public void MiluyCombo()
        {
            cmbMisEsek.DataSource = new asakimTable().GetDataTable();
            cmbMisEsek.DisplayMember = "shemEsek";
            cmbMisEsek.ValueMember = "misEsek";
            checkedListBox1.DataSource = new sherutimTable().GetDataTable();
            checkedListBox1.DisplayMember = "shemSherut";
            checkedListBox1.ValueMember = "misSherut";
            dtpTokef.Format = DateTimePickerFormat.Custom;
            dtpTokef.CustomFormat = "MM/yyyy";
            dtpKnisa.Format = DateTimePickerFormat.Short;
        }

        private void FrmHascara_Load(object sender, EventArgs e)
        {
            lblMisHascara.Text = hascarot.GetNewKey().ToString();
            lblTaarichBakasha.Text = DateTime.Today.ToShortDateString();
            lblMisChanut.Text = ch.MisChanut.ToString();
            lblMechir.Text = ch.MechirHascaraChodshi.ToString()+" " + "ש\"ח";
            AvBenTash();
            dgvTashlumim.Visible = false;
            tabControl1.Visible = false;
        }

        private void cmbOfen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOfen.Text == "אשראי")
            {
                grbAshray.Visible = true;
                grbHoraat.Visible = false;
            }
            else
            {
                grbHoraat.Visible = true;
                grbAshray.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool degel = true;
            errorProvider1.Clear();
            hascara.MisHascara = Convert.ToInt32(lblMisHascara.Text);
            hascara.TaarichBakashatHascara = Convert.ToDateTime(lblTaarichBakasha.Text);
            hascara.MisChanut = Convert.ToInt32(lblMisChanut.Text);
            try
            {
                hascara.MisEsek = Convert.ToInt32(asakim.AsDataView()[cmbMisEsek.SelectedIndex].Row.ItemArray[0]);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbMisEsek, ex.Message);
                degel = false;
            }
            try
            {
                hascara.MeshechZmanHachoze = Convert.ToInt32(nudZmanChoze.Value);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(nudZmanChoze, ex.Message);
                degel = false;
            }
            try
            {
                hascara.OptzyaLehaaracha = chbhaaracha.Checked;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(chbhaaracha, ex.Message);
                degel = false;
            }
            hascara.OfenTashlum = cmbOfen.Text;
            try
            {
                hascara.TaarichKnisa = Convert.ToDateTime(dtpKnisa.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpKnisa, ex.Message);
                degel = false;
            }
            hascara.SherutimMeyuchadim = chbsherut.Checked;
            if (cmbOfen.Text == "אשראי")
            {
                try
                {
                    hascara.MisAshray = txtMisAshray.Text;
                    if (hascara.MisAshray.Length != 16)
                    {
                        throw new Exception("not valid cc number");
                    }
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtMisAshray, ex.Message);
                    degel = false;
                }
                try
                {
                    hascara.Tokef = Convert.ToDateTime(dtpTokef.Text);
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(dtpTokef, ex.Message);
                    degel = false;
                }
                try
                {
                    hascara.Cvv = Convert.ToInt32(txtCvv.Text);
                    if (hascara.Cvv.ToString().Length<3)
                    {
                        throw new Exception("not valid cvv number");
                    }
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtCvv, ex.Message);
                    degel = false;
                }
            }
            else
            {
                try
                {
                    hascara.MisAsmachta = txtMisAsmachta.Text;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtMisAsmachta, ex.Message);
                    degel = false;

                }
                try
                {
                    hascara.MisBank = Convert.ToInt32(txtMisBank.Text);
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtMisBank, ex.Message);
                    degel = false;
                }
                try
                {
                    hascara.MisSnif = Convert.ToInt32(txtMisSnif.Text);
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtMisSnif, ex.Message);
                    degel = false;
                }
                try
                {
                    hascara.MisCheshbon = Convert.ToInt32(txtMisCheshbon.Text);
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtMisCheshbon, ex.Message);
                    degel = false;
                }

            }

            if (degel)
            {
                try
                {
                    hascara.Add();
                    PtichatTashlumim();
                    if (chbsherut.Checked)
                    {
                        PtichatSherutim();
                    }
                    AvBenTash();
                    AvBenSh();
                    UpdateChanut();
                    button1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("קרתה שגיאה בהוספה" + ex.Message);

                }
            }

        }

        private void UpdateChanut()
        {                  
            ch.Status = true;
            ch.Update();
        }

        public void PtichatTashlumim()
        {
            int chodesh, shana,sherutPrice=0, oneTimePrice=0;
            chodesh = dtpKnisa.Value.Month;
            shana = dtpKnisa.Value.Year;
            if (chbsherut.Checked == true)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        DataRow Drow = new sherutimTable().Find(Convert.ToInt32(sh.AsDataView()[i].Row.ItemArray[0]));
                        if(Drow["sugSherut"].ToString()=="קבוע")
                            sherutPrice += Convert.ToInt32(Drow["mechirChodshi"]);
                        else
                        {
                            oneTimePrice += Convert.ToInt32(Drow["mechirChodshi"]);
                        }
                    }
                }
            }
            for (int i = 0; i < hascara.MeshechZmanHachoze; i++)
            {
                tashlum = new tashlumLehascara();
                tashlum.MisTashlum = tashlumim.GetNewKey();
                tashlum.MisHascara = hascara.MisHascara;
                tashlum.SachTashlumChodshi = ch.MechirHascaraChodshi+sherutPrice;
                if (i == 0)
                {
                    tashlum.SachTashlumChodshi += oneTimePrice;
                }
                tashlum.Chodesh = chodesh;
                tashlum.Shana = shana;
                chodesh = chodesh + 1;
                if (chodesh == 12)
                {
                    chodesh = 1;
                    shana = shana + 1;
                }
                tashlum.Add();
            }
        }
        public void PtichatSherutim()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    sherut.MisPerutSherutBehascara = sherutim.GetNewKey();
                    sherut.MisHascara = hascara.MisHascara;
                    sherut.MisSherut = Convert.ToInt32(sh.AsDataView()[i].Row.ItemArray[0]);
                    sherut.Chodesh = dtpKnisa.Value.Month;
                    sherut.Shana = dtpKnisa.Value.Year;
                    sherut.Add();
                }
            }
        }

        private void chbsherut_CheckedChanged(object sender, EventArgs e)
        {
            if (chbsherut.Checked)
            {
                checkedListBox1.Visible = true;
            }
            else
            {
                checkedListBox1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAsakim ff = new FrmAsakim();
            ff.Show();
            ff.FormClosed += new FormClosedEventHandler(Ff_FormClosed);
        }
        private void Ff_FormClosed(object sender, FormClosedEventArgs e)
        {
            cmbMisEsek.DataSource = new asakimTable().GetDataTable();
            cmbMisEsek.DisplayMember = "shemEsek";
            cmbMisEsek.ValueMember = "misEsek";
        }

        private void txtMisAshray_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void txtCvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void txtMisAsmachta_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void txtMisBank_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void txtMisSnif_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void txtMisCheshbon_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void CheckInput(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void SetHeaderColumnTash()
        {
            dgvTashlumim.Columns[0].HeaderText = "מס' תשלומים";
            dgvTashlumim.Columns[1].HeaderText = "מס' השכרה";
            dgvTashlumim.Columns[2].HeaderText = "סך תשלום";
            dgvTashlumim.Columns[2].DefaultCellStyle.Format = "C2";
            dgvTashlumim.Columns[3].HeaderText = "חודש";
            dgvTashlumim.Columns[4].HeaderText = "שנה";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
namespace WindowsFormsApp1.GUI
{

    public partial class Frmchanut : Form
    {
        chanuyotTable chanuyot = new chanuyotTable();
        chanut ch;
        string status;
        public Frmchanut()
        {
            InitializeComponent();
            ch = new chanut();
            status = "NEW";
            lblMisChanut.Text = chanuyot.GetNewKey().ToString();
            chbStatus.Enabled = false;
        }
        public Frmchanut(chanut chanut)
        {
            InitializeComponent();
            ch = chanut;
            status = "UPDATE";
            lblMisChanut.Text = chanut.MisChanut.ToString();
            txtGodel.Text = chanut.Godel.ToString();
            txtMechirHascara.Text = chanut.MechirHascaraChodshi.ToString();
            txtSugChanut.Text = chanut.SugChanut;
            chbKayamChalon.Checked = chanut.KayamChalonRaava;
            chbKayamMachsan.Checked = chanut.KayamMachsan;
            txtGodelMachsan.Text = chanut.GodelMachsan.ToString();
            txtKoma.Text = chanut.Koma.ToString();
            txtMisAgaf.Text = chanut.MisAgaf.ToString();
            chbStatus.Checked = chanut.Status;
            txtMisPtachim.Text = chanut.MisPtachimLechanut.ToString();
        }
        public Frmchanut(string bb, chanut chanut)
        {
            InitializeComponent();
            ch = chanut;
            status = bb;
            lblMisChanut.Text = chanut.MisChanut.ToString();
            txtGodel.Text = chanut.Godel.ToString();
            txtMechirHascara.Text = chanut.MechirHascaraChodshi.ToString();
            txtSugChanut.Text = chanut.SugChanut;
            chbKayamChalon.Checked = chanut.KayamChalonRaava;
            chbKayamMachsan.Checked = chanut.KayamMachsan;
            txtGodelMachsan.Text = chanut.GodelMachsan.ToString();
            txtKoma.Text = chanut.Koma.ToString();
            txtMisAgaf.Text = chanut.MisAgaf.ToString();
            chbStatus.Checked = chanut.Status;
            txtMisPtachim.Text = chanut.MisPtachimLechanut.ToString();
            groupBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool degel = true;
            errorProvider1.Clear();
            ch.MisChanut = Convert.ToInt32(lblMisChanut.Text);
            try
            {
                ch.Godel = Convert.ToInt32(txtGodel.Text);
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtGodel, ex.Message);
                degel = false;
            }
            try
            {
                ch.MechirHascaraChodshi = Convert.ToInt32(txtMechirHascara.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMechirHascara, ex.Message);
                degel = false;
            }
            try
            {
                ch.SugChanut = txtSugChanut.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSugChanut, ex.Message);
                degel = false;
            }
            try
            {
                ch.KayamChalonRaava = chbKayamChalon.Checked;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(chbKayamChalon, ex.Message);
                degel = false;
            }
            try
            {
                ch.KayamMachsan = chbKayamMachsan.Checked;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(chbKayamMachsan, ex.Message);
                degel = false;
            }
            if (ch.KayamMachsan)
            {
                try
                {
                    ch.GodelMachsan = Convert.ToInt32(txtGodelMachsan.Text);
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtGodelMachsan, ex.Message);
                    degel = false;
                }
            }
            else
                ch.GodelMachsan = 0;
            try
            {
                ch.Koma = Convert.ToInt32(txtKoma.Text);
                if (ch.Koma > 4||ch.Koma<0)
                {
                    throw new Exception("must be between 0 and 4");
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKoma, ex.Message);
                degel = false;
            }
            try
            {
                ch.MisAgaf = Convert.ToInt32(txtMisAgaf.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMisAgaf, ex.Message);
                degel = false;
            }
            try
            {
                ch.Status = chbStatus.Checked;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(chbStatus, ex.Message);
                degel = false;
            }
            try
            {
                ch.MisPtachimLechanut = Convert.ToInt32(txtMisPtachim.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMisPtachim, ex.Message);
                degel = false;
            }
            if (degel)
            {
                if (status == "NEW")
                {
                    try
                    {
                        ch.Add();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("קרתה שגיאה בהוספה" + ex.Message);
                    }
                }
                if (status == "UPDATE")
                {
                    try
                    {
                        ch.Update();
                        Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("קרתה שגיאה בעדכון" + ex.Message);
                    }
                }
                if (status == "SHOW")
                {
                    Close();
                }
            }
        }

        private void txtGodel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMechirHascara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSugChanut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGodelMachsan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKoma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMisAgaf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMisPtachim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chbKayamMachsan_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbKayamMachsan.Checked)
            {
                label7.Visible = true;
                txtGodelMachsan.Visible = true;
                txtGodelMachsan.Text = "";
            }
            else
            {
                label7.Visible = false;
                txtGodelMachsan.Visible = false;
            }
        }
    }
}

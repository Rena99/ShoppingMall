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
    public partial class FrmHascarot : Form
    {
        hascarotTable hascarot = new hascarotTable();
        hascara hascara1 = new hascara();
        public FrmHascarot()
        {
            InitializeComponent();
        }

        private void FrmHascarot_Load(object sender, EventArgs e)
        {
            dgvHascarot.DataSource = hascarot.GetQuery();
            SetHeaderColumn();
        }
        private void SetHeaderColumn()
        {
            dgvHascarot.Columns[0].HeaderText = "מס' השכרה";
            dgvHascarot.Columns[1].HeaderText = "תאריך בקשה";
            dgvHascarot.Columns[2].HeaderText = "מס' חנות";
            dgvHascarot.Columns[3].HeaderText = "שם עסק";
            dgvHascarot.Columns[4].HeaderText = "תאריך כניסה";
            dgvHascarot.Columns[5].HeaderText = "משך זמן";
            dgvHascarot.Columns[6].HeaderText = "אופציה להארכה";
            dgvHascarot.Columns[7].HeaderText = "סוג תשלום";
            dgvHascarot.Columns[8].HeaderText = "מס' אשראי";
            dgvHascarot.Columns[9].HeaderText = "תוקף";
            dgvHascarot.Columns[10].HeaderText = "cvv";
            dgvHascarot.Columns[11].HeaderText = "מס' אסמכתא";
            dgvHascarot.Columns[12].HeaderText = "מס' בנק";
            dgvHascarot.Columns[13].HeaderText = "מס' סניף";
            dgvHascarot.Columns[14].HeaderText = "מס' חשבון";
            dgvHascarot.Columns[15].HeaderText = "שרותים מיוחדים";
            dgvHascarot.Columns[9].DefaultCellStyle.Format = "MM/yyyy";
            for (int i = 0; i < dgvHascarot.Rows.Count-1; i++) {
                if (dgvHascarot.Rows[i].Cells[7].Value.ToString() == "אשראי")
                {
                    dgvHascarot.Rows[i].Cells[11].ValueType = Type.GetType("string");
                    dgvHascarot.Rows[i].Cells[11].Value = DBNull.Value;
                    dgvHascarot.Rows[i].Cells[12].ValueType = Type.GetType("string");
                    dgvHascarot.Rows[i].Cells[12].Value = DBNull.Value;
                    dgvHascarot.Rows[i].Cells[13].ValueType = Type.GetType("string");
                    dgvHascarot.Rows[i].Cells[13].Value = DBNull.Value;
                    dgvHascarot.Rows[i].Cells[14].ValueType = Type.GetType("string");
                    dgvHascarot.Rows[i].Cells[14].Value = DBNull.Value;
                }
                else
                {
                    dgvHascarot.Rows[i].Cells[8].ValueType = Type.GetType("string");
                    dgvHascarot.Rows[i].Cells[8].Value = DBNull.Value;
                    dgvHascarot.Rows[i].Cells[9].ValueType = Type.GetType("string");
                    dgvHascarot.Rows[i].Cells[9].Value = DBNull.Value;
                    dgvHascarot.Rows[i].Cells[10].ValueType = Type.GetType("string");
                    dgvHascarot.Rows[i].Cells[10].Value = DBNull.Value;
                }
            }
        }

    }
}

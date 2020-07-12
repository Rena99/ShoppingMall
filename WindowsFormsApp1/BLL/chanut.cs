using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class chanut
    {
        chanuyotTale myT = new chanuyotTale();

        public int MisChanut { get; set; }

        public double Godel { get; set; }

        public int MechirHascaraChodshi { get; set; }

        public string SugChanut { get; set; }

        public bool KayamChalonRaava { get; set; }

        public bool KayamMachsan { get; set; }

        public double GodelMachsan { get; set; }

        public int Koma { get; set; }

        public int MisAgaf { get; set; }

        public bool Status { get; set; }

        public int MisPtachimLechanut { get; set; }
        public DataRow Drow { get; set; }
        public chanut()
        {

        }
        public chanut(int misChanut)
        {
           Drow= myT.Find(misChanut);
            FillFields();
        }
        public void FillDrow()
        {
            Drow["misChanut"] = MisChanut;
            Drow["godel"] = Godel;
            Drow["mechirHascaraChodshi"] = MechirHascaraChodshi;
            Drow["sugChanut"] = SugChanut;
            Drow["kayamChalonRaava"] = KayamChalonRaava;
            Drow["kayamMachsan"] = KayamMachsan;
            Drow["godelMachsan"] = GodelMachsan;
            Drow["koma"] = Koma;
            Drow["misAgaf"] = MisAgaf;
            Drow["status"] = Status;
            Drow["misPtachimLechanut"] = MisPtachimLechanut;
        }
        public void FillFields()
        {
            MisChanut = Convert.ToInt32(Drow["misChanut"]);
            Godel = Convert.ToDouble(Drow["godel"]);
            MechirHascaraChodshi =Convert.ToInt32 (Drow["mechirHascaraChodshi"]);
            SugChanut = Drow["sugChanut"].ToString();
            KayamChalonRaava = Convert.ToBoolean(Drow["kayamChalonRaava"]);
            KayamMachsan = Convert.ToBoolean(Drow["kayamMachsan"]);
            GodelMachsan = Convert.ToDouble(Drow["godelMachsan"]);
            Koma = Convert.ToInt32(Drow["koma"]);
            MisAgaf = Convert.ToInt32(Drow["misAgaf"]);
            Status = Convert.ToBoolean(Drow["status"]);
            MisPtachimLechanut = Convert.ToInt32(Drow["misPtachimLechanut"]);
        }
        public void Add()// חדש הוספת רשומה חדשה
        {
            Drow = myT.GetDataTable().NewRow();
            FillDrow();
            myT.GetDataTable().Rows.Add(Drow);
            myT.Save();
        }
        public void Update()
        {
            FillDrow();
            myT.Save();
        }
        public void Delete()
        {
            Drow.Delete();
            myT.Save();
        }





    }
}

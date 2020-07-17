using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
   public class tashlumLehascara
    {
        tashlumimLehascaraTable myT = new tashlumimLehascaraTable();

        public int MisTashlum { get; set; }

        public int MisHascara { get; set; }

        public int SachTashlumChodshi { get; set; }

        public int Chodesh { get; set; }

        public int Shana { get; set; }

        public DataRow Drow { get; set; }
        public tashlumLehascara()
        {

        }
        public tashlumLehascara(int misTashlum)
        {
           Drow= myT.Find(misTashlum);
            FillFields();
        }
        public void FillDrow()
        {
            Drow["misTashlum"] = MisTashlum;
            Drow["misHascara"] = MisHascara;
            Drow["sachTashlumChodshi"] = SachTashlumChodshi;
            Drow["chodesh"] = Chodesh;
            Drow["shana"] = Shana;
        }
        public void FillFields()
        {
            MisTashlum = Convert.ToInt32(Drow["misTashlum"]);
            MisHascara = Convert.ToInt32(Drow["misHascara"]);
            SachTashlumChodshi = Convert.ToInt32(Drow["sachTashlumChodshi"]);
            Chodesh=Convert.ToInt32(Drow["chodesh"]);
            Shana = Convert.ToInt32(Drow["shana"]);
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

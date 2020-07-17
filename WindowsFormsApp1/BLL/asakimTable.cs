using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
   public class asakimTable:GeneralTable
    {
        public asakimTable():base("asakim","misEsek")
        {

        }
        public DataTable GetQuery()
        {
            return dal.GetQuery("SELECT asakim.misEsek, asakim.shemEsek, asakim.shemIshKesher, asakim.nayadIshKesher, asakim.kidomet, asakim.mailIshKesher, asakim.ctovetMisrad, arim.shemIr, asakim.mailEsek FROM arim INNER JOIN asakim ON arim.kodIr = asakim.KodIr;");
        }
    }
}

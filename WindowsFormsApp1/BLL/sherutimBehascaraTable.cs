using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
   public class sherutimBehascaraTable:GeneralTable
    {
        public sherutimBehascaraTable():base("sherutimBehascara", "misPerutSherutBehascara")
        {

        }
        public DataTable GetPQuery()
        {
           return dal.GetQuery("SELECT sherutimBehascara.misPerutSherutBehascara, sherutimBehascara.misSherut, sherutim.shemSherut, sherutim.mechirChodshi, sherutimBehascara.misHascara FROM sherutim INNER JOIN sherutimBehascara ON sherutim.misSherut = sherutimBehascara.misSherut WHERE(((sherutim.sugSherut) = 'קבוע'))");
        }
        public DataTable GetTQuery()
        {
            return dal.GetQuery("SELECT sherutimBehascara.misPerutSherutBehascara, sherutimBehascara.misSherut, sherutim.shemSherut, sherutim.mechirChodshi, sherutimBehascara.misHascara FROM sherutim INNER JOIN sherutimBehascara ON sherutim.misSherut = sherutimBehascara.misSherut WHERE(((sherutim.sugSherut) = 'חד פעמי'))");
        }
    }
}

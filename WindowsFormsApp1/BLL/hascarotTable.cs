using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
   public class hascarotTable:GeneralTable
    {
        public hascarotTable():base("hascarot", "misHascara")
        {

        }
        public DataTable GetQuery()
        {
            return dal.GetQuery("SELECT hascarot.misHascara, hascarot.taarichBakashatHascara, hascarot.misChanut, asakim.shemEsek, hascarot.taarichKnisa, hascarot.meshechZmanHachoze, hascarot.optzyaLehaaracha, hascarot.ofenTashlum, hascarot.misAshray, hascarot.tokef, hascarot.cvv, hascarot.misAsmachta, hascarot.misBank, hascarot.misSnif, hascarot.misCheshbon, hascarot.sherutimMeyuchadim FROM asakim INNER JOIN hascarot ON asakim.misEsek = hascarot.misEsek;");
        }
    }
}

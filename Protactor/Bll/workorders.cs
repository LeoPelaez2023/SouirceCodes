using Dapper;
using Protractor.Models;
using Protractor.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protractor.Bll
{
    partial class workorders
    {
        public List<cWorkOrder> allRecords(cWorkOrder _workorder, string SrchStr)
        {
            RepList<cWorkOrder> lista = new RepList<cWorkOrder>();
            DynamicParameters param = new DynamicParameters();
            param.Add("searchStr", SrchStr, DbType.String);
            return lista.returnListClass("GetWO", param);

        }
    }
}

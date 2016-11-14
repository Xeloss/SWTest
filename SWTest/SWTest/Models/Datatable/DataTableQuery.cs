using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWTest.Models.Datatable
{
    public class DataTableQuery
    {
        public int sEcho { get; set; }

        public int iDisplayStart { get; set; }
        public int iDisplayLength { get; set; }

        public string sSearch { get; set; }
    }
}
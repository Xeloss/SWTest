using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWTest.Models.Datatable
{
    public class DataTableResponse<TData> where TData : class
    {
        public DataTableResponse(IEnumerable<TData> data, int totalCount, int filteredCount)
        {
            this.aaData = data;
            this.iTotalRecords = totalCount;
            this.iTotalDisplayRecords = filteredCount;
        }

        public IEnumerable<TData> aaData { get; set; }

        public int iTotalRecords { get; set; }
        public int iTotalDisplayRecords { get; set; }
    }
}
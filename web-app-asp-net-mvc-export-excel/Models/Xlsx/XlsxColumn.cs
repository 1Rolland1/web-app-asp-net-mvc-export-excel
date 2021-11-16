using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_app_asp_net_mvc_export_excel.Models.Xlsx
{
    public class XlsxColumn
    {
        public string DisplayName { get; set; }
        public Type ColumnType { get; set; }
        public int? Order { get; set; }
    }
}
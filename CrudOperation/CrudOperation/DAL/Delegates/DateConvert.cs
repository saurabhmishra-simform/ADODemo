using CrudOperation.PLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.DAL.Querys
{
    public delegate string DateConvertDelegate(string date);
    public static class DateConvert
    {
        public static string DateConvertSQLFormate(string date)
        {
            return string.Format("{0:MM/dd/yyyy}", date);
        }
    }
}

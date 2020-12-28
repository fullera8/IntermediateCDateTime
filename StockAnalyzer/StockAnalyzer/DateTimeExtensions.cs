using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzer
{
    public static class DateTimeExtensions
    {
        public static DateTimeOffset ExtendContract(this DateTimeOffset contractDate, int months)
        {
            var newContractDate = contractDate.AddMonths(months).AddTicks(-1);

            return new DateTimeOffset
                (
                    newContractDate.Year, 
                    newContractDate.Month, 
                    DateTime.DaysInMonth(newContractDate.Year, newContractDate.Month), 
                    23, 
                    59, 
                    59, 
                    contractDate.Offset
                );
        }
    }
}

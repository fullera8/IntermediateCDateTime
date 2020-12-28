using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            ////loop through the dates and demonstrate how the date can be read in british format DD/MM/YYYY
            //var lines = File.ReadAllLines(@"StockData.csv");

            ////
            //foreach (var line in lines.Skip(1))
            //{
            //    var segment = line.Split(',');
            //    var TradeDate = DateTime.Parse(segment[1], CultureInfo.GetCultureInfo("en-GB"));

            //    Console.WriteLine(TradeDate.ToLongDateString());
            //}

            //Get the sydney timezone for current time
            //var now = DateTime.Now;
            //var sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

            //var sydneyTime = TimeZoneInfo.ConvertTime(now, sydneyTimeZone);

            //Console.WriteLine(now);
            //Console.WriteLine(sydneyTime);

            //Working with datetime and DateTimeOffset (timespans), gives all zones in the same timezone
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTimeOffset.Now);
            //var time = DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(10));

            //foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
            //{
            //    if (timeZone.GetUtcOffset(time) == time.Offset)
            //    {
            //        Console.WriteLine(timeZone);
            //    }
            //}

            //Simple DateTime
            //var date = "9/10/2020 10:00:00 PM";
            //var parseDate = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            //var date = "2019-07-01 10:00:00 PM +02:00";
            //var parseDate = DateTime.Parse(date, CultureInfo.InvariantCulture,DateTimeStyles.AdjustToUniversal);

            //Console.WriteLine(parseDate);

            //Formatting Dates for ISO 8601
            //var date = "9/10/2020 10:00:00 PM";
            //var parseDate = DateTimeOffset.ParseExact(date, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            //parseDate = parseDate.ToOffset(TimeSpan.FromHours(10));

            //var formattedDate = parseDate.ToString("o");
            //Console.WriteLine(formattedDate);

            //Converting between UTC and back
            //var utcNow = DateTimeOffset.Now.ToUniversalTime();
            //var localNow = utcNow.ToLocalTime();

            //Console.WriteLine(utcNow);
            //Console.WriteLine(localNow);

            //timespan arithmatic, shows how ticks work
            //var timeSpan = new TimeSpan(60, 100,200);

            ////60 hours + 100 min + 200 sec = 2 days, 13 hours, 43 min, 20 sec = 1 tick
            //Console.WriteLine($"{timeSpan.Days} days, {timeSpan.Hours} hours, {timeSpan.Minutes} min, {timeSpan.Seconds} sec");

            //Extending Dates
            var contractDate = new DateTimeOffset(2020, 2, 29 , 0, 0, 0, TimeSpan.Zero);
            var months = 1;

            contractDate = contractDate.ExtendContract(months);

            Console.WriteLine(contractDate);

            //contractDate = contractDate.AddMonths(6).AddTicks(-1);

            //Console.WriteLine(contractDate);
        }
    }
}

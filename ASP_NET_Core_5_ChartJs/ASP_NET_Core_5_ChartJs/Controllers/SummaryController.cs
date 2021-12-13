using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ChartJSCore.Models;
using ChartJSCore.Helpers;

namespace ASP_NET_Core_5_ChartJs.Controllers
{
    public class SummaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Charts01()
        {
            ViewData["PieChartJs"] = PieChartJs();
            return View();
        }
        private static Chart BarChartJs()
        {
            Random val = new Random();

            Chart chart = new Chart();
            chart.Type = Enums.ChartType.Bar;

            Data data = new Data();
            data.Labels = new List<string>() { "Delivery Value", "Billing Value", "Delivery & Not Billing" };

            BarDataset dataset1 = new BarDataset()
            {
                Label = "Delivery and Billing Report",
                Data = new List<double?> { 127395181.50, 114890746.45, 14484029.89},
                BackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromRgba(0, 0, 255, 0.2),
                },
                BorderWidth = new List<int>() { 1 }
            };

            //BarDataset dataset2 = new BarDataset()
            //{
            //    Label = "# Import",
            //    Data = new List<double?> { val.Next(), val.Next(), val.Next(), val.Next(), val.Next(), val.Next() },
            //    BackgroundColor = new List<ChartColor>
            //    {
            //        ChartColor.FromRgba(255, 0, 0, 0.2),
            //    },
            //    BorderWidth = new List<int>() { 1 }
            //};

            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset1);
            //data.Datasets.Add(dataset2);

            chart.Data = data;

            var options = new Options
            {
                Scales = new Scales()
            };

            var scales = new Scales
            {
                YAxes = new List<Scale>
                {
                    new CartesianScale
                    {
                        Ticks = new CartesianLinearTick
                        {
                            BeginAtZero = true
                        }
                    }
                },
                XAxes = new List<Scale>
                {
                    new BarScale
                    {
                        BarPercentage = 0.5,
                        BarThickness = 6,
                        MaxBarThickness = 8,
                        MinBarLength = 2,
                        GridLines = new GridLine()
                        {
                            OffsetGridLines = true
                        }
                    }
                }
            };

            options.Scales = scales;

            chart.Options = options;

            chart.Options.Layout = new Layout
            {
                Padding = new Padding
                {
                    PaddingObject = new PaddingObject
                    {
                        Left = 10,
                        Right = 12
                    }
                }
            };

            return chart;
        }
        private static Chart PieChartJs()
        {
            Random val = new Random();

            Chart chart = new Chart();
            chart.Type = Enums.ChartType.Pie;

            Data data = new Data();
            data.Labels = new List<string>() { "ค่าสินค้า เดือน 1-6", "ค่าแรง เดือน 1-6", "ค่าสินค้า เดือน 7- ปัจจุบัน", "ค่าแรง เดือน 7-ปัจจุบัน " };

            PieDataset dataset = new PieDataset()
            {
                Data = new List<double?> { 67200716.51, 13281796.04, 39799917.68, 7112751.27000001 },
                BackgroundColor = new List<ChartColor>() {
                    ChartColor.FromHexString("#FF0000"),
                    ChartColor.FromHexString("#00FF00"),
                    ChartColor.FromHexString("#0000FF"),
                    ChartColor.FromHexString("#FFFF00"),
                },

            };

            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset);

            Options options = new Options
            {
                Responsive = true
            };

            chart.Options = options;
            chart.Data = data;

            return chart;
        }
    }
}

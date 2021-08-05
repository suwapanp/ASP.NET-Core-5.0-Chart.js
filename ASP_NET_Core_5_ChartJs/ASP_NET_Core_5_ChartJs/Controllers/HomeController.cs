using ASP_NET_Core_5_ChartJs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using ChartJSCore.Models;
using ChartJSCore.Helpers;

namespace ASP_NET_Core_5_ChartJs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["LineChartJs"] = LineChartJs("false");
            return View();
        }
        public IActionResult pieChartJs()
        {
            ViewData["PieChartJs"] = PieChartJs();
            return View();
        }
        public IActionResult barChartJs()
        {
            ViewData["BarChartJs"] = BarChartJs();
            return View();
        }
        public IActionResult lineChartJs()
        {
            ViewData["LineChartJs"] = LineChartJs("true");
            return View();
        }

        private static Chart LineChartJs(string fill)
        {
            Random val = new Random();

            Chart chart = new Chart();
            chart.Type = Enums.ChartType.Line;

            Data data = new Data();
            data.Labels = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };

            LineDataset dataset1 = new LineDataset()
            {
                Label = "Export",
                Data = new List<double?> { val.Next(), val.Next(), val.Next(), val.Next(), val.Next(), val.Next() },
                Fill = fill,
                LineTension = 0.1,

                BackgroundColor = ChartColor.FromRgba(0, 0, 0, 0.1),
                BorderColor = ChartColor.FromRgb(0, 0, 255),
            };
            LineDataset dataset2 = new LineDataset()
            {
                Label = "Import",
                Data = new List<double?> { val.Next(), val.Next(), val.Next(), val.Next(), val.Next(), val.Next() },
                Fill = fill,
                LineTension = 0.1,

                BackgroundColor = ChartColor.FromRgba(0, 0, 0, 0.1),
                BorderColor = ChartColor.FromRgb(255, 0, 0),
            };

            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset1);
            data.Datasets.Add(dataset2);

            Options options = new Options
            {
                Responsive = true
            };

            chart.Options = options;

            chart.Data = data;
            return chart;
        }
        private static Chart PieChartJs()
        {
            Random val = new Random();

            Chart chart = new Chart();
            chart.Type = Enums.ChartType.Pie;

            Data data = new Data();
            data.Labels = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };

            PieDataset dataset = new PieDataset()
            {
                Data = new List<double?> { val.Next(), val.Next(), val.Next(), val.Next(), val.Next(), val.Next() },
                BackgroundColor = new List<ChartColor>() {
                    ChartColor.FromHexString("#FF0000"),
                    ChartColor.FromHexString("#00FF00"),
                    ChartColor.FromHexString("#0000FF"),
                    ChartColor.FromHexString("#FFFF00"),
                    ChartColor.FromHexString("#00FFFF"),
                    ChartColor.FromHexString("#FF00FF")
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
        private static Chart BarChartJs()
        {
            Random val = new Random();

            Chart chart = new Chart();
            chart.Type = Enums.ChartType.Bar;

            Data data = new Data();
            data.Labels = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };

            BarDataset dataset1 = new BarDataset()
            {
                Label = "# Export",
                Data = new List<double?> { val.Next(), val.Next(), val.Next(), val.Next(), val.Next(), val.Next() },
                BackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromRgba(0, 0, 255, 0.2),
                },
                BorderWidth = new List<int>() { 1 }
            };

            BarDataset dataset2 = new BarDataset()
            {
                Label = "# Import",
                Data = new List<double?> { val.Next(), val.Next(), val.Next(), val.Next(), val.Next(), val.Next() },
                BackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromRgba(255, 0, 0, 0.2),
                },
                BorderWidth = new List<int>() { 1 }
            };

            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset1);
            data.Datasets.Add(dataset2);

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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

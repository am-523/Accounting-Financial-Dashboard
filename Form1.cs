using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Dashboard_Financial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            chartcolum();
        }



        private void chartcolum()
        {


            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2019",
                    Values = new ChartValues<double> { 10,
                50,
                39,
                50,
                40,
                60,
                10,
                35,
                70,
                40,
                60,
                10,
                35 }
                }
            };

            //adding series will update and animate the chart automatically
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "2020",
                Values = new ChartValues<double> {  11,
            56,
            42,
            40,
            60,
            10,
            35,
            70,
            40,
            60,
            10,
            35 }
            });

            //also adding values updates and animates the chart automatically
            cartesianChart1.Series[1].Values.Add(48d);

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Sales Man",
                Labels = new[] { "Maria", "Susan", "Charles", "Frida", "Jaenab", "Roma", "Ferdinand", "Asril", "Jaenab", "Roma", "Ferdinand", "Asril" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sold Apps",
                LabelFormatter = value => value.ToString("N")
            });


        }


    }
}

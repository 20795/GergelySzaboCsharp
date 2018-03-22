using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
namespace GergelySzaboCsharp
{
    partial class Form1
    {
        //init städer

        City barcelona = new City("Barcelona", 1604555, 36902, 9070000);
        City boston = new City("Boston", 687584, 75297, 2210000);
        City amsterdam = new City("Amsterdam", 851573, 47950, 5340000);
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void chartFilling(City tempCity, Chart tempChart)
        {
            var privateRooms =
            from n in tempCity.AccommodationList
            where n.RoomType == "Private room"
            orderby n.Price
            select n;

            foreach (var n2 in privateRooms)
            {
                tempChart.Series["Series1"].Points.AddY(n2.Price);

            }
        }
        private void scatterplotFilling(City tempCity, Chart tempChart)
        {
            var tempVar =
            from n in tempCity.AccommodationList
            where n.OverallSatisfaction < 4.5
            select n;

            foreach (var n2 in tempVar)
            {
                tempChart.Series["Series1"].Points.AddXY(n2.Price,n2.OverallSatisfaction);
                
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Amsterdam - Private rooms";
            this.chart1.Titles.Add(title1);
            this.chart1.ChartAreas[0].AxisY.Title = "Price per night";  //sätter namnet på Y-axeln
            chartFilling(amsterdam, chart1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(318, 12);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Barcelona - Private rooms";
            this.chart2.Titles.Add(title2);
            this.chart2.ChartAreas[0].AxisY.Title = "Price per night";
            chartFilling(barcelona, chart2);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Location = new System.Drawing.Point(625, 13);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(300, 300);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Boston - Private rooms";
            this.chart3.Titles.Add(title3);
            this.chart3.ChartAreas[0].AxisY.Title = "Price per night";
            chartFilling(boston, chart3);
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            this.chart4.Location = new System.Drawing.Point(12, 329);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.ChartType = SeriesChartType.Point;
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(300, 300);
            this.chart4.TabIndex = 3;
            this.chart4.Text = "chart4";

            title4.Name = "Title1";
            title4.Text = "Overall Satisfaction < 4.5 / Price (Amsterdam)";
            this.chart4.Titles.Add(title4);

            this.chart4.ChartAreas[0].AxisY.Title = "Overall Satisfaction";
            this.chart4.ChartAreas[0].AxisX.Title = "Price per night";
            scatterplotFilling(amsterdam, chart4);
            // 
            // chart5
            // 
            chartArea5.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea5);
            legend1.Name = "Legend1";
            //this.chart5.Legends.Add(legend1);
            this.chart5.Location = new System.Drawing.Point(319, 329);
            this.chart5.Name = "chart5";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.ChartType = SeriesChartType.Point;
            this.chart5.Series.Add(series5);
            this.chart5.Size = new System.Drawing.Size(300, 300);
            this.chart5.TabIndex = 4;
            this.chart5.Text = "chart5";

            title5.Name = "Title1";
            title5.Text = "Overall Satisfaction < 4.5 / Price (Barcelona)";
            this.chart5.Titles.Add(title5);

            this.chart5.ChartAreas[0].AxisY.Title = "Overall Satisfaction";
            this.chart5.ChartAreas[0].AxisX.Title = "Price per night";
            scatterplotFilling(barcelona, chart5);
            // 
            // chart6
            // 
            chartArea6.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea6);
            legend2.Name = "Legend1";
            //this.chart6.Legends.Add(legend2);
            this.chart6.Location = new System.Drawing.Point(625, 329);
            this.chart6.Name = "chart6";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.ChartType = SeriesChartType.Point;
            this.chart6.Series.Add(series6);
            this.chart6.Size = new System.Drawing.Size(300, 300);
            this.chart6.TabIndex = 5;
            this.chart6.Text = "chart6";
            title6.Name = "Title1";
            title6.Text = "Overall Satisfaction < 4.5 / Price (Boston)";
            this.chart6.Titles.Add(title6);
            this.chart6.ChartAreas[0].AxisY.Title = "Overall Satisfaction";
            this.chart6.ChartAreas[0].AxisX.Title = "Price per night";
            scatterplotFilling(boston, chart6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.chart6);
            this.Controls.Add(this.chart5);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private Chart chart5;
        private Chart chart6;
    }
}


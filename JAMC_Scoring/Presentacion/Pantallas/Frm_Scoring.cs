using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Presentacion.Pantallas;
using Gizmox.WebGUI.Forms.Charts;

namespace Presentacion.Pantallas
{
	public partial class Frm_Scoring : Frm_Plantilla
	{
		public Frm_Scoring()
		{
			InitializeComponent();
            InitializeChart();
		}

        private void InitializeChart()
           {
               // Set theme for chart
               grafico_total.Theme = ThemeTypes.Theme2;
               // Create X axis
              AxisX x = new AxisX();
              x.Title = "OS Name";
              // Create Y axis
              AxisY y = new AxisY();
              y.Title = "U.S. Smartphone Market Share";
              y.Suffix = "%";
               // Setup chart
              grafico_total.Title = new Title("U.S. Smartphone Market Share, May 2011");
              grafico_total.AxisX = x;
              grafico_total.AxisY = y;
              // Create new data series for chart
              DataSeries ds = new DataSeries();
               // Setup dataseries
              ds.Name = "Percent usage";
               ds.RenderAs = DisplayTypes.Pie;
              ds.MarkerScale = 0.8;
              ds.ToolTipText = "Percent usage: #YValue";
              // Add points to data series
             ds.Add("Android OS", 36);
              ds.Add("Apple iOS", 26);
              ds.Add("RIM BlackBerry OS", 23);
              ds.Add("Windows Mobile", 9);
              ds.Add("HP WebOS", 2);
              ds.Add("Symbian OS", 2);
               ds.Add("Windows Phone 7", 1);
               ds.Add("Palm OS", 1);
               // Add dataseries to chart data
               grafico_total.Data.Add(ds);
               // Update chart
               grafico_total.Update();
            }

        public void GRAFICO_BARRA()
        {
              grafico_total.Theme = ThemeTypes.Theme2;
              // Create X axis
               AxisX x = new AxisX();
                x.Title = "OS Name";
               // Create Y axis
                AxisY y = new AxisY();
                y.Title = "Percent Usage";
               y.Suffix = "%";
               // Setup chart
               grafico_total.Title = new Title("Usage share of operating systems, May 2011");
               grafico_total.AxisX = x;
               grafico_total.AxisY = y;
                // Create new data series for chart
               DataSeries ds = new DataSeries();
               // Setup dataseries
                ds.Name = "Operation Systems";
                ds.RenderAs = DisplayTypes.Column;
                ds.LabelEnabled = true;
               // Add points to data series
               ds.Add("Windows XP", 40.26);
               ds.Add("Windows 7", 27.49);
              ds.Add("Windows Vista", 13.95);
                ds.Add("Mac OS X", 7.12);
                ds.Add("iOS", 2.20);
                ds.Add("Linux", 1.82);
               // Add dataseries to chart data
                grafico_total.Data.Add(ds);
                // Create new data series for chart
                ds = new DataSeries();
               // Set dataseries
               ds.Name = "Percent Usage Apr 2011";
              ds.RenderAs = DisplayTypes.Line;
              ds.MarkerScale = 0.8;
              ds.ToolTipText = "Percent Usage, Apr 2011: #YValue";
               // Add points to data series
                DataPoint dp = new DataPoint();
               dp.YValue = 38.37;
                ds.Add(dp);
     
               dp = new DataPoint();
                dp.YValue = 29.19;
               ds.Add(dp);
     
               dp = new DataPoint();
                dp.YValue = 13.27;
                ds.Add(dp);
     
                dp = new DataPoint();
                dp.YValue = 7.54;
                ds.Add(dp);
    
              dp = new DataPoint();
               dp.YValue = 2.80;
               ds.Add(dp);
     
               dp = new DataPoint();
               dp.YValue = 1.10;
                ds.Add(dp);
                // Add dataseries to chart data
                grafico_total.Data.Add(ds);
               // Update chart
                grafico_total.Update();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Scoring_Load(object sender, EventArgs e)
        {
            GRAFICO_BARRA();
        }		
	}
}

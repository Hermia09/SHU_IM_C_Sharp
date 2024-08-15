using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Collections;

namespace ZedGraphTest
{
    public partial class ZedGraphTestForm : Form
    {
        private GraphPane m_graphPane;
        private string m_plotString;
        private PointPairList m_pointsList;
        private List<string[]> m_pieChartList;

        public ZedGraphTestForm()
        {
            InitializeComponent();
            m_graphPane = zg1.GraphPane;
            FillPaneBackground();            
        }


        private void cmdPlot_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessPointsData();
                CreateLineGraph();
                SetSize();
            }
            catch
            {
                MessageBox.Show("Please Enter Two Columns of Numerical Data", "Plot Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cmdBarGraph_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessPointsData();
                CreateBarGraph();
                SetSize();
            }
            catch
            {
                MessageBox.Show("Please Enter Two Columns of Numerical Data", "Plot Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdPieChart_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessPieChartData();
                CreatePieChart();
                SetSize();
            }
            catch
            {
                MessageBox.Show("Second Columns' Data should be Numerical Value", "Plot Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessPointsData()
        { 
            m_plotString = txtLineBarPlotData.Text; 
            List<string[]> _pointsList = new List<string[]>();
            //'\n' refers to newLine character., using it as Delimter
            string[] _graphInputRows = m_plotString.Split('\n');            
            
            m_pointsList = new PointPairList();
            for (int i = 0; i < _graphInputRows.Length; i++)
            {
                //"r" appears at the end., getting rid of it
                string _yValue = _graphInputRows[i].Replace("\r", "");
                _yValue = _yValue.Trim();
                if (_yValue != "")
                {
                    //'\t' refers to tab character., using it as Delimter
                    string[] _pointsTemp = _yValue.Split('\t');
                    double _x = Convert.ToDouble(_pointsTemp[0]);
                    double _y = Convert.ToDouble(_pointsTemp[1]);
                    m_pointsList.Add(_x, _y);
                }
            }
        }

        private void CreateLineGraph()        
        {
           

            //clear if anything exists.            
            m_graphPane.CurveList.Clear();

            string _graphTitle = "", _xTitle = "", _yTitle = "";

            // Set the titles and axis labels
            SetLineBarTitleAndAxisDetails(ref _graphTitle, ref _xTitle, ref _yTitle);
            m_graphPane.Title.Text = _graphTitle;
            m_graphPane.XAxis.Title.Text = _xTitle;
            m_graphPane.YAxis.Title.Text = _yTitle;

            // Generate a blue curve with Star symbols
            LineItem myCurve = m_graphPane.AddCurve(txtPlotTitle.Text, m_pointsList, Color.Blue, SymbolType.Star);

            // Calculate the Axis Scale Ranges
            zg1.AxisChange();
        }

        private void SetLineBarTitleAndAxisDetails(ref string _graphTitle, ref string _xTitle, ref string _yTitle)
        {
            _graphTitle = txtPlotTitle.Text;
            string _xTitleTemp = txtXTitle.Text;
            string _yTitleTemp = txtYTitle.Text;
            string _xUnit = txtXUnit.Text;
            string _yUnit = txtYUnit.Text;

            if (_graphTitle == "")
            {
                _graphTitle = "Graph Test";
            }

            if (_xTitleTemp == "")
            {
                _xTitle = "X Axis";
            }

            if (_yTitleTemp == "")
            {
                _yTitle = "Y Axis";
            }

            if (_xUnit != "")
            {
                _xTitle = _xTitleTemp + " (" + _xUnit + " )";
            }

            if (_yUnit != "")
            {
                _yTitle = _yTitleTemp + " (" + _yUnit + " )";
            }
        }

        
        private void CreateBarGraph()
        {
          
            //clear if anything exists.            
            m_graphPane.CurveList.Clear();

            string _graphTitle = "", _xTitle = "", _yTitle = "";

            // Set the titles and axis labels
            SetLineBarTitleAndAxisDetails(ref _graphTitle, ref _xTitle, ref _yTitle);
            m_graphPane.Title.Text = _graphTitle;
            m_graphPane.XAxis.Title.Text = _xTitle;
            m_graphPane.YAxis.Title.Text = _yTitle;

            BarItem myCurve = m_graphPane.AddBar(txtPlotTitle.Text, m_pointsList, Color.Blue);
            Color[] colors = { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Purple };
            myCurve.Bar.Fill = new Fill(colors);
            myCurve.Bar.Fill.Type = FillType.GradientByZ;

            myCurve.Bar.Fill.RangeMin = 0;
            myCurve.Bar.Fill.RangeMax = 4;
            
            // Tell ZedGraph to calculate the axis ranges
            zg1.AxisChange();
        }

        private void ProcessPieChartData()
        {
            m_pieChartList = new List<string[]>();

            m_plotString = txtPieChartPlotData.Text;
            //'\n' refers to newLine character., using it as Delimter
            string[] _graphInputRows = m_plotString.Split('\n');           

            //string[] _pointsTemp;           
            for (int i = 0; i < _graphInputRows.Length; i++)
            {
                //"r" appears at the end., getting rid of it
                string _yValue = _graphInputRows[i].Replace("\r", "");
                _yValue = _yValue.Trim();
                if (_yValue != "")
                {
                    //'\t' refers to tab character., using it as Delimter
                    string[] _pointsTemp = _yValue.Split('\t'); 
                    m_pieChartList.Add(_pointsTemp);
                }
            }
        }

        public void CreatePieChart()
        {
            //clear if anything exists.            
            m_graphPane.CurveList.Clear();

            // Set the GraphPane title
            m_graphPane.Title.Text = txtPieChartTitle.Text; 

            // Add some pie slices
            Color[] colors = { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Purple };
            int _colorIndex = 0;
            foreach (string[] _currentStringArray in m_pieChartList)
            {
                string _label = _currentStringArray[0];
                double _value = Convert.ToDouble(_currentStringArray[1]);
                //using modulus operator, so that Colors repeat themselves in cyclic fashion.
                m_graphPane.AddPieSlice(_value, colors[_colorIndex % 5], 0, _label);
                _colorIndex++;
            }

            zg1.AxisChange();
        }

        private void FillPaneBackground()
        {
            // Fill the axis background with a color gradient
            m_graphPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            // Fill the pane background with a color gradient
            m_graphPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);
        } 

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void SetSize()
        {
            zg1.Location = new Point(5, 168);
            // Leave a small margin around the outside of the control
            zg1.Size = new Size(this.ClientRectangle.Width - 10, this.ClientRectangle.Height - 168);
        }

        
    }
}
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
    public partial class FrmZedGraph4SmallGuruModified : Form
    {
        //private GraphPane m_graphPane;//original one
        //private string m_plotString;//original one
        private PointPairList m_pointsList;
        private List<string[]> m_pieChartList;

        #region variables added by MCLo
        private GraphPane m_graphPane4Pie;//modified; GraphPane m_graphPane (original)
        private string m_plotString4Pie;//modified; string m_plotString (original) 
        private GraphPane m_graphPane4BarLine;
        private string m_plotString4LineBar;

        string[] receivedDataArray;//data-array string received from outer caller
        string[] receivedLabelsArray4Pie;//label-array string received from outer caller for PieChart
        string[] receivedLabelsArray4LineBar;//label-array string received from outer caller for PieChart
        const char SPLITTAB = '\t';
        string pieChartTitle = "";
        string linBarGraphTitle = "";
        int totalCount = 0;
        bool isPercentage = false;
        bool isOuter = false;
        public FrmZedGraph4SmallGuruModified frmZeg;
        #endregion variables added by MCLo

        public FrmZedGraph4SmallGuruModified()
        {
            InitializeComponent();
            m_graphPane4Pie = zgForm.GraphPane;//for line and bar graph
            FillPaneBackground();
        }

        public FrmZedGraph4SmallGuruModified(string strData, string strLabels4Pie, string strLabels4LineBar, string _ChartTitle, bool _isPercentage,
         bool _isPieChartShown1st, bool _isOuter, string _txtXTitile, string _txtYTitle, string _txtXUnit, string _txtYUnit)
        {
            frmZeg = this;
            initializePhase(_isPieChartShown1st);
            isOuter = _isOuter;

            #region Receive data from outer
            pieChartTitle = _ChartTitle;
            linBarGraphTitle = _ChartTitle;

            txtPieChartTitle.Text = pieChartTitle; //*"Pie of level Distribution"*/;//modified by Lo
            txtPlotTitle.Text = linBarGraphTitle;
            txtXTitle.Text = _txtXTitile;
            txtYTitle.Text = _txtYTitle;
            txtXUnit.Text = _txtXUnit;
            txtYUnit.Text = _txtYUnit;

            isPercentage = _isPercentage;
            #endregion Receive data from outer
            
            processOuterData2GetReady4Plot(strData, strLabels4Pie, strLabels4LineBar);
        }//end FrmZedGraph4SmallGuruModified()

        private void initializePhase(bool _isPieChartShown1st)
        {
            InitializeComponent();
            m_graphPane4Pie = zgForm.GraphPane;//for line and bar graph
            m_graphPane4BarLine = zgLineBar.GraphPane;

            fillPaneBackground(_isPieChartShown1st);
        }//end initializePhase()

        private void fillPaneBackground(bool isPieShown1st)
        {
            // Fill the axis background with a color gradient
            m_graphPane4Pie.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            // Fill the pane background with a color gradient
            m_graphPane4Pie.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);

            // Fill the axis background with a color gradient
            m_graphPane4BarLine.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            // Fill the pane background with a color gradient
            m_graphPane4BarLine.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);

            if (isPieShown1st)
            {
                zgForm.Show();
                zgLineBar.Hide();
            }
            else
            {
                zgLineBar.Show();
                zgForm.Hide();
            }

        }//end FillPaneBackground(bool isPieShown1st)

        private void FillPaneBackground()
        {
            // Fill the axis background with a color gradient
            m_graphPane4Pie.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            // Fill the pane background with a color gradient
            m_graphPane4Pie.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);

            m_graphPane4BarLine.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            m_graphPane4BarLine.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);
        }//end FillPaneBackground  
        
        private void cmdLinePlot_Click_1(object sender, EventArgs e)
        {
            zgLineBar.Show();
            zgForm.Hide();
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
            zgLineBar.Show();
            zgForm.Hide();
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
            zgForm.Show();
            zgLineBar.Hide();
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

        public void processOuterData2GetReady4Plot(string strData, string strLabels, string strLabels4LineBar)
        {
            #region  Process outer coming data
            receivedDataArray = (strData).Split(SPLITTAB);
            receivedLabelsArray4Pie = (strLabels).Split(SPLITTAB);
            receivedLabelsArray4LineBar = (strLabels4LineBar).Split(SPLITTAB);
            //dataset = new string[] { "Credit", "debit", "Zero" };//e.g.

            for (int i = 0; i < receivedDataArray.Length; i++)
            {
                m_plotString4Pie += (receivedLabelsArray4Pie[i] + SPLITTAB + receivedDataArray[i] + "\r\n");
                m_plotString4LineBar += (receivedLabelsArray4LineBar[i] + SPLITTAB + receivedDataArray[i] + "\r\n");
            }

            //MessageBox.Show(" m_plotString: \r\n" + m_plotString4Pie);
            txtPieChartPlotData.Text = m_plotString4Pie;
            txtLineBarPlotData.Text = m_plotString4LineBar;
            #endregion  Process outer coming data

            //processPieChartData();
            //processCreatePieChart();//original
        }//end ProcessOuterDataThenCreatePieChart 

        private void ProcessPointsData()
        { 
            m_plotString4LineBar = txtLineBarPlotData.Text; 
            List<string[]> _pointsList = new List<string[]>();
            //'\n' refers to newLine character., using it as Delimter
            string[] _graphInputRows = m_plotString4LineBar.Split('\n');            
            
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
        }//end ProcessPointsData

        private void CreateLineGraph()        
        {
            //clear if anything exists.            
            m_graphPane4BarLine.CurveList.Clear();

            string _graphTitle = "", _xTitle = "", _yTitle = "";

            // Set the titles and axis labels
            SetLineBarTitleAndAxisDetails(ref _graphTitle, ref _xTitle, ref _yTitle);
            m_graphPane4BarLine.Title.Text = _graphTitle;
            m_graphPane4BarLine.XAxis.Title.Text = _xTitle;
            m_graphPane4BarLine.YAxis.Title.Text = _yTitle;

            // Generate a blue curve with Star symbols
            LineItem myCurve = m_graphPane4BarLine.AddCurve(txtPlotTitle.Text, m_pointsList, Color.Blue, SymbolType.Star);

            // Calculate the Axis Scale Ranges
            //zgForm.AxisChange();

            zgLineBar.AxisChange();
            zgLineBar.Refresh();
        }//end CreateLineGraph

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
        }//end SetLineBarTitleAndAxisDetails

        private void CreateBarGraph()
        {
            //clear if anything exists.            
            m_graphPane4BarLine.CurveList.Clear();

            string _graphTitle = "", _xTitle = "", _yTitle = "";

            // Set the titles and axis labels
            SetLineBarTitleAndAxisDetails(ref _graphTitle, ref _xTitle, ref _yTitle);
            m_graphPane4BarLine.Title.Text = _graphTitle;
            m_graphPane4BarLine.XAxis.Title.Text = _xTitle;
            m_graphPane4BarLine.YAxis.Title.Text = _yTitle;

            BarItem myCurve = m_graphPane4BarLine.AddBar(txtPlotTitle.Text, m_pointsList, Color.Blue);
            Color[] colors = { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Purple };
            myCurve.Bar.Fill = new Fill(colors);
            myCurve.Bar.Fill.Type = FillType.GradientByZ;

            myCurve.Bar.Fill.RangeMin = 0;
            myCurve.Bar.Fill.RangeMax = 4;

            // Tell ZedGraph to calculate the axis ranges
            zgLineBar.AxisChange();
            zgLineBar.Refresh();
        }//end CreateBarGraph

        private void ProcessPieChartData()
        {
            m_pieChartList = new List<string[]>();

            m_plotString4Pie = txtPieChartPlotData.Text;
            //'\n' refers to newLine character., using it as Delimter
            string[] _graphInputRows = m_plotString4Pie.Split('\n');           

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
        }//end ProcessPieChartData

        public void CreatePieChart()
        {
            //clear if anything exists.            
            m_graphPane4Pie.CurveList.Clear();

            // Set the GraphPane title
            m_graphPane4Pie.Title.Text = txtPieChartTitle.Text; 

            // Add some pie slices
            Color[] colors = { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Purple };
            int _colorIndex = 0;

            #region calculate total count
            totalCount = 0;
            foreach (string[] _currentStringArray in m_pieChartList)
            {
                double _value = Convert.ToDouble(_currentStringArray[1]);
                totalCount += (int)_value;//accumulate all frequencies...
            }
            #endregion calculate total count

            foreach (string[] _currentStringArray in m_pieChartList)
            {
                string _label = _currentStringArray[0];
                double _value = Convert.ToDouble(_currentStringArray[1]);

                #region optimise labels for pie-chart presentation (e.g. count-number and percentage %)
                _label += ": " + _value.ToString("F0");
                if (isPercentage)
                {
                    double percent = (_value / (double)totalCount) * 100.0;//transform frequencies into percentage
                    _label += " (" + percent.ToString("F2") + "%)";
                }

                #endregion optimise labels for pie-chart presentation (e.g. count-number and percentage %)

                //using modulus operator, so that Colors repeat themselves in cyclic fashion.
                m_graphPane4Pie.AddPieSlice(_value, colors[_colorIndex % 5], 0, _label);
                _colorIndex++;
            }

            zgForm.AxisChange();
        }//end  CreatePieChart

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void SetSize()
        {
            zgForm.Location = new Point(5, 168);
            // Leave a small margin around the outside of the control
            zgForm.Size = new Size(this.ClientRectangle.Width - 10, this.ClientRectangle.Height - 168);
        }

    }
}
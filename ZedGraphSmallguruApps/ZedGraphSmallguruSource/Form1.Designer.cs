namespace ZedGraphTest
{
    partial class ZedGraphTestForm
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZedGraphTestForm));
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.tabPieChart = new System.Windows.Forms.TabPage();
            this.cmdPieChart = new System.Windows.Forms.Button();
            this.tabLinePlot = new System.Windows.Forms.TabPage();
            this.cmdLinePlot = new System.Windows.Forms.Button();
            this.txtLineBarPlotData = new System.Windows.Forms.TextBox();
            this.txtPlotTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXUnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdBarGraph = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPieChartTitle = new System.Windows.Forms.TextBox();
            this.txtPieChartPlotData = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPieChart.SuspendLayout();
            this.tabLinePlot.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zg1
            // 
            this.zg1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zg1.Location = new System.Drawing.Point(0, 170);
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0;
            this.zg1.ScrollMaxX = 0;
            this.zg1.ScrollMaxY = 0;
            this.zg1.ScrollMaxY2 = 0;
            this.zg1.ScrollMinX = 0;
            this.zg1.ScrollMinY = 0;
            this.zg1.ScrollMinY2 = 0;
            this.zg1.Size = new System.Drawing.Size(529, 328);
            this.zg1.TabIndex = 0;
            // 
            // tabPieChart
            // 
            this.tabPieChart.Controls.Add(this.label8);
            this.tabPieChart.Controls.Add(this.txtPieChartTitle);
            this.tabPieChart.Controls.Add(this.txtPieChartPlotData);
            this.tabPieChart.Controls.Add(this.label9);
            this.tabPieChart.Controls.Add(this.label10);
            this.tabPieChart.Controls.Add(this.cmdPieChart);
            this.tabPieChart.Location = new System.Drawing.Point(4, 22);
            this.tabPieChart.Name = "tabPieChart";
            this.tabPieChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPieChart.Size = new System.Drawing.Size(521, 142);
            this.tabPieChart.TabIndex = 2;
            this.tabPieChart.Text = "Pie Chart";
            this.tabPieChart.UseVisualStyleBackColor = true;
            // 
            // cmdPieChart
            // 
            this.cmdPieChart.Location = new System.Drawing.Point(438, 113);
            this.cmdPieChart.Name = "cmdPieChart";
            this.cmdPieChart.Size = new System.Drawing.Size(75, 23);
            this.cmdPieChart.TabIndex = 2;
            this.cmdPieChart.Text = "Pie Chart";
            this.cmdPieChart.UseVisualStyleBackColor = true;
            this.cmdPieChart.Click += new System.EventHandler(this.cmdPieChart_Click);
            // 
            // tabLinePlot
            // 
            this.tabLinePlot.Controls.Add(this.cmdBarGraph);
            this.tabLinePlot.Controls.Add(this.label7);
            this.tabLinePlot.Controls.Add(this.label5);
            this.tabLinePlot.Controls.Add(this.txtYUnit);
            this.tabLinePlot.Controls.Add(this.txtXUnit);
            this.tabLinePlot.Controls.Add(this.txtYTitle);
            this.tabLinePlot.Controls.Add(this.txtXTitle);
            this.tabLinePlot.Controls.Add(this.txtPlotTitle);
            this.tabLinePlot.Controls.Add(this.txtLineBarPlotData);
            this.tabLinePlot.Controls.Add(this.label6);
            this.tabLinePlot.Controls.Add(this.label4);
            this.tabLinePlot.Controls.Add(this.label3);
            this.tabLinePlot.Controls.Add(this.label2);
            this.tabLinePlot.Controls.Add(this.label1);
            this.tabLinePlot.Controls.Add(this.cmdLinePlot);
            this.tabLinePlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLinePlot.Location = new System.Drawing.Point(4, 22);
            this.tabLinePlot.Name = "tabLinePlot";
            this.tabLinePlot.Padding = new System.Windows.Forms.Padding(3);
            this.tabLinePlot.Size = new System.Drawing.Size(521, 142);
            this.tabLinePlot.TabIndex = 0;
            this.tabLinePlot.Text = "Line Plot / Bar Graph";
            this.tabLinePlot.UseVisualStyleBackColor = true;
            // 
            // cmdLinePlot
            // 
            this.cmdLinePlot.Location = new System.Drawing.Point(357, 113);
            this.cmdLinePlot.Name = "cmdLinePlot";
            this.cmdLinePlot.Size = new System.Drawing.Size(75, 23);
            this.cmdLinePlot.TabIndex = 8;
            this.cmdLinePlot.Text = "Line Plot";
            this.cmdLinePlot.UseVisualStyleBackColor = true;
            this.cmdLinePlot.Click += new System.EventHandler(this.cmdPlot_Click);
            // 
            // txtLineBarPlotData
            // 
            this.txtLineBarPlotData.Location = new System.Drawing.Point(188, 33);
            this.txtLineBarPlotData.Multiline = true;
            this.txtLineBarPlotData.Name = "txtLineBarPlotData";
            this.txtLineBarPlotData.Size = new System.Drawing.Size(135, 98);
            this.txtLineBarPlotData.TabIndex = 7;
            // 
            // txtPlotTitle
            // 
            this.txtPlotTitle.Location = new System.Drawing.Point(73, 7);
            this.txtPlotTitle.Name = "txtPlotTitle";
            this.txtPlotTitle.Size = new System.Drawing.Size(100, 20);
            this.txtPlotTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plot Title";
            // 
            // txtXTitle
            // 
            this.txtXTitle.Location = new System.Drawing.Point(73, 33);
            this.txtXTitle.Name = "txtXTitle";
            this.txtXTitle.Size = new System.Drawing.Size(100, 20);
            this.txtXTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X Axis Title";
            // 
            // txtYTitle
            // 
            this.txtYTitle.Location = new System.Drawing.Point(73, 59);
            this.txtYTitle.Name = "txtYTitle";
            this.txtYTitle.Size = new System.Drawing.Size(100, 20);
            this.txtYTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X Axis Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Plot Data";
            // 
            // txtXUnit
            // 
            this.txtXUnit.Location = new System.Drawing.Point(73, 85);
            this.txtXUnit.Name = "txtXUnit";
            this.txtXUnit.Size = new System.Drawing.Size(100, 20);
            this.txtXUnit.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y Axis Title";
            // 
            // txtYUnit
            // 
            this.txtYUnit.Location = new System.Drawing.Point(73, 111);
            this.txtYUnit.Name = "txtYUnit";
            this.txtYUnit.Size = new System.Drawing.Size(100, 20);
            this.txtYUnit.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Y Axis Unit";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLinePlot);
            this.tabControl1.Controls.Add(this.tabPieChart);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 168);
            this.tabControl1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(331, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 52);
            this.label7.TabIndex = 15;
            this.label7.Text = "Paste Two Columns of \r\nNumerical Values from a \r\nspreadsheet to Plot Data field. " +
                "\r\nPlot Line Graph or Bar Graph";
            // 
            // cmdBarGraph
            // 
            this.cmdBarGraph.Location = new System.Drawing.Point(438, 113);
            this.cmdBarGraph.Name = "cmdBarGraph";
            this.cmdBarGraph.Size = new System.Drawing.Size(75, 23);
            this.cmdBarGraph.TabIndex = 9;
            this.cmdBarGraph.Text = "Bar Graph";
            this.cmdBarGraph.UseVisualStyleBackColor = true;
            this.cmdBarGraph.Click += new System.EventHandler(this.cmdBarGraph_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(280, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 52);
            this.label8.TabIndex = 20;
            this.label8.Text = "Paste Two Columns of Values\r\nfrom a spreadsheet in Plot Data field.\r\nFirst Column" +
                " should be a Label/Name.\r\nSecond Column should be a Number. ";
            // 
            // txtPieChartTitle
            // 
            this.txtPieChartTitle.Location = new System.Drawing.Point(11, 28);
            this.txtPieChartTitle.Name = "txtPieChartTitle";
            this.txtPieChartTitle.Size = new System.Drawing.Size(100, 20);
            this.txtPieChartTitle.TabIndex = 0;
            // 
            // txtPieChartPlotData
            // 
            this.txtPieChartPlotData.Location = new System.Drawing.Point(120, 28);
            this.txtPieChartPlotData.Multiline = true;
            this.txtPieChartPlotData.Name = "txtPieChartPlotData";
            this.txtPieChartPlotData.Size = new System.Drawing.Size(149, 98);
            this.txtPieChartPlotData.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(117, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Plot Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Plot Title";
            // 
            // ZedGraphTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 498);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.zg1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(537, 536);
            this.Name = "ZedGraphTestForm";
            this.Text = " SmallGuru ZedGraph Plot";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabPieChart.ResumeLayout(false);
            this.tabPieChart.PerformLayout();
            this.tabLinePlot.ResumeLayout(false);
            this.tabLinePlot.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zg1;
        private System.Windows.Forms.TabPage tabPieChart;
        private System.Windows.Forms.Button cmdPieChart;
        private System.Windows.Forms.TabPage tabLinePlot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYUnit;
        private System.Windows.Forms.TextBox txtXUnit;
        private System.Windows.Forms.TextBox txtYTitle;
        private System.Windows.Forms.TextBox txtXTitle;
        private System.Windows.Forms.TextBox txtPlotTitle;
        private System.Windows.Forms.TextBox txtLineBarPlotData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdLinePlot;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdBarGraph;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPieChartTitle;
        private System.Windows.Forms.TextBox txtPieChartPlotData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}


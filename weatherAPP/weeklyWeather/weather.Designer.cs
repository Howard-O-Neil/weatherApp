namespace weatherAPP.weeklyWeather
{
    partial class weather
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
			this.panel = new System.Windows.Forms.Panel();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.fullContent = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.temperChart = new DevExpress.XtraCharts.ChartControl();
			this.label = new System.Windows.Forms.Label();
			this.panel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.panel6.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.temperChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.mainPanel);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(1469, 900);
			this.panel.TabIndex = 0;
			// 
			// mainPanel
			// 
			this.mainPanel.AutoScroll = true;
			this.mainPanel.BackColor = System.Drawing.Color.Linen;
			this.mainPanel.Controls.Add(this.panel6);
			this.mainPanel.Controls.Add(this.tableLayoutPanel1);
			this.mainPanel.Controls.Add(this.temperChart);
			this.mainPanel.Controls.Add(this.label);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1469, 900);
			this.mainPanel.TabIndex = 2;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.fullContent);
			this.panel6.Controls.Add(this.update);
			this.panel6.Controls.Add(this.label1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel6.Location = new System.Drawing.Point(0, 995);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1448, 326);
			this.panel6.TabIndex = 6;
			// 
			// fullContent
			// 
			this.fullContent.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fullContent.BackColor = System.Drawing.Color.MediumAquamarine;
			this.fullContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fullContent.Location = new System.Drawing.Point(84, 28);
			this.fullContent.MaximumSize = new System.Drawing.Size(450, 62);
			this.fullContent.MinimumSize = new System.Drawing.Size(450, 62);
			this.fullContent.Name = "fullContent";
			this.fullContent.Size = new System.Drawing.Size(450, 62);
			this.fullContent.TabIndex = 3;
			this.fullContent.Text = "see full content";
			this.fullContent.UseVisualStyleBackColor = false;
			this.fullContent.Click += new System.EventHandler(this.fullContent_Click);
			// 
			// update
			// 
			this.update.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(0, 206);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(1448, 50);
			this.update.TabIndex = 2;
			this.update.Text = "waitting";
			this.update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 256);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1448, 70);
			this.label1.TabIndex = 1;
			this.label1.Text = "---------------------------------------------------------------------------------" +
    "--";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 618);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1293, 377);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Ivory;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(1035, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(255, 371);
			this.panel5.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Ivory;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(777, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(252, 371);
			this.panel4.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Ivory;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(519, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(252, 371);
			this.panel3.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Ivory;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(261, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(252, 371);
			this.panel2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Ivory;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(252, 371);
			this.panel1.TabIndex = 0;
			// 
			// temperChart
			// 
			this.temperChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram1.AxisY.Interlaced = true;
			xyDiagram1.AxisY.MinorCount = 4;
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
			this.temperChart.Diagram = xyDiagram1;
			this.temperChart.Legend.Name = "Default Legend";
			this.temperChart.Location = new System.Drawing.Point(55, 122);
			this.temperChart.MaximumSize = new System.Drawing.Size(1293, 470);
			this.temperChart.MinimumSize = new System.Drawing.Size(1293, 470);
			this.temperChart.Name = "temperChart";
			series1.Name = "Series 1";
			series2.Name = "Series 2";
			series3.Name = "Series 3";
			this.temperChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
			this.temperChart.SeriesTemplate.SeriesColorizer = null;
			this.temperChart.SeriesTemplate.View = lineSeriesView1;
			this.temperChart.Size = new System.Drawing.Size(1293, 470);
			this.temperChart.TabIndex = 4;
			// 
			// label
			// 
			this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold);
			this.label.ForeColor = System.Drawing.Color.White;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(1448, 85);
			this.label.TabIndex = 3;
			this.label.Text = "Weekly Weather Information Data";
			// 
			// graph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.Controls.Add(this.panel);
			this.Name = "graph";
			this.Size = new System.Drawing.Size(1469, 900);
			this.Load += new System.EventHandler(this.graph_Load);
			this.panel.ResumeLayout(false);
			this.mainPanel.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.temperChart)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button fullContent;
		private System.Windows.Forms.Label update;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraCharts.ChartControl temperChart;
		private System.Windows.Forms.Label label;
	}
}

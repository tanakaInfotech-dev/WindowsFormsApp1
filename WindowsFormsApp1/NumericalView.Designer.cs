namespace WindowsFormsApp1
{
    partial class NumericalView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.close_btn = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.numeric_dgv = new System.Windows.Forms.DataGridView();
            this.numeric_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateLabel = new System.Windows.Forms.Label();
            this.numericLabel = new System.Windows.Forms.Label();
            this.numeric_txtbox = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.numDate_dt = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(655, 424);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.Location = new System.Drawing.Point(110, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(253, 23);
            this.UserLabel.TabIndex = 2;
            // 
            // numeric_dgv
            // 
            this.numeric_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numeric_dgv.Location = new System.Drawing.Point(15, 44);
            this.numeric_dgv.Name = "numeric_dgv";
            this.numeric_dgv.RowTemplate.Height = 21;
            this.numeric_dgv.Size = new System.Drawing.Size(293, 335);
            this.numeric_dgv.TabIndex = 3;
            // 
            // numeric_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.numeric_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.numeric_chart.Legends.Add(legend1);
            this.numeric_chart.Location = new System.Drawing.Point(323, 44);
            this.numeric_chart.Name = "numeric_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.numeric_chart.Series.Add(series1);
            this.numeric_chart.Size = new System.Drawing.Size(407, 335);
            this.numeric_chart.TabIndex = 4;
            this.numeric_chart.Text = "chart1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(15, 386);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(29, 12);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "日付";
            // 
            // numericLabel
            // 
            this.numericLabel.AutoSize = true;
            this.numericLabel.Location = new System.Drawing.Point(15, 424);
            this.numericLabel.Name = "numericLabel";
            this.numericLabel.Size = new System.Drawing.Size(29, 12);
            this.numericLabel.TabIndex = 6;
            this.numericLabel.Text = "数値";
            // 
            // numeric_txtbox
            // 
            this.numeric_txtbox.Location = new System.Drawing.Point(67, 421);
            this.numeric_txtbox.Name = "numeric_txtbox";
            this.numeric_txtbox.Size = new System.Drawing.Size(100, 19);
            this.numeric_txtbox.TabIndex = 8;
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(191, 419);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 9;
            this.insert_btn.Text = "入力";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // numDate_dt
            // 
            this.numDate_dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.numDate_dt.Location = new System.Drawing.Point(66, 382);
            this.numDate_dt.Name = "numDate_dt";
            this.numDate_dt.Size = new System.Drawing.Size(200, 19);
            this.numDate_dt.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 12);
            this.label.TabIndex = 11;
            this.label.Text = "ユーザー名";
            // 
            // NumericalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 459);
            this.Controls.Add(this.label);
            this.Controls.Add(this.numDate_dt);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.numeric_txtbox);
            this.Controls.Add(this.numericLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.numeric_chart);
            this.Controls.Add(this.numeric_dgv);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.close_btn);
            this.Name = "NumericalView";
            this.Text = "NumericalView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumericalView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NumericalView_FormClosed);
            this.Load += new System.EventHandler(this.NumericalView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.DataGridView numeric_dgv;
        private System.Windows.Forms.DataVisualization.Charting.Chart numeric_chart;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label numericLabel;
        private System.Windows.Forms.TextBox numeric_txtbox;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.DateTimePicker numDate_dt;
        private System.Windows.Forms.Label label;
    }
}
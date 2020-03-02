namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Launch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inputHeight = new System.Windows.Forms.NumericUpDown();
            this.inputAngle = new System.Windows.Forms.NumericUpDown();
            this.inputSpeed = new System.Windows.Forms.NumericUpDown();
            this.Stop = new System.Windows.Forms.Button();
            this.Resume = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputWeight = new System.Windows.Forms.NumericUpDown();
            this.inputSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).BeginInit();
            this.SuspendLayout();
            // 
            // Launch
            // 
            this.Launch.Location = new System.Drawing.Point(497, 90);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(116, 30);
            this.Launch.TabIndex = 0;
            this.Launch.Text = "Launch";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Angle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Speed:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 141);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(811, 423);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inputHeight
            // 
            this.inputHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputHeight.Location = new System.Drawing.Point(113, 15);
            this.inputHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(120, 26);
            this.inputHeight.TabIndex = 12;
            // 
            // inputAngle
            // 
            this.inputAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAngle.Location = new System.Drawing.Point(113, 49);
            this.inputAngle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.inputAngle.Name = "inputAngle";
            this.inputAngle.Size = new System.Drawing.Size(120, 26);
            this.inputAngle.TabIndex = 13;
            // 
            // inputSpeed
            // 
            this.inputSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSpeed.Location = new System.Drawing.Point(113, 84);
            this.inputSpeed.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(120, 26);
            this.inputSpeed.TabIndex = 14;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(638, 16);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(105, 30);
            this.Stop.TabIndex = 15;
            this.Stop.Text = "Stop!";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Resume
            // 
            this.Resume.Location = new System.Drawing.Point(749, 16);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(98, 30);
            this.Resume.TabIndex = 16;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = true;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(745, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Time:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(805, 90);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(18, 20);
            this.time.TabIndex = 18;
            this.time.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(274, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(274, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Weight:";
            // 
            // inputWeight
            // 
            this.inputWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputWeight.Location = new System.Drawing.Point(345, 49);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(120, 26);
            this.inputWeight.TabIndex = 21;
            // 
            // inputSize
            // 
            this.inputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSize.Location = new System.Drawing.Point(345, 14);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(120, 26);
            this.inputSize.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 576);
            this.Controls.Add(this.inputSize);
            this.Controls.Add(this.inputWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.inputSpeed);
            this.Controls.Add(this.inputAngle);
            this.Controls.Add(this.inputHeight);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Launch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown inputHeight;
        private System.Windows.Forms.NumericUpDown inputAngle;
        private System.Windows.Forms.NumericUpDown inputSpeed;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown inputWeight;
        private System.Windows.Forms.NumericUpDown inputSize;
    }
}


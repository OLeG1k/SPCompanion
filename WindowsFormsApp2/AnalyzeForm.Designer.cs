
namespace WindowsFormsApp2
{
    partial class AnalyzeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 66D);
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.UserHeight = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.IdealWeight = new System.Windows.Forms.Label();
            this.MinSteps = new System.Windows.Forms.Label();
            this.MaxSteps = new System.Windows.Forms.Label();
            this.AverageSteps = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.KkalPerDay = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.MarkActivity = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TotalSteps = new System.Windows.Forms.Label();
            this.ActivityPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PercentageOfIdealWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityPie)).BeginInit();
            this.SuspendLayout();
            // 
            // UserComboBox
            // 
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(13, 13);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(121, 21);
            this.UserComboBox.TabIndex = 0;
            this.UserComboBox.SelectedIndexChanged += new System.EventHandler(this.UserComboBox_SelectedIndexChanged);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(140, 16);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(44, 13);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "<ИМЯ>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возвраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Рост:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Идеальный вес:";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(107, 49);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(67, 13);
            this.Age.TabIndex = 6;
            this.Age.Text = "<Возвраст>";
            // 
            // UserHeight
            // 
            this.UserHeight.AutoSize = true;
            this.UserHeight.Location = new System.Drawing.Point(107, 71);
            this.UserHeight.Name = "UserHeight";
            this.UserHeight.Size = new System.Drawing.Size(43, 13);
            this.UserHeight.TabIndex = 7;
            this.UserHeight.Text = "<Рост>";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(107, 95);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(38, 13);
            this.Weight.TabIndex = 8;
            this.Weight.Text = "<Вес>";
            // 
            // IdealWeight
            // 
            this.IdealWeight.AutoSize = true;
            this.IdealWeight.Location = new System.Drawing.Point(107, 119);
            this.IdealWeight.Name = "IdealWeight";
            this.IdealWeight.Size = new System.Drawing.Size(98, 13);
            this.IdealWeight.TabIndex = 9;
            this.IdealWeight.Text = "<Идеальный вес>";
            // 
            // MinSteps
            // 
            this.MinSteps.AutoSize = true;
            this.MinSteps.Location = new System.Drawing.Point(217, 212);
            this.MinSteps.Name = "MinSteps";
            this.MinSteps.Size = new System.Drawing.Size(39, 13);
            this.MinSteps.TabIndex = 15;
            this.MinSteps.Text = "<Пол>";
            // 
            // MaxSteps
            // 
            this.MaxSteps.AutoSize = true;
            this.MaxSteps.Location = new System.Drawing.Point(217, 188);
            this.MaxSteps.Name = "MaxSteps";
            this.MaxSteps.Size = new System.Drawing.Size(38, 13);
            this.MaxSteps.TabIndex = 14;
            this.MaxSteps.Text = "<Вес>";
            // 
            // AverageSteps
            // 
            this.AverageSteps.AutoSize = true;
            this.AverageSteps.Location = new System.Drawing.Point(217, 164);
            this.AverageSteps.Name = "AverageSteps";
            this.AverageSteps.Size = new System.Drawing.Size(43, 13);
            this.AverageSteps.TabIndex = 13;
            this.AverageSteps.Text = "<Рост>";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Минимальное кол-во шагов за день:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Максимальное кол-во шагов за день:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Среднее кол-во шагов в день:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Норма ккал в день:";
            // 
            // KkalPerDay
            // 
            this.KkalPerDay.AutoSize = true;
            this.KkalPerDay.Location = new System.Drawing.Point(215, 252);
            this.KkalPerDay.Name = "KkalPerDay";
            this.KkalPerDay.Size = new System.Drawing.Size(39, 13);
            this.KkalPerDay.TabIndex = 15;
            this.KkalPerDay.Text = "<Пол>";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Оценка активности:";
            // 
            // MarkActivity
            // 
            this.MarkActivity.AutoSize = true;
            this.MarkActivity.Location = new System.Drawing.Point(215, 279);
            this.MarkActivity.Name = "MarkActivity";
            this.MarkActivity.Size = new System.Drawing.Size(39, 13);
            this.MarkActivity.TabIndex = 15;
            this.MarkActivity.Text = "<Пол>";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Пол:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(106, 142);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(39, 13);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "<Пол>";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(294, 164);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Общее кол-во шагов:";
            // 
            // TotalSteps
            // 
            this.TotalSteps.AutoSize = true;
            this.TotalSteps.Location = new System.Drawing.Point(449, 164);
            this.TotalSteps.Name = "TotalSteps";
            this.TotalSteps.Size = new System.Drawing.Size(39, 13);
            this.TotalSteps.TabIndex = 15;
            this.TotalSteps.Text = "<Пол>";
            // 
            // ActivityPie
            // 
            chartArea3.Name = "ChartArea1";
            this.ActivityPie.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ActivityPie.Legends.Add(legend3);
            this.ActivityPie.Location = new System.Drawing.Point(297, 202);
            this.ActivityPie.Name = "ActivityPie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            dataPoint5.IsValueShownAsLabel = true;
            dataPoint5.LegendText = "Супер";
            dataPoint6.IsValueShownAsLabel = false;
            dataPoint6.Label = "";
            dataPoint6.LegendText = "Плохо";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            this.ActivityPie.Series.Add(series3);
            this.ActivityPie.Size = new System.Drawing.Size(342, 215);
            this.ActivityPie.TabIndex = 16;
            this.ActivityPie.Text = "chart1";
            // 
            // PercentageOfIdealWeight
            // 
            this.PercentageOfIdealWeight.AutoSize = true;
            this.PercentageOfIdealWeight.Location = new System.Drawing.Point(167, 95);
            this.PercentageOfIdealWeight.Name = "PercentageOfIdealWeight";
            this.PercentageOfIdealWeight.Size = new System.Drawing.Size(38, 13);
            this.PercentageOfIdealWeight.TabIndex = 8;
            this.PercentageOfIdealWeight.Text = "<Вес>";
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActivityPie);
            this.Controls.Add(this.MarkActivity);
            this.Controls.Add(this.KkalPerDay);
            this.Controls.Add(this.TotalSteps);
            this.Controls.Add(this.MinSteps);
            this.Controls.Add(this.MaxSteps);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.AverageSteps);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.IdealWeight);
            this.Controls.Add(this.PercentageOfIdealWeight);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.UserHeight);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserComboBox);
            this.Name = "AnalyzeForm";
            this.Text = "Анализ";
            ((System.ComponentModel.ISupportInitialize)(this.ActivityPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label UserHeight;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label IdealWeight;
        private System.Windows.Forms.Label MinSteps;
        private System.Windows.Forms.Label MaxSteps;
        private System.Windows.Forms.Label AverageSteps;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label KkalPerDay;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label MarkActivity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label TotalSteps;
        private System.Windows.Forms.DataVisualization.Charting.Chart ActivityPie;
        private System.Windows.Forms.Label PercentageOfIdealWeight;
    }
}
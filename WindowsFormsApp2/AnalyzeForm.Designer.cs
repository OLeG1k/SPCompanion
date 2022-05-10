
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 66D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzeForm));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Recommendations = new System.Windows.Forms.TextBox();
            this.Goal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalKcal = new System.Windows.Forms.Label();
            this.MinKcal = new System.Windows.Forms.Label();
            this.MaxKcal = new System.Windows.Forms.Label();
            this.AverageKcal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityPie)).BeginInit();
            this.SuspendLayout();
            // 
            // UserComboBox
            // 
            this.UserComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(905, 12);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(163, 32);
            this.UserComboBox.TabIndex = 0;
            this.UserComboBox.SelectedIndexChanged += new System.EventHandler(this.UserComboBox_SelectedIndexChanged);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(12, 9);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(108, 31);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "<ИМЯ>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Рост:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Идеальный вес:";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(178, 49);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(99, 20);
            this.Age.TabIndex = 6;
            this.Age.Text = "<Возвраст>";
            // 
            // UserHeight
            // 
            this.UserHeight.AutoSize = true;
            this.UserHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserHeight.Location = new System.Drawing.Point(178, 106);
            this.UserHeight.Name = "UserHeight";
            this.UserHeight.Size = new System.Drawing.Size(63, 20);
            this.UserHeight.TabIndex = 7;
            this.UserHeight.Text = "<Рост>";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(178, 139);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(55, 20);
            this.Weight.TabIndex = 8;
            this.Weight.Text = "<Вес>";
            // 
            // IdealWeight
            // 
            this.IdealWeight.AutoSize = true;
            this.IdealWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdealWeight.Location = new System.Drawing.Point(178, 172);
            this.IdealWeight.Name = "IdealWeight";
            this.IdealWeight.Size = new System.Drawing.Size(145, 20);
            this.IdealWeight.TabIndex = 9;
            this.IdealWeight.Text = "<Идеальный вес>";
            // 
            // MinSteps
            // 
            this.MinSteps.AutoSize = true;
            this.MinSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinSteps.Location = new System.Drawing.Point(318, 427);
            this.MinSteps.Name = "MinSteps";
            this.MinSteps.Size = new System.Drawing.Size(109, 20);
            this.MinSteps.TabIndex = 15;
            this.MinSteps.Text = "<Мин.шагов>";
            // 
            // MaxSteps
            // 
            this.MaxSteps.AutoSize = true;
            this.MaxSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxSteps.Location = new System.Drawing.Point(318, 398);
            this.MaxSteps.Name = "MaxSteps";
            this.MaxSteps.Size = new System.Drawing.Size(116, 20);
            this.MaxSteps.TabIndex = 14;
            this.MaxSteps.Text = "<Макс.шагов>";
            // 
            // AverageSteps
            // 
            this.AverageSteps.AutoSize = true;
            this.AverageSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageSteps.Location = new System.Drawing.Point(318, 368);
            this.AverageSteps.Name = "AverageSteps";
            this.AverageSteps.Size = new System.Drawing.Size(98, 20);
            this.AverageSteps.TabIndex = 13;
            this.AverageSteps.Text = "<Ср.шагов>";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(287, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Минимальное кол-во шагов за день:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 398);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(294, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Максимальное кол-во шагов за день:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(240, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Среднее кол-во шагов в день:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Норма ккал в день:";
            // 
            // KkalPerDay
            // 
            this.KkalPerDay.AutoSize = true;
            this.KkalPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KkalPerDay.Location = new System.Drawing.Point(178, 201);
            this.KkalPerDay.Name = "KkalPerDay";
            this.KkalPerDay.Size = new System.Drawing.Size(171, 20);
            this.KkalPerDay.TabIndex = 15;
            this.KkalPerDay.Text = "<Норма ккал в день>";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 308);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Оценка активности:";
            // 
            // MarkActivity
            // 
            this.MarkActivity.AutoSize = true;
            this.MarkActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkActivity.Location = new System.Drawing.Point(318, 308);
            this.MarkActivity.Name = "MarkActivity";
            this.MarkActivity.Size = new System.Drawing.Size(175, 20);
            this.MarkActivity.TabIndex = 15;
            this.MarkActivity.Text = "<Оценка активности>";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "Пол:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(178, 78);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(58, 20);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "<Пол>";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 335);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(170, 20);
            this.label22.TabIndex = 12;
            this.label22.Text = "Общее кол-во шагов:";
            // 
            // TotalSteps
            // 
            this.TotalSteps.AutoSize = true;
            this.TotalSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSteps.Location = new System.Drawing.Point(318, 335);
            this.TotalSteps.Name = "TotalSteps";
            this.TotalSteps.Size = new System.Drawing.Size(120, 20);
            this.TotalSteps.TabIndex = 15;
            this.TotalSteps.Text = "<всего шагов>";
            // 
            // ActivityPie
            // 
            this.ActivityPie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ActivityPie.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ActivityPie.Legends.Add(legend1);
            this.ActivityPie.Location = new System.Drawing.Point(576, 308);
            this.ActivityPie.Name = "ActivityPie";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.IsValueShownAsLabel = true;
            dataPoint1.LegendText = "Супер";
            dataPoint2.IsValueShownAsLabel = false;
            dataPoint2.Label = "";
            dataPoint2.LegendText = "Плохо";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.ActivityPie.Series.Add(series1);
            this.ActivityPie.Size = new System.Drawing.Size(479, 479);
            this.ActivityPie.TabIndex = 16;
            this.ActivityPie.Text = "chart1";
            // 
            // PercentageOfIdealWeight
            // 
            this.PercentageOfIdealWeight.AutoSize = true;
            this.PercentageOfIdealWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageOfIdealWeight.Location = new System.Drawing.Point(241, 139);
            this.PercentageOfIdealWeight.Name = "PercentageOfIdealWeight";
            this.PercentageOfIdealWeight.Size = new System.Drawing.Size(77, 20);
            this.PercentageOfIdealWeight.TabIndex = 8;
            this.PercentageOfIdealWeight.Text = "<Вес, %>";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Активность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(175, 580);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Рекомендации:";
            // 
            // Recommendations
            // 
            this.Recommendations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Recommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Recommendations.Location = new System.Drawing.Point(16, 616);
            this.Recommendations.Multiline = true;
            this.Recommendations.Name = "Recommendations";
            this.Recommendations.ReadOnly = true;
            this.Recommendations.Size = new System.Drawing.Size(477, 171);
            this.Recommendations.TabIndex = 19;
            this.Recommendations.Text = resources.GetString("Recommendations.Text");
            // 
            // Goal
            // 
            this.Goal.AutoSize = true;
            this.Goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goal.Location = new System.Drawing.Point(178, 233);
            this.Goal.Name = "Goal";
            this.Goal.Size = new System.Drawing.Size(67, 20);
            this.Goal.TabIndex = 21;
            this.Goal.Text = "<Цель>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Цель:";
            // 
            // TotalKcal
            // 
            this.TotalKcal.AutoSize = true;
            this.TotalKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalKcal.Location = new System.Drawing.Point(318, 457);
            this.TotalKcal.Name = "TotalKcal";
            this.TotalKcal.Size = new System.Drawing.Size(62, 20);
            this.TotalKcal.TabIndex = 28;
            this.TotalKcal.Text = "<ккал>";
            // 
            // MinKcal
            // 
            this.MinKcal.AutoSize = true;
            this.MinKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinKcal.Location = new System.Drawing.Point(318, 549);
            this.MinKcal.Name = "MinKcal";
            this.MinKcal.Size = new System.Drawing.Size(97, 20);
            this.MinKcal.TabIndex = 29;
            this.MinKcal.Text = "<Мин.ккал>";
            // 
            // MaxKcal
            // 
            this.MaxKcal.AutoSize = true;
            this.MaxKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxKcal.Location = new System.Drawing.Point(318, 520);
            this.MaxKcal.Name = "MaxKcal";
            this.MaxKcal.Size = new System.Drawing.Size(104, 20);
            this.MaxKcal.TabIndex = 27;
            this.MaxKcal.Text = "<Макс.ккал>";
            // 
            // AverageKcal
            // 
            this.AverageKcal.AutoSize = true;
            this.AverageKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageKcal.Location = new System.Drawing.Point(318, 490);
            this.AverageKcal.Name = "AverageKcal";
            this.AverageKcal.Size = new System.Drawing.Size(88, 20);
            this.AverageKcal.TabIndex = 26;
            this.AverageKcal.Text = "<Ср.Ккал>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Общее кол-во потраченных ккал:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 549);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(275, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "Минимальное кол-во ккал за день:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 520);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(282, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Максимальное кол-во ккал за день:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 490);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(228, 20);
            this.label21.TabIndex = 22;
            this.label21.Text = "Среднее кол-во ккал в день:";
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 805);
            this.Controls.Add(this.TotalKcal);
            this.Controls.Add(this.MinKcal);
            this.Controls.Add(this.MaxKcal);
            this.Controls.Add(this.AverageKcal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Goal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Recommendations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Recommendations;
        private System.Windows.Forms.Label Goal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TotalKcal;
        private System.Windows.Forms.Label MinKcal;
        private System.Windows.Forms.Label MaxKcal;
        private System.Windows.Forms.Label AverageKcal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
    }
}
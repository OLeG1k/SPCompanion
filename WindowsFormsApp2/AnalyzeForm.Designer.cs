
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
            ((System.ComponentModel.ISupportInitialize)(this.ActivityPie)).BeginInit();
            this.SuspendLayout();
            // 
            // UserComboBox
            // 
            this.UserComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(691, 12);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(163, 32);
            this.UserComboBox.TabIndex = 0;
            this.UserComboBox.SelectedIndexChanged += new System.EventHandler(this.UserComboBox_SelectedIndexChanged);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(12, 9);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(111, 32);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "<ИМЯ>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возвраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Рост:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Идеальный вес:";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(178, 49);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(89, 18);
            this.Age.TabIndex = 6;
            this.Age.Text = "<Возвраст>";
            // 
            // UserHeight
            // 
            this.UserHeight.AutoSize = true;
            this.UserHeight.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserHeight.Location = new System.Drawing.Point(178, 106);
            this.UserHeight.Name = "UserHeight";
            this.UserHeight.Size = new System.Drawing.Size(59, 18);
            this.UserHeight.TabIndex = 7;
            this.UserHeight.Text = "<Рост>";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(178, 139);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(52, 18);
            this.Weight.TabIndex = 8;
            this.Weight.Text = "<Вес>";
            // 
            // IdealWeight
            // 
            this.IdealWeight.AutoSize = true;
            this.IdealWeight.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdealWeight.Location = new System.Drawing.Point(178, 172);
            this.IdealWeight.Name = "IdealWeight";
            this.IdealWeight.Size = new System.Drawing.Size(130, 18);
            this.IdealWeight.TabIndex = 9;
            this.IdealWeight.Text = "<Идеальный вес>";
            // 
            // MinSteps
            // 
            this.MinSteps.AutoSize = true;
            this.MinSteps.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinSteps.Location = new System.Drawing.Point(289, 366);
            this.MinSteps.Name = "MinSteps";
            this.MinSteps.Size = new System.Drawing.Size(54, 18);
            this.MinSteps.TabIndex = 15;
            this.MinSteps.Text = "<Пол>";
            // 
            // MaxSteps
            // 
            this.MaxSteps.AutoSize = true;
            this.MaxSteps.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxSteps.Location = new System.Drawing.Point(289, 342);
            this.MaxSteps.Name = "MaxSteps";
            this.MaxSteps.Size = new System.Drawing.Size(52, 18);
            this.MaxSteps.TabIndex = 14;
            this.MaxSteps.Text = "<Вес>";
            // 
            // AverageSteps
            // 
            this.AverageSteps.AutoSize = true;
            this.AverageSteps.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageSteps.Location = new System.Drawing.Point(289, 318);
            this.AverageSteps.Name = "AverageSteps";
            this.AverageSteps.Size = new System.Drawing.Size(59, 18);
            this.AverageSteps.TabIndex = 13;
            this.AverageSteps.Text = "<Рост>";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Минимальное кол-во шагов за день:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(258, 18);
            this.label14.TabIndex = 11;
            this.label14.Text = "Максимальное кол-во шагов за день:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 18);
            this.label15.TabIndex = 10;
            this.label15.Text = "Среднее кол-во шагов в день:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 18);
            this.label16.TabIndex = 12;
            this.label16.Text = "Норма ккал в день:";
            // 
            // KkalPerDay
            // 
            this.KkalPerDay.AutoSize = true;
            this.KkalPerDay.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KkalPerDay.Location = new System.Drawing.Point(178, 201);
            this.KkalPerDay.Name = "KkalPerDay";
            this.KkalPerDay.Size = new System.Drawing.Size(154, 18);
            this.KkalPerDay.TabIndex = 15;
            this.KkalPerDay.Text = "<Норма ккал в день>";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 262);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 18);
            this.label18.TabIndex = 12;
            this.label18.Text = "Оценка активности:";
            // 
            // MarkActivity
            // 
            this.MarkActivity.AutoSize = true;
            this.MarkActivity.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkActivity.Location = new System.Drawing.Point(289, 262);
            this.MarkActivity.Name = "MarkActivity";
            this.MarkActivity.Size = new System.Drawing.Size(158, 18);
            this.MarkActivity.TabIndex = 15;
            this.MarkActivity.Text = "<Оценка активности>";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 18);
            this.label20.TabIndex = 5;
            this.label20.Text = "Пол:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(178, 78);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(54, 18);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "<Пол>";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(15, 289);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(151, 18);
            this.label22.TabIndex = 12;
            this.label22.Text = "Общее кол-во шагов:";
            // 
            // TotalSteps
            // 
            this.TotalSteps.AutoSize = true;
            this.TotalSteps.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSteps.Location = new System.Drawing.Point(289, 289);
            this.TotalSteps.Name = "TotalSteps";
            this.TotalSteps.Size = new System.Drawing.Size(54, 18);
            this.TotalSteps.TabIndex = 15;
            this.TotalSteps.Text = "<Пол>";
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
            this.ActivityPie.Location = new System.Drawing.Point(499, 262);
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
            this.ActivityPie.Size = new System.Drawing.Size(342, 215);
            this.ActivityPie.TabIndex = 16;
            this.ActivityPie.Text = "chart1";
            // 
            // PercentageOfIdealWeight
            // 
            this.PercentageOfIdealWeight.AutoSize = true;
            this.PercentageOfIdealWeight.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageOfIdealWeight.Location = new System.Drawing.Point(241, 139);
            this.PercentageOfIdealWeight.Name = "PercentageOfIdealWeight";
            this.PercentageOfIdealWeight.Size = new System.Drawing.Size(71, 18);
            this.PercentageOfIdealWeight.TabIndex = 8;
            this.PercentageOfIdealWeight.Text = "<Вес, %>";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Активность";
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 495);
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
    }
}
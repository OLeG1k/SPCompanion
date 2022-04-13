
namespace WindowsFormsApp2
{
    partial class AddChartDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChartDialog));
            this.AddChartButton = new System.Windows.Forms.Button();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ChartPictureBox = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddChartButton
            // 
            this.AddChartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddChartButton.BackColor = System.Drawing.Color.White;
            this.AddChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddChartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddChartButton.Location = new System.Drawing.Point(12, 450);
            this.AddChartButton.Name = "AddChartButton";
            this.AddChartButton.Size = new System.Drawing.Size(147, 37);
            this.AddChartButton.TabIndex = 0;
            this.AddChartButton.Text = "Добавить";
            this.AddChartButton.UseVisualStyleBackColor = false;
            this.AddChartButton.Click += new System.EventHandler(this.AddChartButton_Click);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeColorButton.BackColor = System.Drawing.Color.White;
            this.ChangeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeColorButton.Location = new System.Drawing.Point(131, 391);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(120, 36);
            this.ChangeColorButton.TabIndex = 1;
            this.ChangeColorButton.Text = "Изменить";
            this.ChangeColorButton.UseVisualStyleBackColor = false;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(12, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(239, 29);
            this.NameTextBox.TabIndex = 3;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AgeTextBox.Location = new System.Drawing.Point(12, 179);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(239, 29);
            this.AgeTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(8, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Возраст";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.HeightTextBox.Location = new System.Drawing.Point(12, 249);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(239, 29);
            this.HeightTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(8, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Рост";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.WeightTextBox.Location = new System.Drawing.Point(12, 318);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(239, 29);
            this.WeightTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(8, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(8, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цвет";
            // 
            // ChartPictureBox
            // 
            this.ChartPictureBox.Location = new System.Drawing.Point(12, 391);
            this.ChartPictureBox.Name = "ChartPictureBox";
            this.ChartPictureBox.Size = new System.Drawing.Size(113, 36);
            this.ChartPictureBox.TabIndex = 12;
            this.ChartPictureBox.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.Coral;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(161, 450);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 37);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(12, 107);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(239, 32);
            this.GenderComboBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(8, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Пол";
            // 
            // AddChartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 499);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ChartPictureBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeColorButton);
            this.Controls.Add(this.AddChartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddChartDialog";
            this.Text = "Импорт данных";
            ((System.ComponentModel.ISupportInitialize)(this.ChartPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddChartButton;
        private System.Windows.Forms.Button ChangeColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox ChartPictureBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label label6;
    }
}
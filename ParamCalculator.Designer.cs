namespace ParamCalculator
{
    partial class ParamCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MaxNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameCharacterTextBox = new System.Windows.Forms.TextBox();
            this.ScreenNumberLabel = new System.Windows.Forms.Label();
            this.MaxNumberTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.DifferenceNumberTextBox = new System.Windows.Forms.TextBox();
            this.TakeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RunTimerButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // MaxNumberLabel
            // 
            this.MaxNumberLabel.AutoSize = true;
            this.MaxNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaxNumberLabel.Location = new System.Drawing.Point(12, 95);
            this.MaxNumberLabel.Name = "MaxNumberLabel";
            this.MaxNumberLabel.Size = new System.Drawing.Size(95, 20);
            this.MaxNumberLabel.TabIndex = 1;
            this.MaxNumberLabel.Text = "Макс. число:";
            this.MaxNumberLabel.Click += new System.EventHandler(this.MaxNumberLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сколько добавлять:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(250, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Через сколько (в секундах):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сколько отнять/прибавить:";
            // 
            // NameCharacterTextBox
            // 
            this.NameCharacterTextBox.Location = new System.Drawing.Point(12, 55);
            this.NameCharacterTextBox.Name = "NameCharacterTextBox";
            this.NameCharacterTextBox.Size = new System.Drawing.Size(152, 27);
            this.NameCharacterTextBox.TabIndex = 5;
            // 
            // ScreenNumberLabel
            // 
            this.ScreenNumberLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScreenNumberLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScreenNumberLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.ScreenNumberLabel.Location = new System.Drawing.Point(183, 33);
            this.ScreenNumberLabel.Name = "ScreenNumberLabel";
            this.ScreenNumberLabel.Size = new System.Drawing.Size(287, 113);
            this.ScreenNumberLabel.TabIndex = 6;
            this.ScreenNumberLabel.Text = "0";
            this.ScreenNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxNumberTextBox
            // 
            this.MaxNumberTextBox.Location = new System.Drawing.Point(12, 118);
            this.MaxNumberTextBox.Name = "MaxNumberTextBox";
            this.MaxNumberTextBox.Size = new System.Drawing.Size(152, 27);
            this.MaxNumberTextBox.TabIndex = 7;
            this.MaxNumberTextBox.TextChanged += new System.EventHandler(this.MaxNumberTextBox_TextChanged);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(12, 189);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(220, 27);
            this.NumberTextBox.TabIndex = 9;
            this.NumberTextBox.TextChanged += new System.EventHandler(this.NumberTextBox_TextChanged);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(250, 189);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(220, 27);
            this.TimeTextBox.TabIndex = 10;
            this.TimeTextBox.TextChanged += new System.EventHandler(this.TimeTextBox_TextChanged);
            // 
            // DifferenceNumberTextBox
            // 
            this.DifferenceNumberTextBox.Location = new System.Drawing.Point(12, 254);
            this.DifferenceNumberTextBox.Name = "DifferenceNumberTextBox";
            this.DifferenceNumberTextBox.Size = new System.Drawing.Size(220, 27);
            this.DifferenceNumberTextBox.TabIndex = 11;
            // 
            // TakeButton
            // 
            this.TakeButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.TakeButton.Location = new System.Drawing.Point(250, 252);
            this.TakeButton.Name = "TakeButton";
            this.TakeButton.Size = new System.Drawing.Size(104, 29);
            this.TakeButton.TabIndex = 12;
            this.TakeButton.Text = "Отнять";
            this.TakeButton.UseVisualStyleBackColor = true;
            this.TakeButton.Click += new System.EventHandler(this.TakeButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddButton.Location = new System.Drawing.Point(366, 252);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 29);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RunTimerButton
            // 
            this.RunTimerButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.RunTimerButton.Location = new System.Drawing.Point(12, 335);
            this.RunTimerButton.Name = "RunTimerButton";
            this.RunTimerButton.Size = new System.Drawing.Size(458, 29);
            this.RunTimerButton.TabIndex = 14;
            this.RunTimerButton.Text = "Запуск и выключение таймера";
            this.RunTimerButton.UseVisualStyleBackColor = true;
            this.RunTimerButton.Click += new System.EventHandler(this.RunTimerButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Статус таймера: выключен";
            // 
            // ParamCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(482, 383);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RunTimerButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TakeButton);
            this.Controls.Add(this.DifferenceNumberTextBox);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.ScreenNumberLabel);
            this.Controls.Add(this.MaxNumberTextBox);
            this.Controls.Add(this.NameCharacterTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxNumberLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 430);
            this.MinimumSize = new System.Drawing.Size(500, 430);
            this.Name = "ParamCalculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParamCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label MaxNumberLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameCharacterTextBox;
        private Label ScreenNumberLabel;
        private TextBox MaxNumberTextBox;
        private TextBox NumberTextBox;
        private TextBox TimeTextBox;
        private TextBox DifferenceNumberTextBox;
        private Button TakeButton;
        private Button AddButton;
        private Button RunTimerButton;
        private Label label6;
    }
}
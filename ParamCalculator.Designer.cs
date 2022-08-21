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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameCharacter = new System.Windows.Forms.TextBox();
            this.Экранчик = new System.Windows.Forms.Label();
            this.MaxNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Take = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Макс. число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сколько";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Во сколько";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сколько отнять/прибавить";
            // 
            // NameCharacter
            // 
            this.NameCharacter.Location = new System.Drawing.Point(12, 55);
            this.NameCharacter.Name = "NameCharacter";
            this.NameCharacter.Size = new System.Drawing.Size(152, 27);
            this.NameCharacter.TabIndex = 5;
            this.NameCharacter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Экранчик
            // 
            this.Экранчик.AutoSize = true;
            this.Экранчик.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Экранчик.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Экранчик.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Экранчик.Location = new System.Drawing.Point(192, 55);
            this.Экранчик.Name = "Экранчик";
            this.Экранчик.Size = new System.Drawing.Size(269, 72);
            this.Экранчик.TabIndex = 6;
            this.Экранчик.Text = "Экранчик";
            this.Экранчик.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxNumber
            // 
            this.MaxNumber.Location = new System.Drawing.Point(12, 118);
            this.MaxNumber.Name = "MaxNumber";
            this.MaxNumber.Size = new System.Drawing.Size(152, 27);
            this.MaxNumber.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(183, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 113);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(12, 189);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(220, 27);
            this.Number.TabIndex = 9;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(250, 189);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(220, 27);
            this.Time.TabIndex = 10;
            this.Time.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 254);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(220, 27);
            this.textBox5.TabIndex = 11;
            // 
            // Take
            // 
            this.Take.Location = new System.Drawing.Point(250, 252);
            this.Take.Name = "Take";
            this.Take.Size = new System.Drawing.Size(104, 29);
            this.Take.TabIndex = 12;
            this.Take.Text = "Отнять";
            this.Take.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(366, 252);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(104, 29);
            this.Add.TabIndex = 13;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // ParamCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Take);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Экранчик);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MaxNumber);
            this.Controls.Add(this.NameCharacter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "ParamCalculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParamCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameCharacter;
        private Label Экранчик;
        private TextBox MaxNumber;
        private PictureBox pictureBox1;
        private TextBox Number;
        private TextBox Time;
        private TextBox textBox5;
        private Button Take;
        private Button Add;
    }
}
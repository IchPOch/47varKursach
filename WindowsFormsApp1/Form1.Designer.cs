namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2bit = new System.Windows.Forms.RadioButton();
            this.radioButton4bit = new System.Windows.Forms.RadioButton();
            this.radioButton6bit = new System.Windows.Forms.RadioButton();
            this.textBoxVvod = new System.Windows.Forms.TextBox();
            this.textBoxVivod = new System.Windows.Forms.TextBox();
            this.ChartR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonx = new System.Windows.Forms.Button();
            this.buttony = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.colorx = new System.Windows.Forms.ColorDialog();
            this.colory = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ChartR)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Перевести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton2bit
            // 
            this.radioButton2bit.AutoSize = true;
            this.radioButton2bit.Checked = true;
            this.radioButton2bit.Location = new System.Drawing.Point(13, 19);
            this.radioButton2bit.Name = "radioButton2bit";
            this.radioButton2bit.Size = new System.Drawing.Size(42, 17);
            this.radioButton2bit.TabIndex = 1;
            this.radioButton2bit.TabStop = true;
            this.radioButton2bit.Text = "2bit";
            this.radioButton2bit.UseVisualStyleBackColor = true;
            this.radioButton2bit.Click += new System.EventHandler(this.radioButton2bit_Click);
            // 
            // radioButton4bit
            // 
            this.radioButton4bit.AutoSize = true;
            this.radioButton4bit.Location = new System.Drawing.Point(13, 42);
            this.radioButton4bit.Name = "radioButton4bit";
            this.radioButton4bit.Size = new System.Drawing.Size(42, 17);
            this.radioButton4bit.TabIndex = 2;
            this.radioButton4bit.Text = "4bit";
            this.radioButton4bit.UseVisualStyleBackColor = true;
            this.radioButton4bit.Click += new System.EventHandler(this.radioButton4bit_Click);
            // 
            // radioButton6bit
            // 
            this.radioButton6bit.AutoSize = true;
            this.radioButton6bit.Location = new System.Drawing.Point(13, 65);
            this.radioButton6bit.Name = "radioButton6bit";
            this.radioButton6bit.Size = new System.Drawing.Size(42, 17);
            this.radioButton6bit.TabIndex = 3;
            this.radioButton6bit.Text = "6bit";
            this.radioButton6bit.UseVisualStyleBackColor = true;
            this.radioButton6bit.Click += new System.EventHandler(this.radioButton6bit_Click);
            // 
            // textBoxVvod
            // 
            this.textBoxVvod.Location = new System.Drawing.Point(6, 38);
            this.textBoxVvod.Name = "textBoxVvod";
            this.textBoxVvod.Size = new System.Drawing.Size(206, 20);
            this.textBoxVvod.TabIndex = 4;
            // 
            // textBoxVivod
            // 
            this.textBoxVivod.Location = new System.Drawing.Point(6, 61);
            this.textBoxVivod.Name = "textBoxVivod";
            this.textBoxVivod.ReadOnly = true;
            this.textBoxVivod.Size = new System.Drawing.Size(206, 20);
            this.textBoxVivod.TabIndex = 5;
            // 
            // ChartR
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartR.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartR.Legends.Add(legend3);
            this.ChartR.Location = new System.Drawing.Point(6, 6);
            this.ChartR.Name = "ChartR";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartR.Series.Add(series3);
            this.ChartR.Size = new System.Drawing.Size(1174, 576);
            this.ChartR.TabIndex = 6;
            this.ChartR.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1194, 614);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBoxVvod);
            this.tabPage1.Controls.Add(this.textBoxVivod);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1186, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonx
            // 
            this.buttonx.Location = new System.Drawing.Point(6, 19);
            this.buttonx.Name = "buttonx";
            this.buttonx.Size = new System.Drawing.Size(171, 23);
            this.buttonx.TabIndex = 7;
            this.buttonx.Text = "Изменить цвет оси x";
            this.buttonx.UseVisualStyleBackColor = true;
            this.buttonx.Click += new System.EventHandler(this.buttonx_Click);
            // 
            // buttony
            // 
            this.buttony.Location = new System.Drawing.Point(6, 48);
            this.buttony.Name = "buttony";
            this.buttony.Size = new System.Drawing.Size(171, 23);
            this.buttony.TabIndex = 6;
            this.buttony.Text = "Изменить цвет оси y";
            this.buttony.UseVisualStyleBackColor = true;
            this.buttony.Click += new System.EventHandler(this.buttony_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChartR);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1186, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите 8бит сообщение из едениц и нулей";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(183, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Деления изнутри";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(183, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Деления внутри";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(183, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(134, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "Деления пересекают";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2bit);
            this.groupBox1.Controls.Add(this.radioButton6bit);
            this.groupBox1.Controls.Add(this.radioButton4bit);
            this.groupBox1.Location = new System.Drawing.Point(6, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 159);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "На какое переводить ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.buttonx);
            this.groupBox2.Controls.Add(this.buttony);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(242, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 152);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Формат Гистограммы";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(183, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(90, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.Text = "Делений нет";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 638);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChartR)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2bit;
        private System.Windows.Forms.RadioButton radioButton4bit;
        private System.Windows.Forms.RadioButton radioButton6bit;
        private System.Windows.Forms.TextBox textBoxVvod;
        private System.Windows.Forms.TextBox textBoxVivod;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartR;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColorDialog colorx;
        private System.Windows.Forms.Button buttonx;
        private System.Windows.Forms.Button buttony;
        private System.Windows.Forms.ColorDialog colory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


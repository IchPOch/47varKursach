using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int bit;
        private List<string> load = new List<string>();
        public int[,] Perenos(string s) {
            int c = 0;
            if (s.Length % bit == 0)
            {
                int[,] B = new int[s.Length / bit, bit];
                c = 0;
                for (int i = 0; i < (s.Length / bit); i++)
                {
                    for (int j = 0; j < bit; j++)
                    {
                        if (s[c] == 48) B[i, j] = 0;
                        else B[i, j] = 1;
                        c++;
                    }
                }
                for (int i = 0; i < s.Length / bit; i++)
                {
                    textBoxVivod.Text += " ";
                    for (int j = 0; j < bit; j++)
                    {
                        textBoxVivod.Text += "" + B[i, j];
                    }
                }
                return B;
            }
            else
            {
                int[,] B = new int[s.Length / bit + 1, bit];
                c = 0;
                for (int i = 0; i < (s.Length / bit); i++)
                {
                    for (int j = 0; j < bit; j++)
                    {
                        if (s[c] == 48) B[i, j] = 0;
                        else B[i, j] = 1;
                        c++;
                    }
                }
                int ost = bit - (s.Length % bit);
                for (int j = 0; j < bit; j++)
                {
                    if (ost > j)
                    {
                        B[(s.Length / bit), j] = 0;
                    }
                    else
                    {
                        if (s[c] == 48) { B[(s.Length / bit), j] = 0; }
                        else { B[(s.Length / bit), j] = 1; }
                        c++;
                    }
                }

                for (int i = 0; i < s.Length / bit + 1; i++)
                {
                    textBoxVivod.Text += " ";
                    for (int j = 0; j < bit; j++)
                    {
                        textBoxVivod.Text += "" + B[i, j];
                    }
                }
                return B;
            }
        }
        public Form1()
        {
            InitializeComponent();
            bit = 2;
            string save = @"save.log";
            try
            {
                using (StreamReader file1 = new StreamReader(save))
                {
                    string line;
                    while ((line = file1.ReadLine()) != null)
                    {
                        line = line.Replace("Color", "");
                        line = line.Replace("[", "");
                        line = line.Replace("]", "");
                        line = line.Replace(" ", "");
                        load.Add(line);
                    }
                    if (load[0] == "2") { radioButton2bit.Checked = true; bit = 2; }
                    if (load[0] == "4") { radioButton4bit.Checked = true; bit = 4; }
                    if (load[0] == "6") { radioButton6bit.Checked = true; bit = 6; }
                    colorx.Color = Color.FromName(load[1]);
                    colory.Color = Color.FromName(load[2]);
                    if (load[3] == "1") { radioButton1.Checked = true; }
                    if (load[3] == "2") { radioButton2.Checked = true; }
                    if (load[3] == "3") { radioButton3.Checked = true; }
                    if (load[3] == "4") { radioButton4.Checked = true; }

                }
            }
            catch { }
        }

        private void radioButton2bit_Click(object sender, EventArgs e)
        {
            bit = 2;
        }

        private void radioButton4bit_Click(object sender, EventArgs e)
        {
            bit = 4;
        }

        private void radioButton6bit_Click(object sender, EventArgs e)
        {
            bit = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string save = @"save.log";
                string protocol = @"protocol.log";
                textBoxVivod.Text = "";
                string s = textBoxVvod.Text;
                s = s.Replace(" ", "");
                for(int i = 0; i < s.Length;i++)
                {
                    if (s[i] != 48 && s[i] != 49) { throw new FormatException(""); }
                }
                int[,] A = new int[s.Length / 8, 8];
                int c = 0;
                for (int i = 0; i < s.Length / 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (s[c] == 48) A[i, j] = 0;
                        else A[i, j] = 1;

                        c++;
                    }
                }

                int[,] B = Perenos(s);
                using (StreamWriter file1 = new StreamWriter(protocol, true))
                {
                    string perevod = "Перевод 8бит кода в " + bit.ToString() + "бит: ";
                    file1.WriteLine("");
                    file1.WriteLine(perevod);

                    for (int i = 0; i < A.GetLength(0); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                        {
                            file1.Write(A[i, j].ToString());
                        }
                        file1.Write(" ");
                    }
                    file1.Write(" ---> ");
                    for (int i = 0; i < B.GetLength(0); i++)
                    {
                        for (int j = 0; j < B.GetLength(1); j++)
                        {
                            file1.Write(B[i, j].ToString());
                        }
                        file1.Write(" ");
                    }
                }
                int[] C = new int[B.GetLength(0)];
                int chislo = 0;
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < bit; j++)
                    {
                        chislo += B[i, j] * Convert.ToInt32((Math.Pow(bit, bit - j - 1)));
                    }
                    C[i] = chislo;
                    chislo = 0;
                }
                ChartR.Series.Clear();
                ChartR.Legends.Clear();
                ChartR.ChartAreas[0].AxisY.Interval = 100;
                ChartR.ChartAreas[0].AxisX.Interval = 1;
                ChartR.ChartAreas[0].AxisX.LineColor = colorx.Color;
                ChartR.ChartAreas[0].AxisY.LineColor = colory.Color;
                ChartR.ChartAreas[0].AxisX.LineWidth = 1;
                //ChartR.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0,}K";
                ChartR.ChartAreas[0].AxisY2.Enabled = AxisEnabled.False;
                //ChartR.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
                //ChartR.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
                if (radioButton1.Checked)
                {
                    ChartR.ChartAreas[0].AxisX.MajorTickMark.TickMarkStyle = TickMarkStyle.OutsideArea;
                    ChartR.ChartAreas[0].AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.OutsideArea;
                }
                if (radioButton2.Checked)
                {
                    ChartR.ChartAreas[0].AxisX.MajorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
                    ChartR.ChartAreas[0].AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
                }
                if (radioButton3.Checked)
                {
                    ChartR.ChartAreas[0].AxisX.MajorTickMark.TickMarkStyle = TickMarkStyle.AcrossAxis;
                    ChartR.ChartAreas[0].AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.AcrossAxis;
                }
                if (radioButton4.Checked)
                {
                    ChartR.ChartAreas[0].AxisX.MajorTickMark.TickMarkStyle = TickMarkStyle.None;
                    ChartR.ChartAreas[0].AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.None;
                }
                TickMark TM = new TickMark();
                TM.TickMarkStyle = (TickMarkStyle)0;
                var dataPointSeries = new Series
                {
                    Name = "Series 1",
                    Color = Color.Red,
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column
                };

                for (int i = 0; i < B.GetLength(0); i++)
                {
                    dataPointSeries.Points.AddXY(i, C[i]);
                }

                ChartR.Series.Add(dataPointSeries);
                using (StreamWriter file1 = new StreamWriter(save))
                {
                    if (radioButton2bit.Checked) { file1.WriteLine("2"); }
                    if (radioButton4bit.Checked) { file1.WriteLine("4"); }
                    if (radioButton6bit.Checked) { file1.WriteLine("6"); }
                    if(colorx.Color != null) { file1.WriteLine(colorx.Color.ToString()); }
                    if(colory.Color != null) { file1.WriteLine(colory.Color.ToString()); }
                    if (radioButton1.Checked) { file1.WriteLine("1"); }
                    if (radioButton2.Checked) { file1.WriteLine("2"); }
                    if(radioButton3.Checked) { file1.WriteLine("3"); }
                    if (radioButton4.Checked) { file1.WriteLine("4"); }
                }
            }
            catch (FormatException) 
            {
                MessageBox.Show("Неверный ввод данных");
            }
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            ColorDialog diag = new ColorDialog();
            diag.ShowDialog();
            colorx.Color = diag.Color;
        }

        private void buttony_Click(object sender, EventArgs e)
        {
            ColorDialog diag = new ColorDialog();
            diag.ShowDialog();
            colory.Color = diag.Color;
        }
    }
}

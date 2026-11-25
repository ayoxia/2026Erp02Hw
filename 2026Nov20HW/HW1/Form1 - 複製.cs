using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class Form1 : Form
    {
        string equal = " = ";

        public Form1()
        {
            InitializeComponent();
        }

        #region HW1
        private void btn_HW1_Sum_Click(object sender, EventArgs e)
        {
            HW1 HW1 = new HW1();

            var input1 = 0;
            var input2 = 0;
            var input3 = Int16.MinValue;
            var Hw1_SumResult = 0;

            try
            {
                input1 = Convert.ToInt32(txb_HW1_data1.Text);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                input2 = int.Parse(txb_HW1_data2.Text);
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                uint.TryParse(txb_HW1_data3.Text, out uint value3);
                input3 = (Int16)value3;
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW1.Hw1(input1, input2, input3, ref Hw1_SumResult) == false)
            {

            }
            else
            {
                var Outstr = input1.ToString() + " + " + input2.ToString() + " + " + input3.ToString() + equal + Hw1_SumResult.ToString();

                rtb_Result.Text = Outstr;

                //lab_HW1_Sum.Text += equal + sum.ToString();
            }
        }
        #endregion HW1

        #region HW2
        private void btn_HW2_Perimeter_Click(object sender, EventArgs e)
        {
            HW2 HW2 = new HW2();

            var Radius = 0d;

            var Hw2_PerimeterResult = 0d;

            try
            {
                Radius = Convert.ToDouble(txb_HW2_Radius.Text);
            }
            catch (Exception ex21)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW2.Perimeter(Radius, ref Hw2_PerimeterResult) == false)
            {

            }
            else
            {
                var Outstr = "Radius" + equal + Radius.ToString() + ", " + "Perimeter" + equal + Hw2_PerimeterResult.ToString();

                rtb_Result.Text = Outstr;
            }

        }

        private void btn_HW2_Area_Click(object sender, EventArgs e)
        {
            HW2 HW2 = new HW2();

            var Radius = 0d;

            var Hw2_AreaResult = 0d;

            try
            {
                Radius = Convert.ToDouble(txb_HW2_Radius.Text);
            }
            catch (Exception ex22)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW2.Area(Radius, ref Hw2_AreaResult) == false)
            {

            }
            else
            {
                var Outstr = "Radius" + equal + Radius.ToString() + ", " + "Area" + equal + Hw2_AreaResult.ToString();

                rtb_Result.Text = Outstr;
            }
        }

        private void btn_HW2_Volume_Click(object sender, EventArgs e)
        {
            HW2 HW2 = new HW2();

            var Radius = 0d;

            var Hw3_VolumeResult = 0d;

            try
            {
                Radius = Convert.ToDouble(txb_HW2_Radius.Text);
            }
            catch (Exception ex23)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW2.Volume(Radius, ref Hw3_VolumeResult) == false)
            {

            }
            else
            {
                var Outstr = "Radius" + equal + Radius.ToString() + ", " + "Volume" + equal + Hw3_VolumeResult.ToString();

                rtb_Result.Text = Outstr;
            }
        }
        #endregion HW2

        #region HW3
        private void btn_HW3_Perimeter_Click(object sender, EventArgs e)
        {
            HW3 HW3 = new HW3();

            var Length = 0d;

            var Width = 0d;

            var Hw3_PerimeterResult = 0d;

            try
            {
                Length = Convert.ToDouble(txb_HW3_Length.Text);
            }
            catch (Exception ex31)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                Width = Convert.ToDouble(txb_HW3_Width.Text);
            }
            catch (Exception ex32)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW3.Perimeter(Length, Width, ref Hw3_PerimeterResult) == false)
            {

            }
            else
            {
                var Outstr = "Length" + equal + Length.ToString() + ", " + "Width" + equal + Width.ToString() + ", " + "Perimeter" + equal + Hw3_PerimeterResult.ToString();

                rtb_Result.Text = Outstr;
            }
        }

        private void btn_HW3_Area_Click(object sender, EventArgs e)
        {
            HW3 HW3 = new HW3();

            var Length = 0d;

            var Width = 0d;

            var Hw3_AreaResult = 0d;

            try
            {
                Length = Convert.ToDouble(txb_HW3_Length.Text);
            }
            catch (Exception ex31)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                Width = Convert.ToDouble(txb_HW3_Width.Text);
            }
            catch (Exception ex32)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW3.Area(Length, Width, ref Hw3_AreaResult) == false)
            {

            }
            else
            {
                var Outstr = "Length" + equal + Length.ToString() + ", " + "Width" + equal + Width.ToString() + ", " + "Area" + equal + Hw3_AreaResult.ToString();

                rtb_Result.Text = Outstr;
            }
        }
        #endregion HW3

        #region HW4
        private void btn_HW4_Area_Click(object sender, EventArgs e)
        {
            HW4 HW4 = new HW4();

            var TopBase = 0d;

            var BottonBase = 0d;

            var Height = 0d;

            var Hw4_AreaResult = 0d;

            try
            {
                TopBase = Convert.ToDouble(txb_HW4_TopBase.Text);
            }
            catch (Exception ex41)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                BottonBase = Convert.ToDouble(txb_HW4_BottomBase.Text);
            }
            catch (Exception ex32)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                Height = Convert.ToDouble(txb_HW4_Height.Text);
            }
            catch (Exception ex32)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW4.Area(TopBase, BottonBase, Height, ref Hw4_AreaResult) == false)
            {

            }
            else
            {
                var Outstr = "TopBase" + equal + TopBase.ToString() + ", " + "BottonBase" + equal + BottonBase.ToString() + ", " + "Height" + equal + Height.ToString() + ", " + "Area" + equal + Hw4_AreaResult.ToString();

                rtb_Result.Text = Outstr;
            }
        }
        #endregion HW4

        #region HW8
        private void btn_HW8_TemperatureAvg_Click(object sender, EventArgs e)
        {
            HW8 HW8 = new HW8();

            var Hw8TempAvgResult = 0d;

            string[] TemmperatureStr = txb_HW3_Temperature.Text.Split(',');

            List<double> Temperature = new List<double>();

            try
            {
                foreach (var item in TemmperatureStr)
                {
                    Temperature.Add(Convert.ToDouble(item));
                }
            }
            catch (Exception ex)
            { 
            
            }

            if (HW8.TempAvg(Temperature, ref Hw8TempAvgResult)==false)
            {

            }
            else
            {
                var Outstr = "Input Temperatures: " + txb_HW3_Temperature.Text + "\nAverage = " + Hw8TempAvgResult.ToString();

                rtb_Result.Text = Outstr;
            }

            //Temperature = txb_HW3_Temperature.Text.Split(",");


            //List<string> Stemp = txb_HW3_Temperature.Text.Split(", ",StringSplitOptions.)

            //    txb_HW3_Temperature.Text


            //var TmpData = txb_HW3_Temperature.Text;


        }
        #endregion HW8

        #region HW9
        private void btn_HW9_Bmi_Click(object sender, EventArgs e)
        {
            HW9 HW9 = new HW9();

            var Hight = 0d;

            var Weight = 0d;

            var Hw9_BmiResult = 0d;

            try
            {
                Hight = Convert.ToDouble(txb_HW9_Hight.Text);

                if (Hight >= 3d)
                {
                    Hight /= 100;
                }
            }
            catch (Exception ex31)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                Weight = Convert.ToDouble(txb_HW9_Weight.Text);
            }
            catch (Exception ex32)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW9.BMI(Hight, Weight, ref Hw9_BmiResult) == false)
            {

            }
            else
            {
                var Outstr = "Hight" + equal + Hight.ToString() + "m, " + "Weight" + equal + Weight.ToString() + "Kg, " + "BMI" + equal + Hw9_BmiResult.ToString();

                rtb_Result.Text = Outstr;
            }
        }
        #endregion HW9


    }

    #region HW1
    public class HW1
    {
        public bool Hw1(int intput1, int input2, int input3, ref int Hw1_SumResult)
        {
            bool status = true;

            Hw1_SumResult = intput1 + input2 + input3;

            return status;
        }
    }
    #endregion HW1

    #region HW2
    public class HW2
    {
        public const double Pi = 3.14d;
        public const double Dev4of3 = (4d / 3d);

        public bool Perimeter(double Radius, ref double HW2_PerimeterResult)
        {
            bool status = true;

            HW2_PerimeterResult = 2 * Pi * Radius;

            return status;
        }

        public bool Area(double Radius, ref double Hw2_AreaResult)
        {
            bool status = true;

            Hw2_AreaResult = Pi * Math.Pow(Radius, 2);

            return status;
        }

        public bool Volume(double Radius, ref double Hw3_VolumeResult)
        {
            bool status = true;

            Hw3_VolumeResult = Dev4of3 * Pi * Math.Pow(Radius, 3);

            return status;
        }
    }
    #endregion HW2

    #region HW3
    public class HW3
    {
        public bool Perimeter(double length, double wide, ref double Hw3_PerimeterResult)
        {
            bool status = true;

            Hw3_PerimeterResult = 2 * (length + wide);

            return status;
        }

        public bool Area(double length, double wide, ref double Hw3AreaResult)
        {
            bool status = true;

            Hw3AreaResult = length * wide;

            return status;
        }
    }
    #endregion HW3

    #region HW4
    public class HW4
    {
        public bool Area(double TopBase, double BottonBase, double Height, ref double Hw4AreaResult)
        {
            bool status = true;

            Hw4AreaResult = (TopBase + BottonBase) * Height / 2;

            return status;
        }
    }
    #endregion HW4

    #region HW8
    public class HW8
    {
        public bool TempAvg(List<double> Temperature, ref double Hw8TempAvgResult)
        {
            bool status = true;

            var TempSum = 0d;

            foreach (var item in Temperature)
            {
                TempSum += item;
            }

            Hw8TempAvgResult = TempSum / Temperature.Count;

            return status;
        }
    }
    #endregion HW8

    #region HW9
    public class HW9
    {
        public bool BMI(double Hight, double Weight, ref double Hw9BmiResult)
        {
            bool status = true;

            Hw9BmiResult = Weight / Math.Pow(Hight, 2);

            return status;
        }
    }
    #endregion BMI
}
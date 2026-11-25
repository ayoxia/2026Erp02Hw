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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW1
{
    public partial class Form_HW : Form
    {
        string equal = " = ";

        public Form_HW()
        {
            InitializeComponent();

            MessageBox.Show("作業一", "堯記重工業");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("版權所有\n翻印必究", "堯記重工業");
        }

        private void btn_HW_Clean_Click(object sender, EventArgs e)
        {
            rtb_HW_Result.Clear();
        }

        private void tabControl_Practise1_Click(object sender, EventArgs e)
        {
            rtb_HW_Result.Text = string.Empty;//test null            
        }

        #region HW01
        private void btn_HW01_Sum_Click(object sender, EventArgs e)
        {
            HW01 HW01 = new HW01();

            var input1 = 0;
            var input2 = 0;
            var input3 = Int16.MinValue;
            var Hw01_SumResult = 0;

            try
            {
                input1 = Convert.ToInt32(txb_HW01_data1.Text);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                input2 = int.Parse(txb_HW01_data2.Text);
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                uint.TryParse(txb_HW01_data3.Text, out uint value3);
                input3 = (Int16)value3;
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW01.Sum(input1, input2, input3, ref Hw01_SumResult) == false)
            {

            }
            else
            {
                var Outstr = input1.ToString() + " + " + input2.ToString() + " + " + input3.ToString() + equal + Hw01_SumResult.ToString();

                rtb_HW_Result.AppendText(Outstr + "\n\n");

                //lab_HW1_Sum.Text += equal + sum.ToString();
            }
        }
        #endregion HW01

        #region HW02
        private void btn_HW02_Perimeter_Click(object sender, EventArgs e)
        {
            HW02 HW02 = new HW02();

            var Radius = 0d;

            var Hw02_PerimeterResult = 0d;

            try
            {
                Radius = Convert.ToDouble(txb_HW02_Radius.Text);
            }
            catch (Exception ex21)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW02.Perimeter(Radius, ref Hw02_PerimeterResult) == false)
            {

            }
            else
            {
                var Outstr = "Radius" + equal + Radius.ToString() + "\n" + "Perimeter" + equal + Hw02_PerimeterResult.ToString();

                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }
        }

        private void btn_HW02_Area_Click(object sender, EventArgs e)
        {
            HW02 HW02 = new HW02();

            var Radius = 0d;

            var Hw02_AreaResult = 0d;

            try
            {
                Radius = Convert.ToDouble(txb_HW02_Radius.Text);
            }
            catch (Exception ex22)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW02.Area(Radius, ref Hw02_AreaResult) == false)
            {

            }
            else
            {
                var Outstr = "Radius" + equal + Radius.ToString() + "\n" + "Area" + equal + Hw02_AreaResult.ToString();

                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }
        }

        private void btn_HW02_Volume_Click(object sender, EventArgs e)
        {
            HW02 HW02 = new HW02();

            var Radius = 0d;

            var Hw02_VolumeResult = 0d;

            try
            {
                Radius = Convert.ToDouble(txb_HW02_Radius.Text);
            }
            catch (Exception ex23)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW02.Volume(Radius, ref Hw02_VolumeResult) == false)
            {

            }
            else
            {
                var Outstr = "Radius" + equal + Radius.ToString() + "\n" + "Volume" + equal + Hw02_VolumeResult.ToString();

                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }
        }
        #endregion HW02

        #region HW03
        private void btn_HW03_Perimeter_Click(object sender, EventArgs e)
        {
            HW03 HW03 = new HW03();

            var Length = 0d;

            var Width = 0d;

            var Hw03_PerimeterResult = 0d;

            try
            {
                Length = Convert.ToDouble(txb_HW03_Length.Text);
            }
            catch (Exception ex31)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                Width = Convert.ToDouble(txb_HW03_Width.Text);
            }
            catch (Exception ex32)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW03.Perimeter(Length, Width, ref Hw03_PerimeterResult) == false)
            {

            }
            else
            {
                var Outstr = "Length" + equal + Length.ToString() + "\n" + "Width" + equal + Width.ToString() + "\n" + "Perimeter" + equal + Hw03_PerimeterResult.ToString();

                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }
        }

        private void btn_HW03_Area_Click(object sender, EventArgs e)
        {
            HW03 HW03 = new HW03();

            var Length = 0d;

            var Width = 0d;

            var Hw03_AreaResult = 0d;

            try
            {
                Length = Convert.ToDouble(txb_HW03_Length.Text);
            }
            catch (Exception ex31)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                Width = Convert.ToDouble(txb_HW03_Width.Text);
            }
            catch (Exception ex32)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW03.Area(Length, Width, ref Hw03_AreaResult) == false)
            {

            }
            else
            {
                var Outstr = "Length" + equal + Length.ToString() + "\n" + "Width" + equal + Width.ToString() + "\n" + "Area" + equal + Hw03_AreaResult.ToString();

                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }
        }
        #endregion HW03

        #region HW04
        private void btn_HW04_Area_Click(object sender, EventArgs e)
        {
            HW04 HW04 = new HW04();

            var TopBase = 0d;

            var BottonBase = 0d;

            var Height = 0d;

            var Hw04_AreaResult = 0d;

            try
            {
                TopBase = Convert.ToDouble(txb_HW04_TopBase.Text);
            }
            catch (Exception ex41)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                //BottonBase = Convert.ToDouble(txb_HW4_BottomBase.Text);
                BottonBase = double.Parse(txb_HW04_BottomBase.Text);
            }
            catch (Exception ex32)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            try
            {
                //Height = Convert.ToDouble(txb_HW4_Height.Text);
                double.TryParse(txb_HW04_Height.Text, out Height);
            }
            catch (Exception ex32)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW04.Area(TopBase, BottonBase, Height, ref Hw04_AreaResult) == false)
            {

            }
            else
            {
                //var Outstr = "TopBase" + equal + TopBase.ToString() + ", " + "BottonBase" + equal + BottonBase.ToString() + ", " + "Height" + equal + Height.ToString() + ", " + "Area" + equal + Hw4_AreaResult.ToString();
                var Outstr = string.Format("TopBase{0}{1}\nBottonBase{2}{3}\nHeight{4}{5}\nArea{6}{7}", equal, TopBase, equal, BottonBase, equal, Height, equal, Hw04_AreaResult);


                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }
        }
        #endregion HW04

        #region HW05
        private void btn_HW05_TotalMile_Click(object sender, EventArgs e)
        {
            HW05 HW5 = new HW05();
            var status = true;

            var TpeHsqMile = 0d;
            var HsqTxgMile = 0d;
            var TxgTnnMile = 0d;
            var TnnKhhMile = 0d;

            var Hw05_TotalMileResult = 0d;

            #region Mile
            try
            {
                HW5.SingleMilage(double.Parse(txb_HW05_TpeHsqKmh.Text), double.Parse(txb_HW05_TpeHsqHr.Text), ref TpeHsqMile);
            }
            catch (Exception ex)
            {

            }

            try
            {
                HW5.SingleMilage(double.Parse(txb_HW05_HsqTxgKmh.Text), double.Parse(txb_HW05_HsqTxgHr.Text), ref HsqTxgMile);
            }
            catch (Exception ex)
            {

            }

            try
            {
                HW5.SingleMilage(double.Parse(txb_HW05_TxgTnnKmh.Text), double.Parse(txb_HW05_TxgTnnHr.Text), ref TxgTnnMile);
            }
            catch (Exception ex)
            {

            }

            try
            {
                HW5.SingleMilage(double.Parse(txb_HW05_TnnKhhKmh.Text), double.Parse(txb_HW05_TnnKhhHr.Text), ref TnnKhhMile);
            }
            catch (Exception ex)
            {

            }
            #endregion Mile

            if (HW5.TotalMilage(TpeHsqMile, HsqTxgMile, TxgTnnMile, TnnKhhMile, ref Hw05_TotalMileResult) == false)
            {

            }
            else
            {
                var Outstr = $"Tpe to Hsq: {TpeHsqMile}Km\nHaq to Txg: {HsqTxgMile}Km\nTxg to Tnn: {TxgTnnMile}Km\nTnn to Knn: {TnnKhhMile}Km\n\nTotal Mile:{Hw05_TotalMileResult}Km";

                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }
        }

        private void btn_HW05_TotalTime_Click(object sender, EventArgs e)
        {
            HW05 HW05 = new HW05();
            var status = true;

            var TpeHsqHr = 0d;
            var HsqTxgHr = 0d;
            var TxgTnnHr = 0d;
            var TnnKnnHr = 0d;

            var Hw05_TotalTimeResult = 0d;

            try
            {
                TpeHsqHr = double.Parse(txb_HW05_TpeHsqHr.Text);
            }
            catch (Exception ex)
            {

            }

            try
            {
                HsqTxgHr = double.Parse(txb_HW05_HsqTxgHr.Text);
            }
            catch (Exception ex)
            {

            }

            try
            {
                TxgTnnHr = double.Parse(txb_HW05_TxgTnnHr.Text);
            }
            catch (Exception ex)
            {

            }

            try
            {
                TnnKnnHr = double.Parse(txb_HW05_TnnKhhHr.Text);
            }
            catch (Exception ex)
            {

            }

            if (HW05.TotalTime(TpeHsqHr, HsqTxgHr, TxgTnnHr, TnnKnnHr, ref Hw05_TotalTimeResult) == false)
            {

            }
            else
            {
                var Outstr = $"Tpe to Hsq:{TpeHsqHr}hr\nHaq to Txg:{HsqTxgHr}hr\nTxg to Tnn:{TxgTnnHr}hr\nTnn to Knn:{TnnKnnHr}hr\n\nTotal Time:{Hw05_TotalTimeResult}";

                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }
        }
        #endregion HW05

        #region HW06
        private void btn_HW06_Stock_Click(object sender, EventArgs e)
        {
            HW06 HW6 = new HW06();

            var status = false;

            var Init = 0u;
            var BuyInc = 0u;
            var BuyDec = 0u;
            var SaleInc = 0u;
            var SaleDec = 0u;

            var Hw06_StockResult = 0u;

            try
            {
                if (txb_HW06_Init.Text.Contains("."))
                {
                    status = false;

                    MessageBox.Show("Input Must Integer", "HW06", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Init = Convert.ToUInt32(txb_HW06_Init.Text);

                    status = true;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (txb_HW06_BuyInc.Text.Contains("."))
                {
                    status = false;

                    MessageBox.Show("Input Must Integer", "H0W6", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    BuyInc = Convert.ToUInt32(txb_HW06_BuyInc.Text);

                    status = true;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (txb_HW06_BuyDec.Text.Contains("."))
                {
                    status = false;

                    MessageBox.Show("Input Must Integer", "HW06", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    BuyDec = Convert.ToUInt32(txb_HW06_BuyDec.Text);

                    status = true;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (txb_HW06_SaleInc.Text.Contains("."))
                {
                    status = false;

                    MessageBox.Show("Input Must Integer", "HW06", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    SaleInc = Convert.ToUInt32(txb_HW06_SaleInc.Text);

                    status = true;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (txb_HW06_SaleDec.Text.Contains("."))
                {
                    status = false;

                    MessageBox.Show("Input Must Integer", "HW6", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    SaleDec = Convert.ToUInt32(txb_HW06_SaleDec.Text);

                    status = true;
                }
            }
            catch (Exception ex)
            {

            }

            if (status == false)
            {

            }
            else
            {
                if (HW6.Stock(Init, BuyInc, BuyDec, SaleInc, SaleDec, ref Hw06_StockResult) == false)
                {

                }
                else
                {
                    var Outstr = $"期初存量:+{Init}\n本期進貨量:+{BuyInc}\n本期進貨退回量:-{BuyDec}\n本期出貨量:-{SaleDec}\n本期出貨退回量:+{SaleInc}\n\n庫存量:{Hw06_StockResult}";

                    rtb_HW_Result.AppendText(Outstr + "\n\n");
                }
            }
        }
        #endregion

        #region HW07
        private void btn_HW07_Sec_Click(object sender, EventArgs e)
        {
            HW07 HW07 = new HW07();

            var HW07_SecResult = 0d;

            DateTime today = DateTime.Today;
            DateTime nextdate = today.AddDays(Convert.ToUInt32(txb_HW07_Days.Text));

            if (HW07.SecondsInDay(today, nextdate, ref HW07_SecResult) == false)
            {

            }
            else
            {
                var Outstr = $"{txb_HW07_Days.Text}days have {HW07_SecResult} seconds";

                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }
        }
        #endregion HW07

        #region HW08
        private void btn_HW08_TemperatureAvg_Click(object sender, EventArgs e)
        {
            HW08 HW08 = new HW08();

            var Hw08_TempAvgResult = 0d;

            string[] TemmperatureStr = txb_HW08_Temperature.Text.Split(',');

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

            if (HW08.TempAvg(Temperature, ref Hw08_TempAvgResult) == false)
            {

            }
            else
            {
                //var Outstr = "Input Temperatures: " + txb_HW3_Temperature.Text + "\nAverage = " + Hw8TempAvgResult.ToString();

                var Outstr = $"Input Temperatures: {txb_HW08_Temperature.Text}\nAverage = {Hw08_TempAvgResult}";
                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }

            //Temperature = txb_HW3_Temperature.Text.Split(",");


            //List<string> Stemp = txb_HW3_Temperature.Text.Split(", ",StringSplitOptions.)

            //    txb_HW3_Temperature.Text


            //var TmpData = txb_HW3_Temperature.Text;
        }
        #endregion HW08

        #region HW09
        private void btn_HW09_Bmi_Click(object sender, EventArgs e)
        {
            HW09 HW09 = new HW09();

            var Hight = 0d;

            var Weight = 0d;

            var Hw09_BmiResult = 0d;

            try
            {
                Hight = Convert.ToDouble(txb_HW09_Hight.Text);

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
                Weight = Convert.ToDouble(txb_HW09_Weight.Text);
            }
            catch (Exception ex32)
            {
                MessageBox.Show("Input is not numical", "Error");
            }

            if (HW09.BMI(Hight, Weight, ref Hw09_BmiResult) == false)
            {

            }
            else
            {
                var Outstr = "Hight" + equal + Hight.ToString() + "m\n" + "Weight" + equal + Weight.ToString() + "Kg\n" + "BMI" + equal + Hw09_BmiResult.ToString();

                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }
        }
        #endregion HW09

        #region HW10
        private void btn_HW10_Sec_Click(object sender, EventArgs e)
        {
            HW10 HW10 = new HW10();

            TimeSpan duration = new TimeSpan(Convert.ToInt32(txb_HW10_Hous.Text), Convert.ToInt32(txb_HW10_Minunes.Text), 0);

            var Hw10_TotalSecondsResult = 0d;

            if (HW10.ToSec(duration, ref Hw10_TotalSecondsResult) == false)
            {

            }
            else
            {
                var Outstr = $"{txb_HW10_Hous.Text} hrs {txb_HW10_Minunes.Text}mins have {Hw10_TotalSecondsResult} secs";

                rtb_HW_Result.AppendText(Outstr + "\n\n");
            }

            double totalSeconds = duration.TotalSeconds;
        }
        #endregion HW10

        //public bool IsDigitalInput(bool Digital_Input)
        //{
        //    if (Digital_Input == true) 
        //    {
        //        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = true;
        //        }
        //    }

        //    return true;
        //}

        #region HW01 Key Control
        private void txb_HW01_data1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_HW01_data2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_HW01_data3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion HW01 Key Control

        #region HW02 Key Control
        private void txb_HW02_Radius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW02_Radius.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion HW02 Key Control

        #region HW03 Key Control
        private void txb_HW03_Length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW03_Length.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW03_Width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW03_Width.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion HW03 Key Control

        #region HW04 Key Control
        private void txb_HW04_TopBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW04_TopBase.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW04_BottomBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW04_BottomBase.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW04_Height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW04_Height.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }


        #endregion HW04 Key Control

        #region HW05 Key Control
        private void txb_HW05_TpeHsqKmh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW05_TpeHsqKmh.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW05_TpeHsqHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW05_TpeHsqHr.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW05_HsqTxgKmh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW05_HsqTxgKmh.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW05_HsqTxgHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW05_HsqTxgHr.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW05_TxgTnnKmh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW05_TxgTnnKmh.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW05_TxgTnnHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW05_TxgTnnHr.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW05_TnnKhhKmh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW05_TnnKhhKmh.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW05_TnnKhhHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW05_TnnKhhHr.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion HW05 Key Control

        #region HW06 Key Control
        private void txb_HW06_Init_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_HW06_BuyInc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_HW06_BuyDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_HW06_SaleDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_HW06_SaleInc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion HW06 Key Control

        #region HW07 Key Control
        private void txb_HW07_Days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion HW07 Key Control

        #region HW08 Key Control
        private void btn_HW08_TemperatureAvg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion HW08 Key Control

        #region HW09 Key Control
        private void txb_HW09_Hight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW09_Hight.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txb_HW09_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'/*&& sender is TextBox txb_HW02_Radius*/ )
            {
                if (txb_HW09_Weight.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion HW09 Key Control

        #region HW10 Key Control
        private void txb_HW10_Hous_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_HW10_Minunes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion HW10 Key Control
    }

    #region HW01
    public class HW01
    {
        public bool Sum(int intput1, int input2, int input3, ref int Hw01_SumResult)
        {
            bool status = true;

            Hw01_SumResult = intput1 + input2 + input3;

            return status;
        }
    }
    #endregion HW01

    #region HW02
    public class HW02
    {
        public const double Pi = 3.14d;
        public const double Dev4of3 = (4d / 3d);

        public bool Perimeter(double Radius, ref double Hw02_PerimeterResult)
        {
            bool status = true;

            Hw02_PerimeterResult = 2 * Pi * Radius;

            return status;
        }

        public bool Area(double Radius, ref double Hw02_AreaResult)
        {
            bool status = true;

            Hw02_AreaResult = Pi * Math.Pow(Radius, 2);

            return status;
        }

        public bool Volume(double Radius, ref double Hw02_VolumeResult)
        {
            bool status = true;

            Hw02_VolumeResult = Dev4of3 * Pi * Math.Pow(Radius, 3);

            return status;
        }
    }
    #endregion HW02

    #region HW03
    public class HW03
    {
        public bool Perimeter(double length, double wide, ref double Hw03_PerimeterResult)
        {
            bool status = true;

            Hw03_PerimeterResult = 2 * (length + wide);

            return status;
        }

        public bool Area(double length, double wide, ref double Hw03_AreaResult)
        {
            bool status = true;

            Hw03_AreaResult = length * wide;

            return status;
        }
    }
    #endregion HW03

    #region HW04
    public class HW04
    {
        public bool Area(double TopBase, double BottonBase, double Height, ref double Hw04_AreaResult)
        {
            bool status = true;

            Hw04_AreaResult = (TopBase + BottonBase) * Height / 2;

            return status;
        }
    }
    #endregion HW04

    #region HW05
    public class HW05
    {
        public bool SingleMilage(double Kmh, double Hr, ref double Hw05_MileResult)
        {
            var status = true;

            Hw05_MileResult = Kmh * Hr;

            return status;
        }

        public bool TotalMilage(double TpeHsqMile, double HsqTxgMile, double TxgTnnMile, double TnnKhhMile, ref double Hw05_TotalMileResult)
        {
            var status = true;

            Hw05_TotalMileResult = TpeHsqMile + HsqTxgMile + TxgTnnMile + TnnKhhMile;

            return status;
        }

        public bool TotalTime(double TpeHsqHr, double HsqTxgHr, double TxgTnnHr, double TnnKhhHr, ref double Hw05_TotalTimeResult)
        {
            var status = true;

            Hw05_TotalTimeResult = TpeHsqHr + HsqTxgHr + TxgTnnHr + TnnKhhHr;

            return status;
        }
    }
    #endregion HW05

    #region HW06
    public class HW06
    {
        public bool Stock(uint Init, uint buyInc, uint BuyDec, uint SaleInc, uint SaleDec, ref uint Hw06_StockResult)
        {
            bool status = true;

            Hw06_StockResult = Init + buyInc - BuyDec + SaleInc - SaleDec;

            return status;
        }
    }
    #endregion HW06

    #region HW07
    public class HW07
    {
        public bool SecondsInDay(DateTime Today, DateTime Nextday, ref double Hw07_SecResult)
        {
            bool status = true;

            Hw07_SecResult = (Nextday - Today).TotalSeconds;

            return status;
        }

    }
    #endregion HW07

    #region HW08
    public class HW08
    {
        public bool TempAvg(List<double> Temperature, ref double Hw08_TempAvgResult)
        {
            bool status = true;

            var TempSum = 0d;

            foreach (var item in Temperature)
            {
                TempSum += item;
            }

            Hw08_TempAvgResult = TempSum / Temperature.Count;

            return status;
        }
    }
    #endregion HW08

    #region HW09
    public class HW09
    {
        public bool BMI(double Hight, double Weight, ref double Hw09_BmiResult)
        {
            bool status = true;

            Hw09_BmiResult = Weight / Math.Pow(Hight, 2);

            return status;
        }
    }
    #endregion HW09

    #region HW10
    public class HW10
    {
        public bool ToSec(TimeSpan Duration, ref double Hw10_TotalSecondsResult)
        {
            bool status = true;

            Hw10_TotalSecondsResult = Duration.TotalSeconds;

            return status;
        }
    }
    #endregion HW10

}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           // Numeric settings
            foreach (Control c in Controls)
            {
                if(c is NumericUpDown)
                {
                    c.Text = "";
                    c.Controls[0].Visible = false;
                    numericUpDown1.Minimum = -273.15m;
                    numericUpDown2.Minimum = -459.67m;
                    numericUpDown3.Minimum = 0.00m;
                    numericUpDown4.Minimum = -90.1395m;
                    numericUpDown5.Minimum = 0.00m;
                    numericUpDown6.Minimum = -218.52m;
                    numericUpDown7.Minimum = -135.90375m;
                    numericUpDown8.Maximum = 559.725m;
                }
            }

        }
        //Temp Values
        decimal inputvalueC = 0m;
        decimal inputvalueF = 0m;
        decimal inputvalueK = 0m;
        decimal inputvalueN = 0m;
        decimal inputvalueR = 0m;
        decimal inputvalueRe = 0m;
        decimal inputvalueRo = 0m;
        decimal inputvalueDe = 0m;
        //App Exit
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Celsius
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            inputvalueC = (decimal)numericUpDown1.Value;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(inputvalueC == 0)
            {
                numericUpDown1.Text = "0";
                numericUpDown4.Text = "0";
                numericUpDown6.Text = "0";
            }
            numericUpDown2.Value = (inputvalueC *1.8m) + 32;
            numericUpDown3.Value = inputvalueC + 273.15m;
            numericUpDown4.Value = inputvalueC * 33 / 100;
            numericUpDown5.Value = (inputvalueC + 273.15m) * 9 / 5;
            numericUpDown6.Value = inputvalueC * 4 / 5;
            numericUpDown7.Value = inputvalueC * 21 / 40 + 7.5m;
           
            if (inputvalueC == 100)
            {
                numericUpDown8.Text = "0";
            }
            else
            {
                numericUpDown8.Value = (100 - inputvalueC) * 3 / 2;
            }

        }
        //Fahrenheit
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            inputvalueF = (decimal)numericUpDown2.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            numericUpDown1.Value = (inputvalueF - 32) * 5 / 9;
            if (inputvalueF == 0)
            {
                numericUpDown2.Text = "0";
            }
            numericUpDown3.Value = (inputvalueF + 459.67m) * 5 / 9;
            numericUpDown4.Value = (inputvalueF - 32) * 11 / 60;
            numericUpDown5.Value = inputvalueF + 459.67m;
            numericUpDown6.Value = (inputvalueF - 32) * 4 / 9;
            numericUpDown7.Value = (inputvalueF - 32) * 7 / 24 + 7.5m;
            numericUpDown8.Value = (212 - inputvalueF) * 5 / 6;
        }
        //Kelvin
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            inputvalueK = (decimal)numericUpDown3.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {

           numericUpDown1.Value = inputvalueK - 273.15m;
           numericUpDown2.Value = inputvalueK * 9 / 5 - 459.67m;
           numericUpDown4.Value = (inputvalueK - 273.15m) * 33 / 100;

            if (inputvalueK == 0)
            {
                numericUpDown3.Text = "0";
                numericUpDown5.Text = "0";
            }
            else
            {
                numericUpDown5.Value = inputvalueK * 9 / 5;
            }
           
           numericUpDown6.Value = (inputvalueK - 273.15m) * 4 / 5;
           numericUpDown7.Value = (inputvalueK - 273.15m) * 21 / 40 + 7.5m;
           numericUpDown8.Value = (373.15m - inputvalueK) * 3 / 2;
        }
        //Newton
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            inputvalueN = (decimal)numericUpDown4.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = inputvalueN * 100 / 33;
            numericUpDown2.Value = inputvalueN * 60 / 11 + 32;
            numericUpDown3.Value = inputvalueN * 100 / 33 + 273.15m;
            if (inputvalueN == 0)
            {
                numericUpDown1.Text = "0";
                numericUpDown4.Text = "0";
                numericUpDown6.Text = "0";
            }
            numericUpDown5.Value = inputvalueN * 60 / 11 + 491.67m;
            numericUpDown6.Value = inputvalueN * 80 / 33;
            numericUpDown7.Value = inputvalueN * 35 / 22 + 7.5m;
            numericUpDown8.Value = (33 - inputvalueN) * 50 / 11;
        }
        //Rankine
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            inputvalueR = (decimal)numericUpDown5.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = (inputvalueR - 491.67m) * 5 / 9;
            numericUpDown2.Value = inputvalueR - 459.67m;
            numericUpDown3.Value = inputvalueR * 5 / 9;
            if (inputvalueR == 0)
            {
                numericUpDown5.Text = "0";
                numericUpDown3.Text = "0";
            }
            numericUpDown4.Value = (inputvalueR - 491.67m) * 11 / 60;
            numericUpDown6.Value = (inputvalueR - 491.67m) * 4 / 9;
            numericUpDown7.Value = (inputvalueR - 491.67m) * 7 / 24 + 7.5m;
            numericUpDown8.Value = (671.67m - inputvalueR) * 5 / 6;
        }
        //Reaumur
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            inputvalueRe = (decimal)numericUpDown6.Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = inputvalueRe * 5 / 4;
            numericUpDown2.Value = inputvalueRe * 9 / 4 + 32;
            numericUpDown3.Value = inputvalueRe * 5 / 4 + 273.15m;
            numericUpDown4.Value = inputvalueRe * 33 / 80;
            if (inputvalueRe == 0)
            {
                numericUpDown1.Text = "0";
                numericUpDown4.Text = "0";
                numericUpDown6.Text = "0";
            }
            numericUpDown5.Value = inputvalueRe * 9 / 4 + 491.67m;
            numericUpDown7.Value = inputvalueRe * 21 / 32 + 7.5m;
            numericUpDown8.Value = (80 - inputvalueRe) * 15 / 8;

        }
        //Romer
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            inputvalueRo = (decimal)numericUpDown7.Value;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = (inputvalueRo - 7.5m) * 40 / 21;
            numericUpDown2.Value = (inputvalueRo - 7.5m) * 24 / 7 + 32;
            numericUpDown3.Value = (inputvalueRo - 7.5m) * 40 / 21 + 273.15m;
            numericUpDown4.Value = (inputvalueRo - 7.5m) * 22 / 35;
            numericUpDown5.Value = (inputvalueRo - 7.5m) * 24 / 7 + 491.67m;
            numericUpDown6.Value = (inputvalueRo - 7.5m) * 32 / 21;
            if (inputvalueRo == 0)
            {
                numericUpDown7.Text = "0";
            }
            numericUpDown8.Value = (60 - inputvalueRo) * 20 / 7;
        }
        //Delisle
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            inputvalueDe = (decimal)numericUpDown8.Value;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 100 - inputvalueDe * 2 / 3;
            numericUpDown2.Value = 212 - inputvalueDe * 6 / 5;
            numericUpDown3.Value = 373.15m - inputvalueDe * 2 / 3;
            numericUpDown4.Value = 33 - inputvalueDe * 11 / 50;
            numericUpDown5.Value = 671.67m - inputvalueDe * 6 / 5;
            numericUpDown6.Value = 80 - inputvalueDe * 8 / 15;
            numericUpDown7.Value = 60 - inputvalueDe * 7 / 20;
            if (inputvalueDe == 0)
            {
                numericUpDown8.Text = "0";
            }
        }
        // Reset Button (not final)
        private void button9_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0m;
            numericUpDown2.Value = 0m;
            numericUpDown3.Value = 0m;
            numericUpDown4.Value = 0m;
            numericUpDown5.Value = 0m;
            numericUpDown6.Value = 0m;
            numericUpDown7.Value = 0m;
            numericUpDown8.Value = 0m;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string info = "The default value for every field is set to 0. If the value passes the limit (for example below 0 Kelvin) the software will set the minimum value automatically.";
            string title = "Information about the values.";
            MessageBox.Show(info,title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string title = "Celsius Scale";
            string info = "The degree Celsius is a unit of temperature on the Celsius scale, a temperature scale originally known as the centigrade scale. " +
                "Since 1743 the Celsius scale has been based on 0 °C for the freezing point of water and 100 °C for the boiling point of water at 1 atm pressure.";
            MessageBox.Show(info,title, MessageBoxButtons.OK, MessageBoxIcon.Information);
         
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string title = "Fahrenheit Scale";
            string info = "The Fahrenheit scale is a temperature scale based on one proposed in 1724 by the physicist Daniel Gabriel Fahrenheit (1686–1736). It uses the degree Fahrenheit (symbol: °F) as the unit. " +
                "Fahrenheit is used in the United States, its territories and associated states (all served by the U.S. National Weather Service), as well as the Cayman Islands and Liberia for everyday applications. For example, U.S. weather forecasts, food cooking, and freezing temperatures are typically given in degrees Fahrenheit.";
            MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string title = "Kelvin Scale";
            string info = "The kelvin is the base unit of temperature in the International System of Units (SI), having the unit symbol K. It is named after the Belfast-born Glasgow University engineer and physicist William Thomson, 1st Baron Kelvin (1824–1907)." +
                "Unlike the degree Fahrenheit and degree Celsius, the kelvin is not referred to or written as a degree. The kelvin is the primary unit of temperature measurement for the physical sciences, but is often used in conjunction with the degree Celsius, which has the same magnitude.";
            MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string title = "Newton Scale";
            string info = "The Newton scale is a temperature scale devised by Isaac Newton in 1701.He called his device a thermometer, but he did not use the term temperature, speaking of degrees of heat (gradus caloris) instead.";  
            MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string title = "Rankine Scale";
            string info = "The Rankine scale is an absolute scale of thermodynamic temperature named after the Glasgow University engineer and physicist Macquorn Rankine, who proposed it in 1859. Just like the Kelvin scale, which was first proposed in 1848, zero on the Rankine scales is absolute zero, but a temperature difference of one Rankine degree is defined as equal to one Fahrenheit degree, rather than the Celsius degree used on the kelvin scale. The Rankine scale is still used in engineering systems where heat computations are done using degrees Fahrenheit.";
            MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string title = "Réaumur Scale";
            string info = "The Réaumur scale, also known as the octogesimal division, is a temperature scale for which the freezing and boiling points of water are defined as 0 and 80 degrees respectively. The scale is named for René Antoine Ferchault de Réaumur, who first proposed a similar scale in 1730. Its main modern uses are in some Italian and Swiss factories for measuring milk temperature during cheese production, and in the Netherlands for measuring temperature when cooking sugar syrup for desserts and sweets.";
            MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string title = "Rømer Scale";
            string info = "The Rømer scale, also known as Romer or Roemer, is a temperature scale named after the Danish astronomer Ole Christensen Rømer, who proposed it in 1701. It is based on the freezing point of pure water being 7.5 degrees and the boiling point of water as 60 degrees. The Rømer scale is no longer in use, but it is of some historical importance. Alongside the Newton scale, it was the first calibrated scale.";
            MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            string title = "Delisle Scale";
            string info = "The Delisle scale (°D) is a temperature scale invented in 1732 by the French astronomer Joseph-Nicolas Delisle (1688–1768). The Delisle scale is notable as one of the only temperature scales that is inverted from the amount of thermal energy it measures; unlike most other temperature scales, higher measurements in degrees Delisle are colder, while lower measurements are warmer.";
            MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

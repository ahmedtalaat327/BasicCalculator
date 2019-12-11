using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public string[] Digits { get; set; } = new string[0];
        Calclus Docal = new Calclus();
        #region .ctor 
        /// <summary>
        /// Default constrctor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


       
        #region Numbers + dot
        /// <summary>
        /// Events to print numbers from 0 to 1 and (.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "0";
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "8";
        }

        private void NineButon_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "9";
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + ".";
        }
        #endregion
        #region Control buttons CE , C and Del.
        /// <summary>
        /// Using controles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            Digits = new string[0];
            CalculationResultText.Text = "0";
            UserInputText.Text = "";
        }

        private void CButton_Click(object sender, EventArgs e)
        {

        }

        private void DelButton_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Operations buttons
        /// <summary>
        /// Operator functions + , / , -+
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DevisionButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "/";
        }

        private void MultiButtom_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "*";
        }

        private void SubtButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "-";
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "+";
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + " ";
            DoCalclus(UserInputText.Text);
            CalculationResultText.Text = Docal.ReturnedResult[0];
            Digits = new string[0];
            UserInputText.Text = UserInputText.Text.Substring(0, UserInputText.Text.Length-1);
            UserInputText.SelectionStart = UserInputText.Text.Length;
            UserInputText.SelectionLength = 0;
        }
        #endregion
        private void DoCalclus(string text)
        {
            int start = 0;
            
         for(int z = 0; z < text.Length; z++)
            {
                if (text.ElementAt(z) == '/'|| text.ElementAt(z) == ' ')
                {
                    Digits = Docal.Add(Digits, text.Substring(start, z-start));
                    string leftAlways = text.Substring(start, z-start);
                    start = start + leftAlways.Length + 1 ;
                    if(text.ElementAt(z) == '/')
                    Digits = Docal.Add(Digits, "/");
                }
             else   if (text.ElementAt(z) == '*' || text.ElementAt(z) == ' ')
                {
                    Digits = Docal.Add(Digits, text.Substring(start, z - start));
                    string leftAlways = text.Substring(start, z - start);
                    start = start + leftAlways.Length + 1;
                    if (text.ElementAt(z) == '*')
                        Digits = Docal.Add(Digits, "*");
                }
                //Need to check if there is / or * before.........continued

             else if (text.ElementAt(z) == '+' || text.ElementAt(z) == ' ')
                {
                    if (NodevOrMulti()) {
                        Digits = Docal.Add(Digits, text.Substring(start, z - start));
                        string leftAlways = text.Substring(start, z - start);
                        start = start + leftAlways.Length + 1;
                        if (text.ElementAt(z) == '+')
                            Digits = Docal.Add(Digits, "+");
                    }
                    else
                    {
                        Digits = Docal.Add(Digits, text.Substring(start, z - start));
                        string leftAlways = text.Substring(start, z - start);
                        start = start + leftAlways.Length + 1;
                        if (text.ElementAt(z) == '+')
                            Digits = Docal.Add(Digits, "+");
                    }
                }
                else if (text.ElementAt(z) == '-' || text.ElementAt(z) == ' ')
                {
                    if (NodevOrMulti())
                    {
                        Digits = Docal.Add(Digits, text.Substring(start, z - start));
                        string leftAlways = text.Substring(start, z - start);
                        start = start + leftAlways.Length + 1;
                        if (text.ElementAt(z) == '-')
                            Digits = Docal.Add(Digits, "-");
                    }
                    else
                    {
                        Digits = Docal.Add(Digits, text.Substring(start, z - start));
                        string leftAlways = text.Substring(start, z - start);
                        start = start + leftAlways.Length + 1;
                        if (text.ElementAt(z) == '-')
                            Digits = Docal.Add(Digits, "-");
                    }
                }
            }

            foreach (String ele in Digits)
            {
                Console.WriteLine(ele);
            }
         
             Docal.ReactToArray(Digits);

        }
  private bool NodevOrMulti()
        {
            bool found = false;
            foreach (String ele in Digits)
            {
                if (ele == "/"||ele=="*")
                {
                    found = true;
                }
            }
            return found;
        }
    }
}

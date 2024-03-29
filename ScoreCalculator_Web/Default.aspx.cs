﻿using System;

namespace ScoreCalculator_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public double[] Scores = new double[10];

        public int[] Vaheds = new int[10];

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (V1.Text != "")
                {
                    Vaheds[0] = Convert.ToInt16(V1.Text);
                }
                else
                {
                    Vaheds[0] = 0;
                }

                //--------------------------------------------------

                if (V2.Text != "")
                {
                    Vaheds[1] = Convert.ToInt16(V2.Text);
                }
                else
                {
                    Vaheds[1] = 0;
                }

                //--------------------------------------------------

                if (V3.Text != "")
                {
                    Vaheds[2] = Convert.ToInt16(V3.Text);
                }
                else
                {
                    Vaheds[2] = 0;
                }

                //--------------------------------------------------

                if (V4.Text != "")
                {
                    Vaheds[3] = Convert.ToInt16(V4.Text);
                }
                else
                {
                    Vaheds[3] = 0;
                }

                //--------------------------------------------------

                if (V5.Text != "")
                {
                    Vaheds[4] = Convert.ToInt16(V5.Text);
                }
                else
                {
                    Vaheds[4] = 0;
                }

                //--------------------------------------------------

                if (V6.Text != "")
                {
                    Vaheds[5] = Convert.ToInt16(V6.Text);
                }
                else
                {
                    Vaheds[5] = 0;
                }

                //--------------------------------------------------

                if (V7.Text != "")
                {
                    Vaheds[6] = Convert.ToInt16(V7.Text);
                }
                else
                {
                    Vaheds[6] = 0;
                }

                //--------------------------------------------------

                if (V8.Text != "")
                {
                    Vaheds[7] = Convert.ToInt16(V8.Text);
                }
                else
                {
                    Vaheds[7] = 0;
                }

                //--------------------------------------------------

                if (V9.Text != "")
                {
                    Vaheds[8] = Convert.ToInt16(V9.Text);
                }
                else
                {
                    Vaheds[8] = 0;
                }

                //--------------------------------------------------

                if (V10.Text != "")
                {
                    Vaheds[9] = Convert.ToInt16(V10.Text);
                }
                else
                {
                    Vaheds[9] = 0;
                }


                //-----------------------------------------------------------------------------------------------


                if (N1.Text != "")
                {
                    Scores[0] = Convert.ToDouble(N1.Text);
                }
                else
                {
                    Scores[0] = 0;
                }

                //--------------------------------------------------

                if (N2.Text != "")
                {
                    Scores[1] = Convert.ToDouble(N2.Text);
                }
                else
                {
                    Scores[1] = 0;
                }

                //--------------------------------------------------

                if (N3.Text != "")
                {
                    Scores[2] = Convert.ToDouble(N3.Text);
                }
                else
                {
                    Scores[2] = 0;
                }

                //--------------------------------------------------

                if (N4.Text != "")
                {
                    Scores[3] = Convert.ToDouble(N4.Text);
                }
                else

                {
                    Scores[3] = 0;
                }

                //--------------------------------------------------

                if (N5.Text != "")
                {
                    Scores[4] = Convert.ToDouble(N5.Text);
                }
                else
                {
                    Scores[4] = 0;
                }

                //--------------------------------------------------

                if (N6.Text != "")
                {
                    Scores[5] = Convert.ToDouble(N6.Text);
                }
                else
                {
                    Scores[5] = 0;
                }

                //--------------------------------------------------

                if (N7.Text != "")
                {
                    Scores[6] = Convert.ToDouble(N7.Text);
                }
                else
                {
                    Scores[6] = 0;
                }

                //--------------------------------------------------

                if (N8.Text != "")
                {
                    Scores[7] = Convert.ToDouble(N8.Text);
                }
                else
                {
                    Scores[7] = 0;
                }


                //--------------------------------------------------

                if (N9.Text != "")
                {
                    Scores[8] = Convert.ToDouble(N9.Text);
                }
                else
                {
                    Scores[8] = 0;
                }

                //--------------------------------------------------

                if (N10.Text != "")
                {
                    Scores[9] = Convert.ToDouble(N10.Text);
                }
                else
                {
                    Scores[9] = 0;
                }

                Double SumN = 0;
                int SumV = 0;


                for (int i = 0; i < 10; i++)
                {
                    SumN += Scores[i] * Vaheds[i];
                    SumV += Vaheds[i];
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(SumV);
                    Console.WriteLine(SumN);
                }

                Double Answer2 = SumN / SumV;

                Answer.Text = Answer2.ToString();
            }
            catch (System.FormatException)
            {
                Answer.Text = "Invalid Input";
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            Answer.Text = "Answer";
            V1.Text = "";
            V2.Text = "";
            V3.Text = "";
            V4.Text = "";
            V5.Text = "";
            V6.Text = "";
            V7.Text = "";
            V8.Text = "";
            V9.Text = "";
            V10.Text = "";

            N1.Text = "";
            N2.Text = "";
            N3.Text = "";
            N4.Text = "";
            N5.Text = "";
            N6.Text = "";
            N7.Text = "";
            N8.Text = "";
            N9.Text = "";
            N10.Text = "";
        }
    }
}
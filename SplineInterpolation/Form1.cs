using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplineInterpolation
{
    public partial class Form1 : Form
    {        
        IFunction functionToInterpolate;
        SplineInterpolation splineInterpolation;
        double a, b, A, B;
        int N;

        private void tbLeftBorder_TextChanged(object sender, EventArgs e)
        {
            string s = tbLeftBorder.Text;

            if (!string.IsNullOrEmpty(s))
            {
                lbLeftBoundCondition.Text = $"S''({s}) =";
            }
        }

        private void tbRightBorder_TextChanged(object sender, EventArgs e)
        {
            string s = tbRightBorder.Text;

            if (!string.IsNullOrEmpty(s))
            {
                lbRightBoundCondition.Text = $"S''({s}) =";
            }
        }

        private void btnLetsGo_Click(object sender, EventArgs e)
        {            
            a = Convert.ToDouble(tbLeftBorder.Text);
            b = Convert.ToDouble(tbRightBorder.Text);

            A = Convert.ToDouble(tbLeftBoundCondition.Text);
            B = Convert.ToDouble(tbRightBoundCondition.Text);

            N = Convert.ToInt32(nudN.Value);

            splineInterpolation = new SplineInterpolation(functionToInterpolate, a, b, A, B, N);
            splineInterpolation.InitializeParameters();

            double y_Accurate, y_Interpolated;

            chFunctionAndInterpolation.Series[0].Points.Clear();
            chFunctionAndInterpolation.Series[1].Points.Clear();
            chFunctionAndInterpolation.Series[2].Points.Clear();

            chError.Series[0].Points.Clear();

            for (int i = 0; i <= N; ++i)
            {
                chFunctionAndInterpolation.Series[2].Points.AddXY(
                    splineInterpolation.functionValuesTable[i, 0], splineInterpolation.functionValuesTable[i, 1]);
            }

            for (double x = a; x <= b; x += 0.01)
            {
                y_Accurate = functionToInterpolate.Value(x);
                y_Interpolated = splineInterpolation.Value(x);

                chFunctionAndInterpolation.Series[0].Points.AddXY(x, y_Accurate);
                chFunctionAndInterpolation.Series[1].Points.AddXY(x, y_Interpolated);

                chError.Series[0].Points.AddXY(x, Math.Abs(y_Accurate - y_Interpolated));
            }
        }

        private void cbFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFunction.SelectedIndex)
            {
                case 0:
                    {
                        functionToInterpolate = new PowerFunction();
                        break;
                    }
                case 1:
                    {
                        functionToInterpolate = new Exponent();
                        break;
                    }
                case 2:
                    {
                        functionToInterpolate = new Sin();
                        break;
                    }
                case 3:
                    {
                        functionToInterpolate = new Cos();
                        break;
                    }
                default:
                    {
                        functionToInterpolate = new CustomPolynomial();
                        break;
                    }
            }
        }

        private void btnABSecondDerivatives_Click(object sender, EventArgs e)
        {
            tbLeftBoundCondition.Text = functionToInterpolate.SecondDerivativeValue(Convert.ToDouble(tbLeftBorder.Text)).ToString();
            tbRightBoundCondition.Text = functionToInterpolate.SecondDerivativeValue(Convert.ToDouble(tbRightBorder.Text)).ToString();
        }        

        public Form1()
        {
            InitializeComponent();                        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1Triangulo
{
    class CTriangulo
    {
        private double mA, mB, mC;
        private string tipoTriangulo;

        public CTriangulo()
        {
            InitilizeData();
        }

        public void InitilizeData()
        {
            mA = 0; mB = 0; mC = 0;
        }

        public void InitilizeData(TextBox txtLabelA, TextBox txtLabelB, TextBox txtLabelC, TextBox txtLabelResult, PictureBox picBox)
        {
            mA = 0; mB = 0; mC = 0;
            txtLabelA.Text = "";
            txtLabelB.Text = "";
            txtLabelC.Text = "";
            txtLabelResult.Text = "";
            txtLabelA.Focus();
            picBox.Refresh();
        }

        public void InitilizeDataResultAndCanvas(TextBox txtLabelResult, PictureBox picBox)
        {
            txtLabelResult.Text = "";
            picBox.Refresh();
        }

        public void ReadData(TextBox txtLabelA, TextBox txtLabelB, TextBox txtLabelC)
        {
            mA = double.Parse(txtLabelA.Text);
            mB = double.Parse(txtLabelB.Text);
            mC = double.Parse(txtLabelC.Text);
        }

        public bool CheckTraingle()
        {
            if ((mA + mB > mC) && (mA + mC > mB) && (mB + mC > mA))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public void DetermineTriangle()
        {
            if ((mA + mB) > mC)
            {
                if ((mA == mB) && (mA == mC))
                {
                    tipoTriangulo = "El triángulo es equilatero";
                }
                else
                {
                    if ((mA == mB) && (mB != mC) || (mA == mC) && (mC != mB) || (mB == mC) && (mA != mC))
                    {
                        tipoTriangulo = "El triángulo es isoseles";
                    }
                    else
                    {
                        tipoTriangulo = "El triángulo es escaleno";
                    }
                }
            }
            else
            {
                tipoTriangulo = "LOS DATOS NO SON VALIDOS";
            }
        }

        public void PrintData(TextBox txtLabelResult)
        {
            txtLabelResult.Text = tipoTriangulo.ToString();
        }
    }
}

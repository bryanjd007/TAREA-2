using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1Triangulo
{
    public partial class frmTriangulo : Form
    {
        private CTriangulo objCTriangulo = new CTriangulo();
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (txtLabelA.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor para el lado A", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                objCTriangulo.InitilizeDataResultAndCanvas(txtLabelResult, picBox);
            }
            else if (txtLabelB.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor para el lado B", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                objCTriangulo.InitilizeDataResultAndCanvas(txtLabelResult, picBox);
            }
            else if (txtLabelC.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor para el lado C", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                objCTriangulo.InitilizeDataResultAndCanvas(txtLabelResult, picBox);
            }
            else
            {
                objCTriangulo.ReadData(txtLabelA, txtLabelB, txtLabelC);
                check = objCTriangulo.CheckTraingle();
                if (check == true)
                {
                    objCTriangulo.DetermineTriangle();
                    objCTriangulo.PrintData(txtLabelResult);
                }
                else
                {
                    MessageBox.Show("Error...el triángulo no existe", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objCTriangulo.InitilizeData(txtLabelA, txtLabelB, txtLabelC, txtLabelResult, picBox);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTriangulo_Load(object sender, EventArgs e)
        {
            objCTriangulo.InitilizeData(txtLabelA, txtLabelB, txtLabelC, txtLabelResult, picBox);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            objCTriangulo.InitilizeData(txtLabelA, txtLabelB, txtLabelC, txtLabelResult, picBox);
        }

        private void txtLabelA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se puede ingresar números", "Alerta",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtLabelB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtLabelC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtLabelA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System.Runtime.Serialization;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private OperadoresLogicos OpSelected { get; set; }
        private enum OperadoresLogicos
        {
            Ad,
            Sub,
            Mult,
            Div
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";

        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";

        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
                txtResult.Text += ",";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            OpSelected = OperadoresLogicos.Ad;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOp.Text = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OpSelected = OperadoresLogicos.Sub;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOp.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            OpSelected = OperadoresLogicos.Mult;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOp.Text = "X";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OpSelected = OperadoresLogicos.Div;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOp.Text = "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (OpSelected)
            {
                case OperadoresLogicos.Ad:
                    Resultado = Valor + Convert.ToDecimal(txtResult.Text);
                    break;
                case OperadoresLogicos.Sub:
                    Resultado = Valor - Convert.ToDecimal(txtResult.Text);
                    break;
                case OperadoresLogicos.Mult:
                    Resultado = Valor * Convert.ToDecimal(txtResult.Text);
                    break;
                case OperadoresLogicos.Div:
                    Resultado = Valor / Convert.ToDecimal(txtResult.Text);
                    break;
                default: break;
            }
            txtResult.Text = Convert.ToString(Resultado);
            lblOp.Text = "=";
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            lblOp.Text = "";
        }
    }
}

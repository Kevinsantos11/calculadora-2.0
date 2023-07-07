namespace calculadora_2._0
{
    public partial class Form1 : Form
    {
        public int resultado, numTemp;
        public string operacao;



        public Form1()
        {
            InitializeComponent();
        }
        private void DigitaNumero(int num)
        {
            numTemp = (numTemp * 10) + num;
            textBox1.Text = numTemp.ToString();

        }

        private void digitaOperacao(string operador)
        {
            resultado = numTemp;
            numTemp = 0;
            operacao = operador;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DigitaNumero(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DigitaNumero(1);
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            digitaOperacao("-");
            resultado = numTemp - resultado;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            DigitaNumero(2);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            DigitaNumero(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            DigitaNumero(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            DigitaNumero(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            DigitaNumero(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DigitaNumero(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            DigitaNumero(9);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            DigitaNumero(0);
            
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            

            if(operacao == "+")
            {
                resultado = resultado + numTemp;
                textBox1.Text = resultado.ToString();
            }
            else if (operacao == "-")
            {
                resultado = resultado - numTemp;
                textBox1.Text = resultado.ToString();
            }
            else if (operacao == "*")
            {
                resultado = resultado * numTemp;
                textBox1.Text = resultado.ToString();
            }
            else if (operacao == "/")
            {
                resultado = resultado / numTemp;
                textBox1.Text = resultado.ToString();
            }
        }


        private void btn_soma_Click(object sender, EventArgs e)
        {
            digitaOperacao("+");
            resultado = numTemp + resultado;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            digitaOperacao("*");
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            digitaOperacao("/");
        }
    }
}
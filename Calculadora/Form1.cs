namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private double valor1;
        private double valor2;
        private double signos;
        private double resultado;
        private int operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // n1
            if (Pantalla.Text == "0")
                Pantalla.Text = "";

            Pantalla.Text += "1";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //n2
            if (Pantalla.Text == "0")
                Pantalla.Text = "";
            Pantalla.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
                Pantalla.Text = "";
            Pantalla.Text += "3";
            //n3
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //n4
            if (Pantalla.Text == "0")
                Pantalla.Text = "";
            Pantalla.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //n5
            if (Pantalla.Text == "0")
                Pantalla.Text = "";
            Pantalla.Text += "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //n6
            if (Pantalla.Text == "0")
                Pantalla.Text = "";
            Pantalla.Text += "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //n7
            if (Pantalla.Text == "0")
                Pantalla.Text = "";
            Pantalla.Text += "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //n8
            if (Pantalla.Text == "0")
                Pantalla.Text = "";
            Pantalla.Text += "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //n9
            if (Pantalla.Text == "0")
                Pantalla.Text = "";
            Pantalla.Text += "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //n0
            if (Pantalla.Text == "0")
                Pantalla.Text = "";
            Pantalla.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // coma ,
            if (this.Pantalla.Text.Contains(',') == false)
            {
                Pantalla.Text += ",";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // = igual
            valor2 = Convert.ToDouble(Pantalla.Text);

            resultado = valor1 + valor2;
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    if (Pantalla.Text != "0")
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por 0!!");
                    }
                    break;
                case 5:
                    resultado = (valor1 * valor2) / 100;
                    break;
            }

            Pantalla.Text = resultado.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // / dividir
            operacion = 4;
            valor1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
        }
            
        

        private void button17_Click(object sender, EventArgs e)
        {
            // x multiplicar
            operacion = 3;
            valor1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // menos
            operacion = 2;
            valor1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // mas
            operacion = 1;
            valor1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // C borrar
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
            Pantalla.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            operacion = 5;
            valor1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signos = double.Parse(Pantalla.Text);
            signos = signos - (signos * 2);
            Pantalla.Text = signos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length > 1)
            {
                Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Length - 1);
            }
            else
            {
                Pantalla.Text = "0";
            }
        }
    }
}

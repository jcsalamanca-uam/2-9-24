using Sesion5_1.models;

namespace Sesion5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(Tb1.Text);
            int num2 = int.Parse(Tb2.Text);
            Ejercicios ejercicios = new Ejercicios();
            if (ejercicios.isMayor(num1, num2))
            {
                LblAnswer.Text = $"{num1} es mayor que {num2}.";
            }
            else if (ejercicios.isMayor(num1, num2))
            {
                LblAnswer.Text = $"{num2} es mayor que  {num1}.";

            }
            else
            {LblAnswer.Text = $"{num1} es igual a {num2}."; }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Tb1.Text);
            int num2 = int.Parse(Tb2.Text);
            Ejercicios ejercicios = new Ejercicios();
            if (ejercicios.isMayor(num1, num2))
            {
                LblAnswer.Text = $"{num2} es menor que {num1}.";
            }
            else if (ejercicios.isMayor(num1, num2))
            {
                LblAnswer.Text = $"{num1} es menor que  {num2}.";

            }

            else
            { LblAnswer.Text = $"{num1} es igual a {num2}."; }
        }
    }
    
}
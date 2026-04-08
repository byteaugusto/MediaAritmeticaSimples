using static System.Net.Mime.MediaTypeNames;

namespace MediaAritmeticaSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            bool v1 = ValidarCampo(txtValor1);
            bool v2 = ValidarCampo(txtValor2);
            bool v3 = ValidarCampo(txtValor3);
            if (v1 && v2 && v3)
            {
                Double.TryParse(txtValor1.Text, out double n1);
                Double.TryParse(txtValor2.Text, out double n2);
                Double.TryParse(txtValor3.Text, out double n3);
                double media = (n1 + n2 + n3) / 3;
                lbMedia.Text = media.ToString();
            }

        }
        private bool ValidarCampo(TextBox txt)
        {
           if (Double.TryParse(txt.Text, out double v1) && (v1 >= 0 && v1 <= 10)){
                txt.BackColor = Color.White;
                return true;
            }
            else
            {
                txt.BackColor = Color.Red;
                return false;
            }
        }


    }
}




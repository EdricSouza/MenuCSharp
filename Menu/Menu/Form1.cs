using Microsoft.VisualBasic.ApplicationServices;
using System.IO;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_EnviarV_Click(object sender, EventArgs e)
        {
            StreamWriter arquivo = new StreamWriter("C:\\Users\\aluno\\Desktop\\IFBACadastro\\IFBAVendedor\\cadastro.txt");
            arquivo.WriteLine("Nome do vendedor: " + textBox_Nome.Text);
            arquivo.WriteLine("Quantia da comissão: " + textBox_Comissao.Text);
            arquivo.WriteLine("Área: " + textBox_Area.Text + "\n\r");

            arquivo.Close();
        }

        private void btn_EnviarS_Click(object sender, EventArgs e)
        {
            StreamWriter arquivo2 = new StreamWriter("C: \\Users\\aluno\\Desktop\\IFBACadastro\\IFBASocio\\cadastro.txt");
            arquivo2.WriteLine("Nome do Sócio: " + textBox_Nome.Text);
            arquivo2.WriteLine("Data de Nascimento: " + );
            arquivo2.WriteLine("Área: " + textBox_Area.Text + "\n\r");
        }
    }
}
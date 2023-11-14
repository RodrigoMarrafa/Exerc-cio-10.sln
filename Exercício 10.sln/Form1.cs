namespace Exercício_10.sln
{
    using Microsoft.VisualBasic;
    public partial class Form1 : Form
    {
        public string password;
        public string passwordcerta;
        public Form1()
        {
            InitializeComponent();
            passwordcerta = "password";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            password = Interaction.InputBox("Insira a palavra-passe","Password","******");
            if (password == passwordcerta)
            {
                MessageBox.Show("Acesso válido");
            }
            else
                MessageBox.Show("Acesso inválido");
        }
        //clash
        private void button2_Click(object sender, EventArgs e)
        {
            passwordcerta = Interaction.InputBox("Insira a nova palavra-passe");
            MessageBox.Show("palavra-passe alterada com sucesso");
        }
    }
}
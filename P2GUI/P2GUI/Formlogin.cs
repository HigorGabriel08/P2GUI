namespace P2GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsuario.Text) || string.IsNullOrEmpty(textBoxSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBoxUsuario.Text == "admin" && textBoxSenha.Text == "123") { 
            
            var principalForm = new Form_Principal();
                principalForm.Show();

            }
            else
            {
                MessageBox.Show("Usu�rio ou senha inv�lidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // oculta a tela de Login
            this.Hide();
            // criar uma instancia de FrmPrincipal
            var frmPrincipal = new FrmPrincipal();
            // exibe a tela principal
            frmPrincipal.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // fecha a tela de login
            Close();
            // encerra o aplicativo
            Application.Exit();
        }
    }
}

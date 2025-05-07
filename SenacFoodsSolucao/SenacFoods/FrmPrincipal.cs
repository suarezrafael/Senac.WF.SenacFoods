namespace SenacFoods
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nome, string senha)
        {
            InitializeComponent();
            // exibe o nome do usuario na tela principal
            lblMensagem.Text = "Bem Vindo " + nome;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // fecha a tela principal
            Close();
            // cria uma instancia da tela de login
            var frmLogin = new FrmLogin();
            // exibe a tela de login
            frmLogin.Show();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            // cria uma instancia do FrmCardapio
            var frmCardapio = new FrmCardapio();
            // exibe a tela de cardapio em estilo modal()
            frmCardapio.ShowDialog();
        }

        private void btnMInimizar_Click(object sender, EventArgs e)
        {
            // altera o estado da tela  
            // para o estado minimizado
            WindowState = FormWindowState.Minimized;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var frmComanda = new FrmComanda();
            frmComanda.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            var frmPedido = new FrmPedidoCozinha();
            frmPedido.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}

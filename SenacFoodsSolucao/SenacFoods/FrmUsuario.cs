namespace SenacFoods
{
    class UsuarioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }

    public partial class FrmUsuario : Form
    {

        List<UsuarioDto> usuarios = new List<UsuarioDto>()
        {
            new UsuarioDto(){Id = 1, Nome = "Rafael", Email = "rafael@hotmail.com"}
        };
        public FrmUsuario()
        {
            InitializeComponent();
            dataGridView1.DataSource = usuarios;
        }
    }
}

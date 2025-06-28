namespace SenacFoods
{
    public partial class FrmCardapio : Form
    {
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            // conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                // consultar a tabela cardapioitem SELECT * FROM CARDAPIO
                var cardapios = bd.CardapioItems.ToList();
                // popular o grid com a tabela consultada
                dataGridView1.DataSource = cardapios;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
        }
    }
}

namespace SenacFoods
{
    public partial class FrmCardapio : Form
    {
        CardapioItem? cardapioSelecionado;

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
            using (var bancoDeDados = new ComandaDBContext())
            {
                // consultar a tabela cardapioitem SELECT * FROM CARDAPIO
                var cardapios = bancoDeDados.CardapioItems.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    cardapios = cardapios.Where(c => c.Titulo.Contains(txtPesquisa.Text) ||
                                                    c.Descricao.Contains(txtPesquisa.Text));
                }

                // popular o grid com a tabela consultada
                dataGridView1.DataSource = cardapios.ToList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCardapio();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // chamar o metodo buscar cardapio
            BuscarCardapio();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // pegar o cardapio selecionado
                cardapioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as CardapioItem;
                btnEditar.Enabled = true;
            }
        }

        // Clique do Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                // abrir o formulario de edição
                var banana = new FrmCardapioCad(cardapioSelecionado);
                banana.ShowDialog();
                // atualizar a lista de cardápios
                BuscarCardapio();
                cardapioSelecionado = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.CardapioItems.Remove(cardapioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Cardápio excluído com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCardapio();
                cardapioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um cardápio para excluir.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

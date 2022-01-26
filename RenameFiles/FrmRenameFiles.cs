namespace RenameFiles
{
    public partial class FrmRenameFiles : Form
    {
        private string _pastaSelecionada;

        public bool CamposObrigatoriosOK
        {
            get
            {
                return PastaSelecionada && !string.IsNullOrWhiteSpace(txtTextoRemover.Text);
            }
        }

        public bool PastaSelecionada
        {
            get
            {
                return lblPastaSelecionada.Text != "Nenhuma pasta selecionada.";
            }
        }

        public FrmRenameFiles()
        {
            InitializeComponent();
        }

        private void BtnRenomearArquivos_Click(object sender, EventArgs e)
        {
            if (CamposObrigatoriosOK)
            {
                if (lstArquivosRenomear.Items.Count > 0)
                {
                    RenomearArquivos();
                }
                else
                {
                    Mensagem("Nenhum arquivo encontrado na pasta selecioanda para ser renomeado!");
                }
            }
            else
            {
                var msgErro = PastaSelecionada ?
                    "Digite ao menos um caracter/palavra que deseja remover do nome dos arquivos." :
                    "Selecione uma pasta para listar os arquivos!";
                Mensagem(msgErro, true);
            }
        }

        private void BtnSelecionarPasta_Click(object sender, EventArgs e)
        {
            fbdSelecionarPasta.ShowDialog();
            _pastaSelecionada = fbdSelecionarPasta.SelectedPath;
            ListarArquivosDaPasta();
        }

        private void LstArquivosRenomear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTextoRemover.Text = lstArquivosRenomear.SelectedItem.ToString();
        }

        private void ListarArquivosDaPasta()
        {
            if (!string.IsNullOrWhiteSpace(_pastaSelecionada))
            {
                lstArquivosRenomear.Items.Clear();
                lblPastaSelecionada.Text = _pastaSelecionada;

                foreach (var arquivo in Directory.GetFiles(_pastaSelecionada))
                {
                    lstArquivosRenomear.Items.Add(arquivo.Replace(_pastaSelecionada + "\\", string.Empty));
                }
            }
        }

        private static void Mensagem(string msg, bool erro = false)
        {
            MessageBox.Show(msg, erro ? "Atenção!" : "Informação:", MessageBoxButtons.OK,
                erro ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }

        private void RenomearArquivos()
        {
            foreach (var arquivo in Directory.GetFiles(_pastaSelecionada))
            {
                if (!string.IsNullOrWhiteSpace(arquivo.Replace(txtTextoRemover.Text, string.Empty)))
                {
                    File.Move(arquivo, arquivo.Replace(txtTextoRemover.Text, string.Empty));
                }
            }

            ListarArquivosDaPasta();

            Mensagem("Processo finalizado com sucesso!");
        }
    }
}

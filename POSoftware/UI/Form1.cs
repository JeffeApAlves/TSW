using POSoftware.Infra;
using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Tyco.Application;
using Tyco.Infra.IoC;

namespace POSoftware
{
    enum STATUS_FORM { NONE, READ, ONLY, EDIT, NEW, FILTER };

    public partial class Form1 : Form
    {
        /// <summary>
        /// unico user interface
        /// </summary>
        /// 

        // TODO Criar repositorios de textos para dar suporte a multilingua
        // TODO Levantar requisitos de UI e implementalos
        // TODO criar class library para cada camada


        private static UdpClient client;

        const string FORMAT_DATA = "dd/MM/yy";          //formato data
        const string FORMAT_HORA = "HH:mm";             //formato hora

        private STATUS_FORM status_form;

        public Form1()
        {
            InitializeComponent();

            IoC.Init();                                 // inicializa servicelocator
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearForm();

            FormmodoRead();

            LoadAllSupplier();

            LoadHistorico();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (validadeFields())
            {
                if (status_form == STATUS_FORM.NEW)
                {
                    InsertSupplier();

                    LoadAllSupplier();
                }

                if (status_form == STATUS_FORM.EDIT)
                {
                    if (dataGridView.CurrentRow != null)
                    {
                        UpdateSupplier();

                        LoadAllSupplier();

                        LoadHistorico();
                    }
                }

                FormmodoRead();
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                FilterByCNPJ(filterCNPJ.Text);
            }
        }

        private void filterData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                FilterByData(filterData.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                FormmodoEdit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (status_form != STATUS_FORM.NEW)
            {
                FormmodoNew();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                string message = "Deseja excluir esse fornecedor?";
                string caption = "Alteracao na base de fornecedores";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    RemoveSupplier();

                    ClearForm();

                    LoadAllSupplier();
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            FillForm();

            FormmodoRead();

            LoadHistorico();
        }

        /// <summary>
        /// Atualiza formulario com as informacoes da lista
        /// </summary>
        /// 
        private void FillForm()
        {
            ClearForm();

            try
            {
                cnpjTB.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                razaoTB.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                dataTB.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                obsTB.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
                pagamentoCB.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                // TODO tratar erro quando informacoes da lista nao estiverem errada
            }
        }

        // TODO Criar metodo de formatacao

        /// <summary>
        /// carrega e format lista de log
        /// </summary>
        /// 
        private void LoadHistorico()
        {
            HistoricoApplication app = new HistoricoApplication();

            historicoGV.DataSource = app.GetByCNPJ(cnpjTB.Text);

            historicoGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            historicoGV.Columns[0].Visible = false;
            historicoGV.Columns[1].Width = 100;
            historicoGV.Columns[2].Width = 80;
            historicoGV.Columns[3].Width = 100;
            historicoGV.Columns[4].Width = 90;
        }

        // TODO Criar metodo de formatacao

        /// <summary>
        /// carrega e format lista de supplier
        /// </summary>
        /// 
        private void LoadAllSupplier()
        {
            SupplierApplication app = new SupplierApplication();

            dataGridView.DataSource = app.Get();

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 270;
            dataGridView.Columns[3].Width = 80;
            dataGridView.Columns[4].Width = 80;
            dataGridView.Columns[5].Width = 265;
        }

        /// <summary>
        /// Filtro via CNPJ
        /// </summary>
        /// 
        private void FilterByCNPJ(string cnpj)
        {
            SupplierApplication sr = new SupplierApplication();

            dataGridView.DataSource = sr.GetByCNPJ(cnpj);
        }

        /// <summary>
        /// Filtro via data
        /// </summary>
        /// 
        private void FilterByData(string data)
        {
            SupplierApplication sr = new SupplierApplication();

            dataGridView.DataSource = sr.GetByData(data);
        }

        /// <summary>
        /// Inclui fornecedor
        /// </summary>
        /// 
        private void InsertSupplier()
        {
            SupplierApplication sr = new SupplierApplication();
            Supplier supplier = new Supplier();

            supplier.CNPJ = cnpjTB.Text;
            supplier.CreateDate = dataTB.Text;
            supplier.Observacao = obsTB.Text;
            supplier.RazaoSocial = razaoTB.Text;
            supplier.payment = pagamentoCB.Text;

            sr.Register(supplier);

            RegistraHistorico(supplier, "Added");

            sendNotificacao("Registro criado - CNPJ: " + supplier.CNPJ + " - " + supplier.RazaoSocial);
        }

        /// <summary>
        /// Exclui fornecedor
        /// </summary>
        /// 
        private void RemoveSupplier()
        {
            SupplierApplication app = new SupplierApplication();
            Supplier supplier = app.Get(Convert.ToInt32((dataGridView.CurrentRow.Cells[0].Value.ToString())));

            app.Remove(Convert.ToInt32((dataGridView.CurrentRow.Cells[0].Value.ToString())));

            RegistraHistorico(supplier, "Removed");
        }

        /// <summary>
        /// Atualiza fornecedor
        /// </summary>
        /// 
        private void UpdateSupplier()
        {
            SupplierApplication app = new SupplierApplication();
            Supplier supplier = app.Get(Convert.ToInt32((dataGridView.CurrentRow.Cells[0].Value.ToString())));

            supplier.CreateDate = dataTB.Text;
            supplier.Observacao = obsTB.Text;
            supplier.RazaoSocial = razaoTB.Text;
            supplier.payment = pagamentoCB.Text;

            app.Update(supplier);

            RegistraHistorico(supplier, "Updated");
        }

        /// <summary>
        /// Registra historico de alteracoes na base fornecedor
        /// </summary>
        /// 
        private void RegistraHistorico(Supplier supplier, string operacao)
        {
            HistoricoApplication app = new HistoricoApplication();

            LogInfo info = new LogInfo();

            info.CNPJ = supplier.CNPJ;
            info.Date = DateTime.Now.ToString(FORMAT_DATA);
            info.Hora = DateTime.Now.ToString(FORMAT_HORA);
            info.Operacao = operacao;

            app.Register(info);
        }

        /// <summary>
        /// limpa os campos
        /// </summary>
        /// 
        private void ClearForm()
        {
            cnpjTB.Text = "";
            razaoTB.Text = "";
            dataTB.Text = DateTime.Now.ToString(FORMAT_DATA);
            obsTB.Text = "";
            pagamentoCB.SelectedIndex = 0;
        }

        /// <summary>
        /// Coloca o form em modo edicao com os campos limpos para insercao de um novo supplier
        /// </summary>
        /// 
        private void FormmodoNew()
        {
            ClearForm();

            status_form = STATUS_FORM.NEW;

            cnpjTB.ReadOnly = false;
            razaoTB.ReadOnly = false;
            obsTB.ReadOnly = false;
            pagamentoCB.Enabled = true;
            button4.Enabled = true;
            cnpjTB.Focus();
        }

        /// <summary>
        /// Coloca o form em modo leitura para visualizacao de informacoes seleciona na lista
        /// </summary>
        /// 
        private void FormmodoRead()
        {
            status_form = STATUS_FORM.READ;

            cnpjTB.ReadOnly = true;
            razaoTB.ReadOnly = true;
            dataTB.ReadOnly = true;
            obsTB.ReadOnly = true;
            button4.Enabled = false;

            dataGridView.Focus();
            pagamentoCB.Enabled = false;
        }

        /// <summary>
        /// Coloca o form em modo Edit para atualizacao de informacoes do supplier
        /// </summary>
        /// 
        private void FormmodoEdit()
        {
            status_form = STATUS_FORM.EDIT;
            razaoTB.ReadOnly = false;
            dataTB.ReadOnly = false;
            obsTB.ReadOnly = false;
            pagamentoCB.Enabled = true;
            button4.Enabled = true;
            razaoTB.Focus();
        }

        /// <summary>
        /// Validacao de dados da camada UI
        /// </summary>
        private bool validadeFields()
        {
            bool flg_ret = true;
            string message = "";

            SupplierApplication app = new SupplierApplication();

            if (cnpjTB.Text == null || cnpjTB.Text.Length < 14 || app.ExistCNPJ(cnpjTB.Text))
            {

                flg_ret = false;

                message = "Verificar CNPJ";
            }

            if (dataTB.Text == null || dataTB.Text.Length < 8)
            {

                flg_ret = false;

                message = "Data incorreta";
            }

            if (razaoTB.Text == null || razaoTB.Text.Length < 1)
            {

                flg_ret = false;

                message = "Razao social incorreta";
            }

            if (pagamentoCB.Text == null || pagamentoCB.Text.Length < 1)
            {

                flg_ret = false;

                message = "Pagamento nao selecionado";
            }

            if (!flg_ret)
            {
                MessageBox.Show(message, "Verificacao dos dados", MessageBoxButtons.OK);
            }

            return flg_ret;
        }

        // TODO Cria classe especifica com esse metodo para a notficacao
        // TODO Tratar falhas de conexao

        /// <summary>
        /// Metodo para envio da notifica para o software ActiveSupplier
        /// </summary>
        static void sendNotificacao(String message)
        {
            client = new UdpClient("127.0.0.1", 9999);

            Console.WriteLine("Client connection");

            byte[] data = Encoding.ASCII.GetBytes(message);

            client.Send(data, data.Length);
        }
    }
}

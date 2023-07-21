namespace Aula10Estacionamento
{
    public partial class Form1 : Form
    {

        List<string> estacionamento = new List<string>();
        List<int> carros= new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        //Funções

        void atualizaInterface()
        {
            int placas_cadastradas = estacionamento.Count;
            lblVeículos.Text = estacionamento.ToString();
        }

        public bool  textBoxEstaVazio( TextBox txt )
        {
            if( txt.Text == "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            if(estacionamento.Count >= 6 )
            {
                MessageBox.Show("Ta lotado mano vaza");
                return;
            }
            if(txtPlaca.Text == "")
            {
                MessageBox.Show("Preencha o campo para continuar");
                return;
            }

            string placa = txtPlaca.Text;
            estacionamento.Add( placa );
            

            lblVeículos.Text= estacionamento.Count.ToString();

            ListaEstacionamento.Items.Clear();

            for (int i = 0; i < estacionamento.Count; i++)
            {
                ListaEstacionamento.Items.Add($"[VAGA {i}] - {estacionamento[i]}");
            }
            atualizaInterface();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            estacionamento.Remove(txtPlaca.Text);
        }
    }
}
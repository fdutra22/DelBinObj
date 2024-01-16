namespace DevDelBo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtB1.Text))
            {
                var texto = txtB1.Text;
                Deletador.Deleter(texto);
            }
        }
    }
}
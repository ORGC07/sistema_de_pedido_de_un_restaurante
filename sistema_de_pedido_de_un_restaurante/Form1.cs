namespace sistema_de_pedido_de_un_restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var conf = new Form2();
            conf.pedido.Text = "Helado";
            conf.precio.Text = "200";

           
            conf.Show();
           
        }

        private void pastelon_Click(object sender, EventArgs e)
        {
            var conf = new Form2();
            conf.pedido.Text = "Pastelon";
            conf.precio.Text = "1400";
            conf.Show();
            
        }

        private void canelones_Click(object sender, EventArgs e)
        {
            var conf = new Form2();
            conf.pedido.Text = "Canelones";
            conf.precio.Text = "1800";
          
            conf.Show();
        }

        private void cheesecake_Click(object sender, EventArgs e)
        {
            var conf = new Form2();
            conf.pedido.Text = "Cheesecake";
            conf.precio.Text = "2000";
            conf.Show();
                 }

        private void Mofongo_Click(object sender, EventArgs e)
        {
            var conf = new Form2();
            conf.pedido.Text = "Mofongo";
            conf.precio.Text = "1100";
            conf.Show();
        }

        private void Ramen_Click(object sender, EventArgs e)
        {
            var conf = new Form2();
            conf.pedido.Text = "Ramen";
            conf.precio.Text = "2400";
            conf.Show();
        }
    }
}
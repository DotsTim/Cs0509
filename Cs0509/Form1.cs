namespace Cs0509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ìØä˙èàóù//
            MessageBox.Show("Ç±ÇÒÇ…ÇøÇÕ");

            buttonProperty.Text = "âüÇ≥ÇÍÇΩ";
            buttonProperty.Left = 0;
            buttonProperty.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Left = button1.Left + 10;
            button1.Top = button1.Top + 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            humen.Top = humen.Top - 10;
        }

        private void DOWN_Click(object sender, EventArgs e)
        {
            humen.Top = humen.Top + 10;
        }

        private void RIGHT_Click(object sender, EventArgs e)
        {
            humen.Left = humen.Left + 10;
        }

        private void LEFT_Click(object sender, EventArgs e)
        {
            humen.Left = humen.Left - 10;
        }

        private void Dash_Click(object sender, EventArgs e)
        {
            humen.Left = humen.Left + 50;
           
        }
    }
}

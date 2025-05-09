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
            //“¯Šúˆ—//
           MessageBox.Show("‚±‚ñ‚É‚¿‚Í");
              
           buttonProperty.Text = "‰Ÿ‚³‚ê‚½";
           buttonProperty.Left = 0; 
            buttonProperty.Visible = false;
        }
    }
}

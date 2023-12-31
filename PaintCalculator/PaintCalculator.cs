namespace PaintCalculator
{
    public partial class PaintCalculator : Form
    {
        public PaintCalculator()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!Decimal.TryParse(textBox.Text, out decimal value) || value < 0M)
            {
                textBox.BackColor = Color.Red;
                return;
            }

            // Update measurement value and UI.
        }
    }
}

namespace PaintCalculator
{
    public partial class PaintCalculator : Form
    {
        private double Factor = 350;
        public PaintCalculator()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!Double.TryParse(textBox.Text, out double value) || value < 0)
            {
                textBox.BackColor = Color.Red;
                return;
            }

            // Update measurement value and UI.
            double area = 0;
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    area = Double.Parse(RoomLength.Text) * Double.Parse(RoomWidth.Text);
                    break;
                case 1:
                    area = Math.PI * Math.Pow((Double.Parse(Diameter.Text) / 2), 2);
                    break;
                case 2:
                    area = Double.Parse(A.Text) * Double.Parse(B.Text) +
                           (Double.Parse(C.Text) - Double.Parse(A.Text)) *
                           Double.Parse(D.Text);
                    break;
            }
            GallonsNeeded.Text = Math.Round((area / Factor), 0, MidpointRounding.ToPositiveInfinity).ToString();
        }
    }
}

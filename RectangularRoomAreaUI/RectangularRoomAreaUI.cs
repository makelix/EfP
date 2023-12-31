//using static RectangularRoomArea;

namespace RectangularRoomAreaUI
{
    public partial class RectangularRoomAreaUI : Form
    {
        private decimal _length = 0M;
        private decimal _width = 0M;

        public RectangularRoomAreaUI()
        {
            InitializeComponent();
        }

        private void Measurement_Changed(object sender, EventArgs e)
        {
            // Validate input.
            TextBox textBox = (TextBox)sender;
            if (!Decimal.TryParse(textBox.Text, out decimal value) || value < 0M)
            {
                textBox.BackColor = Color.Red;
                return;
            }

            // Update measurement value and UI.
            if (textBox.Name.Equals("RoomLength"))
                _length = value;
            else
                _width = value;
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Calculate areas.
            decimal areaInSquareFeet;
            decimal areaInSquareMeters;
            if (Feet.Checked)
            {
                areaInSquareFeet = _length * _width;
                areaInSquareMeters = RectangularRoomArea.SquareFeetToSquareMeters(areaInSquareFeet);
            }
            else
            {
                areaInSquareMeters = _length * _width;
                areaInSquareFeet = RectangularRoomArea.SquareMetersToSquareFeet(areaInSquareMeters);
            }

            // Update UI.
            RoomLength.BackColor = Color.White;
            RoomWidth.BackColor = Color.White;
            SquareFeet.Text = Math.Round(areaInSquareFeet, 3, MidpointRounding.ToEven).ToString("0.000");
            SquareMeters.Text = Math.Round(areaInSquareMeters, 3, MidpointRounding.ToEven).ToString("0.000");
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}

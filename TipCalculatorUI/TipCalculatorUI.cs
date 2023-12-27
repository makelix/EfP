using TipCalculatorNS;

namespace TipCalculatorUI

{
    public partial class TipCalculatorUI : Form
    {
        private TipCalculator TipCalculator = new();

        public TipCalculatorUI()
        {
            InitializeComponent();
        }

        private void BillAmount_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(BillAmount.Text, out decimal value)
                && Decimal.IsPositive(value))
            {
                TipCalculator.BillAmount = value;
                Tip.Text = TipCalculator.TipAsString;
                Total.Text = TipCalculator.TotalAsString;
            }
        }

        private void TipRate_Scroll(object sender, EventArgs e)
        {
            TipCalculator.TipRate = TipRate.Value;
            Tip.Text = TipCalculator.TipAsString;
            Total.Text = TipCalculator.TotalAsString;
        }
    }
}

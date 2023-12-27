


namespace TipCalculatorUI
{
    partial class TipCalculatorUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            tableLayoutPanel1 = new TableLayoutPanel();
            Tip = new Label();
            Total = new Label();
            BillAmount = new TextBox();
            TipRate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Bill amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 25);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Tip rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 2;
            label3.Text = "Tip";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 75);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Total";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(Tip, 1, 2);
            tableLayoutPanel1.Controls.Add(Total, 1, 3);
            tableLayoutPanel1.Controls.Add(BillAmount, 1, 0);
            tableLayoutPanel1.Controls.Add(TipRate, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(183, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Tip
            // 
            Tip.AutoSize = true;
            Tip.Dock = DockStyle.Fill;
            Tip.Location = new Point(77, 50);
            Tip.Name = "Tip";
            Tip.Size = new Size(103, 25);
            Tip.TabIndex = 4;
            Tip.Text = "$0.00";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Dock = DockStyle.Fill;
            Total.Location = new Point(77, 75);
            Total.Name = "Total";
            Total.Size = new Size(103, 25);
            Total.TabIndex = 5;
            Total.Text = "$0.00";
            // 
            // BillAmount
            // 
            BillAmount.Dock = DockStyle.Fill;
            BillAmount.Location = new Point(77, 3);
            BillAmount.Name = "BillAmount";
            BillAmount.Size = new Size(103, 23);
            BillAmount.TabIndex = 6;
            BillAmount.Text = "0";
            BillAmount.TextChanged += BillAmount_TextChanged;
            // 
            // TipRate
            // 
            TipRate.Dock = DockStyle.Fill;
            TipRate.Location = new Point(77, 28);
            TipRate.Name = "TipRate";
            TipRate.Size = new Size(103, 23);
            TipRate.TabIndex = 7;
            TipRate.Text = "0";
            TipRate.TextChanged += TipRate_TextChanged;
            // 
            // TipCalculatorUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 104);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TipCalculatorUI";
            Text = "TipCalculator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Tip;
        private Label Total;
        private TextBox BillAmount;
        private TextBox TipRate;
    }
}

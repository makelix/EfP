namespace RectangularRoomAreaUI
{
    partial class RectangularRoomAreaUI
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
            TableLayoutPanel tableLayoutPanel1;
            GroupBox groupBox1;
            Label label2;
            Label label1;
            GroupBox groupBox2;
            GroupBox groupBox3;
            Label label4;
            Label label3;
            RoomLength = new TextBox();
            RoomWidth = new TextBox();
            Meters = new RadioButton();
            Feet = new RadioButton();
            SquareMeters = new TextBox();
            SquareFeet = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(396, 192);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RoomLength);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(RoomWidth);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Measurements";
            // 
            // RoomLength
            // 
            RoomLength.Location = new Point(69, 22);
            RoomLength.Name = "RoomLength";
            RoomLength.Size = new Size(66, 23);
            RoomLength.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 25);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "&Length";
            // 
            // RoomWidth
            // 
            RoomWidth.Location = new Point(69, 51);
            RoomWidth.Name = "RoomWidth";
            RoomWidth.Size = new Size(66, 23);
            RoomWidth.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 54);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "&Width";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Meters);
            groupBox2.Controls.Add(Feet);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(203, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(194, 94);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Units";
            // 
            // Meters
            // 
            Meters.AutoSize = true;
            Meters.Location = new Point(6, 50);
            Meters.Name = "Meters";
            Meters.Size = new Size(61, 19);
            Meters.TabIndex = 1;
            Meters.TabStop = true;
            Meters.Text = "&Meters";
            Meters.UseVisualStyleBackColor = true;
            // 
            // Feet
            // 
            Feet.AutoSize = true;
            Feet.Location = new Point(6, 21);
            Feet.Name = "Feet";
            Feet.Size = new Size(47, 19);
            Feet.TabIndex = 0;
            Feet.TabStop = true;
            Feet.Text = "&Feet";
            Feet.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(SquareMeters);
            groupBox3.Controls.Add(SquareFeet);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 103);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(394, 94);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Area";
            // 
            // SquareMeters
            // 
            SquareMeters.Location = new Point(9, 51);
            SquareMeters.Name = "SquareMeters";
            SquareMeters.ReadOnly = true;
            SquareMeters.Size = new Size(100, 23);
            SquareMeters.TabIndex = 2;
            SquareMeters.Text = "0.000";
            // 
            // SquareFeet
            // 
            SquareFeet.Location = new Point(9, 22);
            SquareFeet.Name = "SquareFeet";
            SquareFeet.ReadOnly = true;
            SquareFeet.Size = new Size(100, 23);
            SquareFeet.TabIndex = 0;
            SquareFeet.Text = "0.000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 54);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "square meters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 25);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 1;
            label3.Text = "square feet";
            // 
            // RectangularRoomAreaUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 192);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RectangularRoomAreaUI";
            Text = "Room Area Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox RoomLength;
        private TextBox RoomWidth;
        private RadioButton Meters;
        private RadioButton Feet;
        private Label label4;
        private Label label3;
        private TextBox SquareMeters;
        private TextBox SquareFeet;
    }
}

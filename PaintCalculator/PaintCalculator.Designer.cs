

namespace PaintCalculator
{
    partial class PaintCalculator
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
            PictureBox pictureBox1;
            Label label2;
            Label label1;
            PictureBox pictureBox2;
            Label label3;
            PictureBox pictureBox3;
            Label label7;
            Label label6;
            Label label5;
            Label label4;
            TabControl = new TabControl();
            Rectangle = new TabPage();
            RoomWidth = new TextBox();
            RoomLength = new TextBox();
            Circle = new TabPage();
            Diameter = new TextBox();
            Lshaped = new TabPage();
            D = new TextBox();
            C = new TextBox();
            B = new TextBox();
            A = new TextBox();
            label8 = new Label();
            GallonsNeeded = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            TabControl.SuspendLayout();
            Rectangle.SuspendLayout();
            Circle.SuspendLayout();
            Lshaped.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(173, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 113);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 38);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "&Width";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "&Length";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(173, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 113);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 9);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 0;
            label3.Text = "&Diameter";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(173, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 113);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 96);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 6;
            label7.Text = "&d";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 67);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 4;
            label6.Text = "&c";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 38);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 2;
            label5.Text = "&b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 9);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 0;
            label4.Text = "&a";
            // 
            // TabControl
            // 
            TabControl.Controls.Add(Rectangle);
            TabControl.Controls.Add(Circle);
            TabControl.Controls.Add(Lshaped);
            TabControl.HotTrack = true;
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.ShowToolTips = true;
            TabControl.Size = new Size(291, 156);
            TabControl.TabIndex = 0;
            // 
            // Rectangle
            // 
            Rectangle.Controls.Add(pictureBox1);
            Rectangle.Controls.Add(RoomWidth);
            Rectangle.Controls.Add(label2);
            Rectangle.Controls.Add(RoomLength);
            Rectangle.Controls.Add(label1);
            Rectangle.Location = new Point(4, 24);
            Rectangle.Name = "Rectangle";
            Rectangle.Padding = new Padding(3);
            Rectangle.Size = new Size(283, 128);
            Rectangle.TabIndex = 0;
            Rectangle.Text = "Rectangle";
            Rectangle.UseVisualStyleBackColor = true;
            // 
            // RoomWidth
            // 
            RoomWidth.Location = new Point(67, 35);
            RoomWidth.Name = "RoomWidth";
            RoomWidth.Size = new Size(100, 23);
            RoomWidth.TabIndex = 3;
            RoomWidth.Text = "0";
            RoomWidth.TextChanged += TextBox_TextChanged;
            // 
            // RoomLength
            // 
            RoomLength.Location = new Point(67, 6);
            RoomLength.Name = "RoomLength";
            RoomLength.Size = new Size(100, 23);
            RoomLength.TabIndex = 1;
            RoomLength.Text = "0";
            RoomLength.TextChanged += TextBox_TextChanged;
            // 
            // Circle
            // 
            Circle.Controls.Add(pictureBox2);
            Circle.Controls.Add(Diameter);
            Circle.Controls.Add(label3);
            Circle.Location = new Point(4, 24);
            Circle.Name = "Circle";
            Circle.Padding = new Padding(3);
            Circle.Size = new Size(283, 128);
            Circle.TabIndex = 1;
            Circle.Text = "Circle";
            Circle.UseVisualStyleBackColor = true;
            // 
            // Diameter
            // 
            Diameter.Location = new Point(67, 6);
            Diameter.Name = "Diameter";
            Diameter.Size = new Size(100, 23);
            Diameter.TabIndex = 1;
            Diameter.Text = "0";
            Diameter.TextChanged += TextBox_TextChanged;
            // 
            // Lshaped
            // 
            Lshaped.Controls.Add(pictureBox3);
            Lshaped.Controls.Add(D);
            Lshaped.Controls.Add(label7);
            Lshaped.Controls.Add(C);
            Lshaped.Controls.Add(label6);
            Lshaped.Controls.Add(B);
            Lshaped.Controls.Add(label5);
            Lshaped.Controls.Add(A);
            Lshaped.Controls.Add(label4);
            Lshaped.Location = new Point(4, 24);
            Lshaped.Name = "Lshaped";
            Lshaped.Size = new Size(283, 128);
            Lshaped.TabIndex = 2;
            Lshaped.Text = "L-shaped";
            Lshaped.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            D.Location = new Point(67, 93);
            D.Name = "D";
            D.Size = new Size(100, 23);
            D.TabIndex = 7;
            D.Text = "0";
            D.TextChanged += TextBox_TextChanged;
            // 
            // C
            // 
            C.Location = new Point(67, 64);
            C.Name = "C";
            C.Size = new Size(100, 23);
            C.TabIndex = 5;
            C.Text = "0";
            C.TextChanged += TextBox_TextChanged;
            // 
            // B
            // 
            B.Location = new Point(67, 35);
            B.Name = "B";
            B.Size = new Size(100, 23);
            B.TabIndex = 3;
            B.Text = "0";
            B.TextChanged += TextBox_TextChanged;
            // 
            // A
            // 
            A.Location = new Point(67, 6);
            A.Name = "A";
            A.Size = new Size(100, 23);
            A.TabIndex = 1;
            A.Text = "0";
            A.TextChanged += TextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 171);
            label8.Name = "label8";
            label8.Size = new Size(182, 15);
            label8.TabIndex = 1;
            label8.Text = "Gallons required to paint the area";
            // 
            // GallonsNeeded
            // 
            GallonsNeeded.Location = new Point(204, 168);
            GallonsNeeded.Name = "GallonsNeeded";
            GallonsNeeded.ReadOnly = true;
            GallonsNeeded.Size = new Size(95, 23);
            GallonsNeeded.TabIndex = 2;
            GallonsNeeded.Text = "0";
            // 
            // PaintCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 200);
            Controls.Add(GallonsNeeded);
            Controls.Add(label8);
            Controls.Add(TabControl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaintCalculator";
            Text = "Paint Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            TabControl.ResumeLayout(false);
            Rectangle.ResumeLayout(false);
            Rectangle.PerformLayout();
            Circle.ResumeLayout(false);
            Circle.PerformLayout();
            Lshaped.ResumeLayout(false);
            Lshaped.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TabControl;
        private TabPage Rectangle;
        private TabPage Circle;
        private TextBox RoomWidth;
        private TextBox RoomLength;
        private TabPage Lshaped;
        private TextBox Diameter;
        private TextBox D;
        private TextBox C;
        private TextBox B;
        private TextBox A;
        private Label label8;
        private TextBox GallonsNeeded;
    }
}

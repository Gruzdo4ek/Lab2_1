namespace WinFormsApp1
{
    partial class Form1
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
            chA = new TextBox();
            chB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chC = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // chA
            // 
            chA.Location = new Point(43, 15);
            chA.Name = "chA";
            chA.Size = new Size(150, 31);
            chA.TabIndex = 0;
            // 
            // chB
            // 
            chB.Location = new Point(43, 63);
            chB.Name = "chB";
            chB.Size = new Size(150, 31);
            chB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 2;
            label1.Text = "число а";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 69);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 3;
            label2.Text = "число b";
            label2.Click += label2_Click;
            // 
            // chC
            // 
            chC.Location = new Point(43, 115);
            chC.Name = "chC";
            chC.Size = new Size(150, 31);
            chC.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 121);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 5;
            label3.Text = "число c";
            // 
            // button1
            // 
            button1.Location = new Point(45, 170);
            button1.Name = "button1";
            button1.Size = new Size(243, 34);
            button1.TabIndex = 6;
            button1.Text = "Вывести min, middle, max";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 224);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(chC);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chB);
            Controls.Add(chA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox chA;
        private TextBox chB;
        private Label label2;
        public Label label1;
        private TextBox chC;
        private Label label3;
        private Button button1;
    }
}
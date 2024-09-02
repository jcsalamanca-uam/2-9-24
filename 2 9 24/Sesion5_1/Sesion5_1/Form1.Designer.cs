namespace Sesion5_1
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
            label1 = new Label();
            label2 = new Label();
            Tb1 = new TextBox();
            Tb2 = new TextBox();
            BtnMayor = new Button();
            LblAnswer = new Label();
            BtnMenor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 110);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 151);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 2";
            label2.Click += label2_Click;
            // 
            // Tb1
            // 
            Tb1.Location = new Point(435, 110);
            Tb1.Name = "Tb1";
            Tb1.Size = new Size(100, 23);
            Tb1.TabIndex = 2;
            Tb1.TextAlign = HorizontalAlignment.Right;
            Tb1.TextChanged += Tb1_TextChanged;
            // 
            // Tb2
            // 
            Tb2.Location = new Point(435, 151);
            Tb2.Name = "Tb2";
            Tb2.Size = new Size(100, 23);
            Tb2.TabIndex = 3;
            Tb2.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnMayor
            // 
            BtnMayor.Location = new Point(406, 216);
            BtnMayor.Name = "BtnMayor";
            BtnMayor.Size = new Size(129, 23);
            BtnMayor.TabIndex = 4;
            BtnMayor.Text = "Evaluar Mayor";
            BtnMayor.UseVisualStyleBackColor = true;
            BtnMayor.Click += button1_Click;
            // 
            // LblAnswer
            // 
            LblAnswer.BorderStyle = BorderStyle.Fixed3D;
            LblAnswer.Location = new Point(168, 219);
            LblAnswer.Name = "LblAnswer";
            LblAnswer.Size = new Size(209, 23);
            LblAnswer.TabIndex = 5;
            // 
            // BtnMenor
            // 
            BtnMenor.Location = new Point(406, 273);
            BtnMenor.Name = "BtnMenor";
            BtnMenor.Size = new Size(129, 23);
            BtnMenor.TabIndex = 6;
            BtnMenor.Text = "Evaluar menor";
            BtnMenor.UseVisualStyleBackColor = false;
            BtnMenor.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnMenor);
            Controls.Add(LblAnswer);
            Controls.Add(BtnMayor);
            Controls.Add(Tb2);
            Controls.Add(Tb1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sesión 5";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Tb1;
        private TextBox Tb2;
        private Button BtnMayor;
        private Label LblAnswer;
        private Button BtnMenor;
        private Button Btn2;
    }
}
namespace CalculadoraPrestamos
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
            label3 = new Label();
            label4 = new Label();
            txtM = new TextBox();
            txtA = new TextBox();
            txtI = new TextBox();
            txtR = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Monto Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 70);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Tasa de Interes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 123);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de años a Pagar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 234);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Resultado";
            // 
            // txtM
            // 
            txtM.Location = new Point(334, 32);
            txtM.Name = "txtM";
            txtM.Size = new Size(125, 27);
            txtM.TabIndex = 4;
            // 
            // txtA
            // 
            txtA.Location = new Point(334, 146);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 5;
            // 
            // txtI
            // 
            txtI.Location = new Point(334, 93);
            txtI.Name = "txtI";
            txtI.Size = new Size(125, 27);
            txtI.TabIndex = 6;
            // 
            // txtR
            // 
            txtR.Location = new Point(334, 267);
            txtR.Name = "txtR";
            txtR.Size = new Size(125, 27);
            txtR.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(348, 192);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtR);
            Controls.Add(txtI);
            Controls.Add(txtA);
            Controls.Add(txtM);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtM;
        private TextBox txtA;
        private TextBox txtI;
        private TextBox txtR;
        private Button btnCalcular;
    }
}

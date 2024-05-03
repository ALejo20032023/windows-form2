namespace CalculadoraCuotas
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
            I = new Label();
            label3 = new Label();
            label4 = new Label();
            txtM = new TextBox();
            txtR = new TextBox();
            txtC = new TextBox();
            txtI = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(351, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 0;
            label1.Text = "Monto";
            // 
            // I
            // 
            I.AutoSize = true;
            I.Font = new Font("Segoe UI", 14F);
            I.Location = new Point(351, 74);
            I.Name = "I";
            I.Size = new Size(86, 32);
            I.TabIndex = 1;
            I.Text = "Interes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(355, 139);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 2;
            label3.Text = "Meses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(312, 292);
            label4.Name = "label4";
            label4.Size = new Size(174, 32);
            label4.TabIndex = 3;
            label4.Text = "Cuota mensual";
            // 
            // txtM
            // 
            txtM.Location = new Point(335, 44);
            txtM.Name = "txtM";
            txtM.Size = new Size(125, 27);
            txtM.TabIndex = 4;
            // 
            // txtR
            // 
            txtR.Location = new Point(335, 342);
            txtR.Name = "txtR";
            txtR.Size = new Size(125, 27);
            txtR.TabIndex = 5;
            // 
            // txtC
            // 
            txtC.Location = new Point(335, 174);
            txtC.Name = "txtC";
            txtC.Size = new Size(125, 27);
            txtC.TabIndex = 6;
            // 
            // txtI
            // 
            txtI.Location = new Point(335, 109);
            txtI.Name = "txtI";
            txtI.Size = new Size(125, 27);
            txtI.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 14F);
            btnCalcular.Location = new Point(323, 227);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(137, 44);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtI);
            Controls.Add(txtC);
            Controls.Add(txtR);
            Controls.Add(txtM);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(I);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label I;
        private Label label3;
        private Label label4;
        private TextBox txtM;
        private TextBox txtR;
        private TextBox txtC;
        private TextBox txtI;
        private Button btnCalcular;
    }
}

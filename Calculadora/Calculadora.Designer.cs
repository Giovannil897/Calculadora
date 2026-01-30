namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Calcular = new Button();
            VariableB = new TextBox();
            VariableA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Calcular
            // 
            Calcular.Location = new Point(11, 114);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 13;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // VariableB
            // 
            VariableB.Location = new Point(11, 85);
            VariableB.Name = "VariableB";
            VariableB.Size = new Size(316, 23);
            VariableB.TabIndex = 12;
            // 
            // VariableA
            // 
            VariableA.Location = new Point(11, 41);
            VariableA.Name = "VariableA";
            VariableA.Size = new Size(316, 23);
            VariableA.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 67);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "Variable b";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 9;
            label1.Text = "Variable a";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 450);
            Controls.Add(Calcular);
            Controls.Add(VariableB);
            Controls.Add(VariableA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calcular;
        private TextBox VariableB;
        private TextBox VariableA;
        private Label label2;
        private Label label1;
    }
}
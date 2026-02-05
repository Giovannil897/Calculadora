namespace Calculadora
{
    partial class Registro
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btRegistrar = new Button();
            label3 = new Label();
            tbApellido = new TextBox();
            label2 = new Label();
            tbNombre = new TextBox();
            dtbFecha = new DateTimePicker();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvpersonas = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvpersonas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 449);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btRegistrar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(tbApellido);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(tbNombre);
            tabPage1.Controls.Add(dtbFecha);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(295, 67);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(75, 23);
            btRegistrar.TabIndex = 6;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 101);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha de nacimiento";
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(36, 75);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(217, 23);
            tbApellido.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 57);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(36, 31);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(217, 23);
            tbNombre.TabIndex = 2;
            // 
            // dtbFecha
            // 
            dtbFecha.Location = new Point(36, 119);
            dtbFecha.Name = "dtbFecha";
            dtbFecha.Size = new Size(217, 23);
            dtbFecha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 13);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvpersonas);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvpersonas
            // 
            dgvpersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpersonas.Location = new Point(0, 0);
            dgvpersonas.Name = "dgvpersonas";
            dgvpersonas.Size = new Size(794, 425);
            dgvpersonas.TabIndex = 0;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Registro";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvpersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private DateTimePicker dtbFecha;
        private TextBox tbNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbApellido;
        private Button btRegistrar;
        private DataGridView dgvpersonas;
    }
}
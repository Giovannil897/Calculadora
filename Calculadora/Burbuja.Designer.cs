
namespace Calculadora
{
    partial class Burbuja
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
            this.dgvDesordenado = new DataGridView();
            Desordenados = new DataGridViewTextBoxColumn();
            this.dgvOrdenado = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvDesordenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvOrdenado).BeginInit();
            SuspendLayout();
            // 
            // dgvDesordenado
            // 
            this.dgvDesordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesordenado.Columns.AddRange(new DataGridViewColumn[] { Desordenados });
            this.dgvDesordenado.Location = new Point(12, 12);
            this.dgvDesordenado.Name = "dgvDesordenado";
            this.dgvDesordenado.Size = new Size(240, 399);
            this.dgvDesordenado.TabIndex = 0;
            // 
            // Desordenados
            // 
            Desordenados.HeaderText = "Desordenados";
            Desordenados.Name = "Desordenados";
            // 
            // dgvOrdenado
            // 
            this.dgvOrdenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenado.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            this.dgvOrdenado.Location = new Point(363, 12);
            this.dgvOrdenado.Name = "dgvOrdenado";
            this.dgvOrdenado.Size = new Size(240, 399);
            this.dgvOrdenado.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ordenados";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btOrdenar
            // 
            btOrdenar.Location = new Point(267, 164);
            btOrdenar.Name = "btOrdenar";
            btOrdenar.Size = new Size(75, 23);
            btOrdenar.TabIndex = 2;
            btOrdenar.Text = "ordenar";
            btOrdenar.UseVisualStyleBackColor = true;
            btOrdenar.Click += this.button1_Click;
            // 
            // Burbuja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(btOrdenar);
            Controls.Add(this.dgvOrdenado);
            Controls.Add(this.dgvDesordenado);
            Name = "Burbuja";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)this.dgvDesordenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvOrdenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dgvDesordenado;
        private DataGridViewTextBoxColumn Desordenados;
        private DataGridView dgvOrdenado;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btOrdenar;
    }
}
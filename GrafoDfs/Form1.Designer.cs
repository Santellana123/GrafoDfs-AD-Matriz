namespace GrafoDfs
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
            btnAgregarVertice = new Button();
            btnAgregarArista = new Button();
            txtVertice = new TextBox();
            txtOrigen = new TextBox();
            listGrafo = new ListBox();
            txtDestino = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEliminarVertice = new Button();
            btnEncontrarCamino = new Button();
            txtPeso = new TextBox();
            label3 = new Label();
            listBoxMatrizAdyacencia = new ListBox();
            btnRecorridoDFS = new Button();
            listRecorridoDFS = new ListBox();
            SuspendLayout();
            // 
            // btnAgregarVertice
            // 
            btnAgregarVertice.Location = new Point(36, 35);
            btnAgregarVertice.Name = "btnAgregarVertice";
            btnAgregarVertice.Size = new Size(101, 24);
            btnAgregarVertice.TabIndex = 0;
            btnAgregarVertice.Text = "Agregar Vertice";
            btnAgregarVertice.UseVisualStyleBackColor = true;
            btnAgregarVertice.Click += btnAgregarVertice_Click;
            // 
            // btnAgregarArista
            // 
            btnAgregarArista.Location = new Point(36, 100);
            btnAgregarArista.Name = "btnAgregarArista";
            btnAgregarArista.Size = new Size(101, 23);
            btnAgregarArista.TabIndex = 1;
            btnAgregarArista.Text = "Agregar Arista";
            btnAgregarArista.UseVisualStyleBackColor = true;
            btnAgregarArista.Click += btnAgregarArista_Click;
            // 
            // txtVertice
            // 
            txtVertice.Location = new Point(249, 36);
            txtVertice.Name = "txtVertice";
            txtVertice.Size = new Size(262, 23);
            txtVertice.TabIndex = 2;
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(249, 100);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(262, 23);
            txtOrigen.TabIndex = 3;
            // 
            // listGrafo
            // 
            listGrafo.FormattingEnabled = true;
            listGrafo.ItemHeight = 15;
            listGrafo.Location = new Point(46, 229);
            listGrafo.Name = "listGrafo";
            listGrafo.Size = new Size(265, 199);
            listGrafo.TabIndex = 4;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(249, 150);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(262, 23);
            txtDestino.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 103);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 153);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 7;
            label2.Text = "Destino";
            // 
            // btnEliminarVertice
            // 
            btnEliminarVertice.Location = new Point(576, 36);
            btnEliminarVertice.Name = "btnEliminarVertice";
            btnEliminarVertice.Size = new Size(75, 23);
            btnEliminarVertice.TabIndex = 8;
            btnEliminarVertice.Text = "Eliminar";
            btnEliminarVertice.UseVisualStyleBackColor = true;
            btnEliminarVertice.Click += btnEliminarVertice_Click;
            // 
            // btnEncontrarCamino
            // 
            btnEncontrarCamino.Location = new Point(566, 78);
            btnEncontrarCamino.Name = "btnEncontrarCamino";
            btnEncontrarCamino.Size = new Size(97, 45);
            btnEncontrarCamino.TabIndex = 9;
            btnEncontrarCamino.Text = "Encontrar Camino";
            btnEncontrarCamino.UseVisualStyleBackColor = true;
            btnEncontrarCamino.Click += btnEncontrarCamino_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(236, 187);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 187);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 11;
            label3.Text = "peso";
            // 
            // listBoxMatrizAdyacencia
            // 
            listBoxMatrizAdyacencia.FormattingEnabled = true;
            listBoxMatrizAdyacencia.ItemHeight = 15;
            listBoxMatrizAdyacencia.Location = new Point(336, 229);
            listBoxMatrizAdyacencia.Name = "listBoxMatrizAdyacencia";
            listBoxMatrizAdyacencia.Size = new Size(315, 199);
            listBoxMatrizAdyacencia.TabIndex = 12;
            // 
            // btnRecorridoDFS
            // 
            btnRecorridoDFS.Location = new Point(566, 145);
            btnRecorridoDFS.Name = "btnRecorridoDFS";
            btnRecorridoDFS.Size = new Size(97, 28);
            btnRecorridoDFS.TabIndex = 13;
            btnRecorridoDFS.Text = "RecorridoDfs";
            btnRecorridoDFS.UseVisualStyleBackColor = true;
            btnRecorridoDFS.Click += btnRecorridoDFS_Click;
            // 
            // listRecorridoDFS
            // 
            listRecorridoDFS.FormattingEnabled = true;
            listRecorridoDFS.ItemHeight = 15;
            listRecorridoDFS.Location = new Point(670, 229);
            listRecorridoDFS.Name = "listRecorridoDFS";
            listRecorridoDFS.Size = new Size(118, 199);
            listRecorridoDFS.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listRecorridoDFS);
            Controls.Add(btnRecorridoDFS);
            Controls.Add(listBoxMatrizAdyacencia);
            Controls.Add(label3);
            Controls.Add(txtPeso);
            Controls.Add(btnEncontrarCamino);
            Controls.Add(btnEliminarVertice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDestino);
            Controls.Add(listGrafo);
            Controls.Add(txtOrigen);
            Controls.Add(txtVertice);
            Controls.Add(btnAgregarArista);
            Controls.Add(btnAgregarVertice);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarVertice;
        private Button btnAgregarArista;
        private TextBox txtVertice;
        private TextBox txtOrigen;
        private ListBox listGrafo;
        private TextBox txtDestino;
        private Label label1;
        private Label label2;
        private Button btnEliminarVertice;
        private Button btnEncontrarCamino;
        private TextBox txtPeso;
        private Label label3;
        private ListBox listBoxMatrizAdyacencia;
        private Button btnRecorridoDFS;
        private ListBox listRecorridoDFS;
    }
}
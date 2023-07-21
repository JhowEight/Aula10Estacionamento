namespace Aula10Estacionamento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFecharEstacionamento = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnEstacionar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVeículos = new System.Windows.Forms.Label();
            this.ListaEstacionamento = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFecharEstacionamento);
            this.panel1.Controls.Add(this.btnRetirar);
            this.panel1.Controls.Add(this.btnEstacionar);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(37, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 292);
            this.panel1.TabIndex = 0;
            // 
            // btnFecharEstacionamento
            // 
            this.btnFecharEstacionamento.Location = new System.Drawing.Point(80, 160);
            this.btnFecharEstacionamento.Name = "btnFecharEstacionamento";
            this.btnFecharEstacionamento.Size = new System.Drawing.Size(193, 56);
            this.btnFecharEstacionamento.TabIndex = 6;
            this.btnFecharEstacionamento.Text = "Fechar estacionamento";
            this.btnFecharEstacionamento.UseVisualStyleBackColor = true;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(181, 108);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(163, 46);
            this.btnRetirar.TabIndex = 5;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnEstacionar
            // 
            this.btnEstacionar.Location = new System.Drawing.Point(12, 108);
            this.btnEstacionar.Name = "btnEstacionar";
            this.btnEstacionar.Size = new System.Drawing.Size(163, 46);
            this.btnEstacionar.TabIndex = 4;
            this.btnEstacionar.Text = "Estacionar";
            this.btnEstacionar.UseVisualStyleBackColor = true;
            this.btnEstacionar.Click += new System.EventHandler(this.btnEstacionar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(3, 58);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(331, 25);
            this.txtPlaca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite a placa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operações";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblVeículos);
            this.panel2.Controls.Add(this.ListaEstacionamento);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(522, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 292);
            this.panel2.TabIndex = 1;
            // 
            // lblVeículos
            // 
            this.lblVeículos.AutoSize = true;
            this.lblVeículos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVeículos.Location = new System.Drawing.Point(77, 40);
            this.lblVeículos.Name = "lblVeículos";
            this.lblVeículos.Size = new System.Drawing.Size(15, 17);
            this.lblVeículos.TabIndex = 9;
            this.lblVeículos.Text = "0";
            // 
            // ListaEstacionamento
            // 
            this.ListaEstacionamento.Location = new System.Drawing.Point(16, 60);
            this.ListaEstacionamento.Name = "ListaEstacionamento";
            this.ListaEstacionamento.Size = new System.Drawing.Size(292, 212);
            this.ListaEstacionamento.TabIndex = 8;
            this.ListaEstacionamento.UseCompatibleStateImageBehavior = false;
            this.ListaEstacionamento.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Veículos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(525, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listagem de véiculos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 582);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Estacionamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnFecharEstacionamento;
        private Button btnRetirar;
        private Button btnEstacionar;
        private TextBox txtPlaca;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label lblVeículos;
        private ListView ListaEstacionamento;
    }
}
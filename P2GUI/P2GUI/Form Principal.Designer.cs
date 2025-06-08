namespace P2GUI
{
    partial class Form_Principal
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
            btnClientes = new Button();
            btnProdutos = new Button();
            btnPedidos = new Button();
            Usuários = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(66, 215);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(155, 23);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Cadastro de Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(229, 215);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(155, 23);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Cadastro de Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(390, 215);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(155, 23);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Cadastro de Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            // 
            // Usuários
            // 
            Usuários.Location = new Point(551, 215);
            Usuários.Name = "Usuários";
            Usuários.Size = new Size(155, 23);
            Usuários.TabIndex = 3;
            Usuários.Text = "Cadastro de Usuários";
            Usuários.UseVisualStyleBackColor = true;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Usuários);
            Controls.Add(btnPedidos);
            Controls.Add(btnProdutos);
            Controls.Add(btnClientes);
            Name = "Form_Principal";
            Text = "Form_Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProdutos;
        private Button btnPedidos;
        private Button Usuários;
    }
}
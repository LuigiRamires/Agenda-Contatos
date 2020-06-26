namespace ProjetoAgendaContatos
{
    partial class frmAgenda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblC_MySQL = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(50, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(108, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(292, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefone.Location = new System.Drawing.Point(108, 86);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(122, 23);
            this.txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(37, 89);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 17);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCelular.Location = new System.Drawing.Point(108, 115);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(122, 23);
            this.txtCelular.TabIndex = 5;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(44, 118);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(58, 17);
            this.lblCelular.TabIndex = 4;
            this.lblCelular.Text = "Celular:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(108, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCadastrar.Location = new System.Drawing.Point(53, 216);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(83, 25);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblC_MySQL
            // 
            this.lblC_MySQL.AutoSize = true;
            this.lblC_MySQL.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC_MySQL.Location = new System.Drawing.Point(126, 15);
            this.lblC_MySQL.Name = "lblC_MySQL";
            this.lblC_MySQL.Size = new System.Drawing.Size(213, 23);
            this.lblC_MySQL.TabIndex = 9;
            this.lblC_MySQL.Text = "Agenda - C# + MySQL";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAlterar.Location = new System.Drawing.Point(142, 216);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(83, 25);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigo.Location = new System.Drawing.Point(108, 174);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 23);
            this.txtCodigo.TabIndex = 12;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(44, 177);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 17);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnExcluir.Location = new System.Drawing.Point(231, 216);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 25);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 271);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblC_MySQL);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblC_MySQL;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnExcluir;
    }
}


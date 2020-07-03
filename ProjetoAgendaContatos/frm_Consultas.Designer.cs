namespace ProjetoAgendaContatos
{
    partial class frm_Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Consultas));
            this.lblEscolha = new System.Windows.Forms.Label();
            this.cbxBusca = new System.Windows.Forms.ComboBox();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.txtOpcao = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.dgvBusca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblEscolha.Location = new System.Drawing.Point(86, 9);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(186, 17);
            this.lblEscolha.TabIndex = 0;
            this.lblEscolha.Text = "Escolha a opção de busca:";
            // 
            // cbxBusca
            // 
            this.cbxBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBusca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbxBusca.FormattingEnabled = true;
            this.cbxBusca.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Telefone",
            "Celular",
            "Email"});
            this.cbxBusca.Location = new System.Drawing.Point(84, 29);
            this.cbxBusca.Name = "cbxBusca";
            this.cbxBusca.Size = new System.Drawing.Size(183, 25);
            this.cbxBusca.TabIndex = 1;
            this.cbxBusca.SelectedIndexChanged += new System.EventHandler(this.cbxBusca_SelectedIndexChanged);
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblOpcao.Location = new System.Drawing.Point(291, 9);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(0, 17);
            this.lblOpcao.TabIndex = 2;
            // 
            // txtOpcao
            // 
            this.txtOpcao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOpcao.Location = new System.Drawing.Point(294, 29);
            this.txtOpcao.Name = "txtOpcao";
            this.txtOpcao.Size = new System.Drawing.Size(183, 23);
            this.txtOpcao.TabIndex = 3;
            this.txtOpcao.TextChanged += new System.EventHandler(this.txtOpcao_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnBuscar.Location = new System.Drawing.Point(576, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnListarTodos.Location = new System.Drawing.Point(657, 20);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(98, 23);
            this.btnListarTodos.TabIndex = 5;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // dgvBusca
            // 
            this.dgvBusca.AllowUserToAddRows = false;
            this.dgvBusca.AllowUserToDeleteRows = false;
            this.dgvBusca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusca.Location = new System.Drawing.Point(15, 60);
            this.dgvBusca.Name = "dgvBusca";
            this.dgvBusca.ReadOnly = true;
            this.dgvBusca.Size = new System.Drawing.Size(757, 309);
            this.dgvBusca.TabIndex = 6;
            // 
            // frm_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.dgvBusca);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtOpcao);
            this.Controls.Add(this.lblOpcao);
            this.Controls.Add(this.cbxBusca);
            this.Controls.Add(this.lblEscolha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.ComboBox cbxBusca;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.TextBox txtOpcao;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.DataGridView dgvBusca;
    }
}
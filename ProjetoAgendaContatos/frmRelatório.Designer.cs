namespace ProjetoAgendaContatos
{
    partial class frmRelatório
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatório));
            this.rpvContatos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.agendaDataSet = new ProjetoAgendaContatos.agendaDataSet();
            this.tb_contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_contatoTableAdapter = new ProjetoAgendaContatos.agendaDataSetTableAdapters.tb_contatoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contatoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvContatos
            // 
            this.rpvContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_contatoBindingSource;
            this.rpvContatos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvContatos.LocalReport.ReportEmbeddedResource = "ProjetoAgendaContatos.rep_Contatos.rdlc";
            this.rpvContatos.Location = new System.Drawing.Point(0, 0);
            this.rpvContatos.Name = "rpvContatos";
            this.rpvContatos.ServerReport.BearerToken = null;
            this.rpvContatos.Size = new System.Drawing.Size(676, 335);
            this.rpvContatos.TabIndex = 0;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "agendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_contatoBindingSource
            // 
            this.tb_contatoBindingSource.DataMember = "tb_contato";
            this.tb_contatoBindingSource.DataSource = this.agendaDataSet;
            // 
            // tb_contatoTableAdapter
            // 
            this.tb_contatoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 335);
            this.Controls.Add(this.rpvContatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatório";
            this.Text = "Relatório de Contatos";
            this.Load += new System.EventHandler(this.frmRelatório_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contatoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvContatos;
        private System.Windows.Forms.BindingSource tb_contatoBindingSource;
        private agendaDataSet agendaDataSet;
        private agendaDataSetTableAdapters.tb_contatoTableAdapter tb_contatoTableAdapter;
    }
}
﻿namespace Apresentacao_ViewForms
{
    partial class FrmConsultarCliente
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEStado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInscricaoEstadual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPesquisar);
            this.panel3.Controls.Add(this.txtPesquisar);
            this.panel3.Controls.Add(this.lblPesquisar);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 59);
            this.panel3.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(580, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(162, 41);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(143, 18);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(404, 22);
            this.txtPesquisar.TabIndex = 1;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(56, 19);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(81, 20);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Consultar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnInserir);
            this.panel2.Location = new System.Drawing.Point(12, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 81);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(648, 22);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 39);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(538, 22);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(94, 39);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(428, 22);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 39);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(318, 22);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 39);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(208, 22);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(94, 39);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewCliente);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 360);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCliente,
            this.ColTipoCliente,
            this.ColCep,
            this.ColRua,
            this.ColNumero,
            this.ColBairro,
            this.ColCidade,
            this.ColEStado,
            this.ColTelefone,
            this.ColCelular,
            this.ColEmail,
            this.ColDescricao,
            this.ColNome,
            this.ColRg,
            this.ColCpf,
            this.ColSexo,
            this.ColDataNascimento,
            this.ColRazaoSocial,
            this.ColNomeFantasia,
            this.ColCnpj,
            this.ColInscricaoEstadual});
            this.dataGridViewCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCliente.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.RowTemplate.Height = 24;
            this.dataGridViewCliente.Size = new System.Drawing.Size(758, 360);
            this.dataGridViewCliente.TabIndex = 0;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "ID";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            // 
            // ColTipoCliente
            // 
            this.ColTipoCliente.HeaderText = "Tipo Cliente";
            this.ColTipoCliente.Name = "ColTipoCliente";
            this.ColTipoCliente.ReadOnly = true;
            // 
            // ColCep
            // 
            this.ColCep.HeaderText = "CEP";
            this.ColCep.Name = "ColCep";
            this.ColCep.ReadOnly = true;
            // 
            // ColRua
            // 
            this.ColRua.HeaderText = "Rua";
            this.ColRua.Name = "ColRua";
            this.ColRua.ReadOnly = true;
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "Numero";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            // 
            // ColBairro
            // 
            this.ColBairro.HeaderText = "Bairro";
            this.ColBairro.Name = "ColBairro";
            this.ColBairro.ReadOnly = true;
            // 
            // ColCidade
            // 
            this.ColCidade.HeaderText = "Cidade";
            this.ColCidade.Name = "ColCidade";
            this.ColCidade.ReadOnly = true;
            // 
            // ColEStado
            // 
            this.ColEStado.HeaderText = "Estado";
            this.ColEStado.Name = "ColEStado";
            this.ColEStado.ReadOnly = true;
            // 
            // ColTelefone
            // 
            this.ColTelefone.HeaderText = "Telefone";
            this.ColTelefone.Name = "ColTelefone";
            this.ColTelefone.ReadOnly = true;
            // 
            // ColCelular
            // 
            this.ColCelular.HeaderText = "Celular";
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.ReadOnly = true;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "E-mail";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // ColDescricao
            // 
            this.ColDescricao.HeaderText = "Descrição";
            this.ColDescricao.Name = "ColDescricao";
            this.ColDescricao.ReadOnly = true;
            // 
            // ColNome
            // 
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            // 
            // ColRg
            // 
            this.ColRg.HeaderText = "RG";
            this.ColRg.Name = "ColRg";
            this.ColRg.ReadOnly = true;
            // 
            // ColCpf
            // 
            this.ColCpf.HeaderText = "CPF";
            this.ColCpf.Name = "ColCpf";
            this.ColCpf.ReadOnly = true;
            // 
            // ColSexo
            // 
            this.ColSexo.HeaderText = "Sexo";
            this.ColSexo.Name = "ColSexo";
            this.ColSexo.ReadOnly = true;
            // 
            // ColDataNascimento
            // 
            this.ColDataNascimento.HeaderText = "Data Nascimento";
            this.ColDataNascimento.Name = "ColDataNascimento";
            this.ColDataNascimento.ReadOnly = true;
            // 
            // ColRazaoSocial
            // 
            this.ColRazaoSocial.HeaderText = "Razão Social";
            this.ColRazaoSocial.Name = "ColRazaoSocial";
            this.ColRazaoSocial.ReadOnly = true;
            // 
            // ColNomeFantasia
            // 
            this.ColNomeFantasia.HeaderText = "Nome Fantasia";
            this.ColNomeFantasia.Name = "ColNomeFantasia";
            this.ColNomeFantasia.ReadOnly = true;
            // 
            // ColCnpj
            // 
            this.ColCnpj.HeaderText = "CNPJ";
            this.ColCnpj.Name = "ColCnpj";
            this.ColCnpj.ReadOnly = true;
            // 
            // ColInscricaoEstadual
            // 
            this.ColInscricaoEstadual.HeaderText = "Inscrição Estadual";
            this.ColInscricaoEstadual.Name = "ColInscricaoEstadual";
            this.ColInscricaoEstadual.ReadOnly = true;
            // 
            // FrmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsultarCliente";
            this.Text = "Consultar Cliente";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEStado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInscricaoEstadual;
    }
}
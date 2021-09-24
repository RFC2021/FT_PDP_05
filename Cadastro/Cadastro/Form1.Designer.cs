namespace Cadastro
{
    partial class Cadastro
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbPref = new System.Windows.Forms.TextBox();
            this.tbNivel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgcadastro = new System.Windows.Forms.DataGridView();
            this.Colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAnonasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colpref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colniv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgcadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(51, 39);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(26, 20);
            this.tbId.TabIndex = 0;
            this.tbId.UseWaitCursor = true;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(162, 39);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(373, 20);
            this.tbNome.TabIndex = 1;
            this.tbNome.UseWaitCursor = true;
            // 
            // tbPref
            // 
            this.tbPref.Location = new System.Drawing.Point(111, 128);
            this.tbPref.Name = "tbPref";
            this.tbPref.Size = new System.Drawing.Size(307, 20);
            this.tbPref.TabIndex = 3;
            this.tbPref.UseWaitCursor = true;
            // 
            // tbNivel
            // 
            this.tbNivel.Location = new System.Drawing.Point(507, 125);
            this.tbNivel.Name = "tbNivel";
            this.tbNivel.Size = new System.Drawing.Size(28, 20);
            this.tbNivel.TabIndex = 4;
            this.tbNivel.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOME";
            this.label2.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "PREFERÊNCIAS";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "NÍVEL FID.";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = " ANO NASC.";
            this.label6.UseWaitCursor = true;
            // 
            // dgcadastro
            // 
            this.dgcadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colid,
            this.Colnome,
            this.ColAnonasc,
            this.Colpref,
            this.Colniv});
            this.dgcadastro.Location = new System.Drawing.Point(15, 211);
            this.dgcadastro.Name = "dgcadastro";
            this.dgcadastro.Size = new System.Drawing.Size(695, 150);
            this.dgcadastro.TabIndex = 12;
            this.dgcadastro.UseWaitCursor = true;
            this.dgcadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcadastro_CellContentClick);
            // 
            // Colid
            // 
            this.Colid.HeaderText = "ID";
            this.Colid.Name = "Colid";
            this.Colid.Width = 30;
            // 
            // Colnome
            // 
            this.Colnome.HeaderText = "NOME";
            this.Colnome.Name = "Colnome";
            this.Colnome.Width = 200;
            // 
            // ColAnonasc
            // 
            this.ColAnonasc.HeaderText = "ANO NASCIMENTO";
            this.ColAnonasc.Name = "ColAnonasc";
            // 
            // Colpref
            // 
            this.Colpref.HeaderText = "PREFERÊNCIAS";
            this.Colpref.Name = "Colpref";
            this.Colpref.Width = 200;
            // 
            // Colniv
            // 
            this.Colniv.HeaderText = "NÍVEL FID";
            this.Colniv.Name = "Colniv";
            this.Colniv.Width = 50;
            // 
            // btcadastrar
            // 
            this.btcadastrar.Location = new System.Drawing.Point(111, 170);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(75, 23);
            this.btcadastrar.TabIndex = 13;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.UseWaitCursor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(343, 170);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(75, 23);
            this.btlimpar.TabIndex = 14;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.UseWaitCursor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(658, 39);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(60, 20);
            this.tbAno.TabIndex = 18;
            this.tbAno.UseWaitCursor = true;
            // 
            // btatualizar
            // 
            this.btatualizar.Location = new System.Drawing.Point(224, 170);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(75, 23);
            this.btatualizar.TabIndex = 19;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.UseWaitCursor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(460, 170);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 20;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.UseWaitCursor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.dgcadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNivel);
            this.Controls.Add(this.tbPref);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbId);
            this.Name = "Cadastro";
            this.Text = "Cadastro Fidelidade";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbPref;
        private System.Windows.Forms.TextBox tbNivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgcadastro;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.TextBox tbclienteativo;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAnonasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colpref;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colniv;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btDeletar;
    }
}

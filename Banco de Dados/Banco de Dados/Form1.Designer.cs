
namespace Banco_de_Dados
{
    partial class Form1
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
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.botaoAtualizar = new System.Windows.Forms.Button();
            this.botaoConsultar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(173, 67);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(64, 29);
            this.labelCPF.TabIndex = 0;
            this.labelCPF.Text = "CPF";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(173, 117);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(83, 29);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(173, 174);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(118, 29);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone";
            // 
            // textCPF
            // 
            this.textCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCPF.Location = new System.Drawing.Point(314, 67);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(330, 35);
            this.textCPF.TabIndex = 3;
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(314, 117);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(330, 35);
            this.textNome.TabIndex = 4;
            // 
            // textTelefone
            // 
            this.textTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefone.Location = new System.Drawing.Point(314, 174);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(330, 35);
            this.textTelefone.TabIndex = 5;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSalvar.Location = new System.Drawing.Point(178, 256);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(162, 56);
            this.botaoSalvar.TabIndex = 6;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // botaoAtualizar
            // 
            this.botaoAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAtualizar.Location = new System.Drawing.Point(367, 256);
            this.botaoAtualizar.Name = "botaoAtualizar";
            this.botaoAtualizar.Size = new System.Drawing.Size(162, 56);
            this.botaoAtualizar.TabIndex = 7;
            this.botaoAtualizar.Text = "Atualizar";
            this.botaoAtualizar.UseVisualStyleBackColor = true;
            // 
            // botaoConsultar
            // 
            this.botaoConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConsultar.Location = new System.Drawing.Point(552, 256);
            this.botaoConsultar.Name = "botaoConsultar";
            this.botaoConsultar.Size = new System.Drawing.Size(162, 56);
            this.botaoConsultar.TabIndex = 8;
            this.botaoConsultar.Text = "Consultar";
            this.botaoConsultar.UseVisualStyleBackColor = true;
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoExcluir.ForeColor = System.Drawing.Color.DarkRed;
            this.botaoExcluir.Location = new System.Drawing.Point(367, 337);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(162, 56);
            this.botaoExcluir.TabIndex = 9;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoConsultar);
            this.Controls.Add(this.botaoAtualizar);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Button botaoAtualizar;
        private System.Windows.Forms.Button botaoConsultar;
        private System.Windows.Forms.Button botaoExcluir;
    }
}


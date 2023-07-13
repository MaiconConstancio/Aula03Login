
namespace Aula03Login
{
    partial class Login
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
            this.Conectar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.CaixaDoLogin = new System.Windows.Forms.TextBox();
            this.CaixaDaSenha = new System.Windows.Forms.TextBox();
            this.panelSaldo = new System.Windows.Forms.Panel();
            this.AumentarSALDO = new System.Windows.Forms.CheckBox();
            this.BotaoSALVARsaldo = new System.Windows.Forms.Button();
            this.lblSeuSALDO = new System.Windows.Forms.Label();
            this.txtAUMENTARsaldo = new System.Windows.Forms.TextBox();
            this.TITULO = new System.Windows.Forms.Label();
            this.panelSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Conectar
            // 
            this.Conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectar.ForeColor = System.Drawing.Color.Coral;
            this.Conectar.Location = new System.Drawing.Point(27, 165);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(181, 39);
            this.Conectar.TabIndex = 0;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(45, 53);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(140, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Digite seu usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSenha.Location = new System.Drawing.Point(47, 109);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(132, 20);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Digite sua senha:";
            // 
            // CaixaDoLogin
            // 
            this.CaixaDoLogin.Location = new System.Drawing.Point(27, 76);
            this.CaixaDoLogin.Name = "CaixaDoLogin";
            this.CaixaDoLogin.Size = new System.Drawing.Size(181, 20);
            this.CaixaDoLogin.TabIndex = 3;
            this.CaixaDoLogin.TextChanged += new System.EventHandler(this.CaixaDoLogin_TextChanged);
            // 
            // CaixaDaSenha
            // 
            this.CaixaDaSenha.CausesValidation = false;
            this.CaixaDaSenha.Location = new System.Drawing.Point(27, 129);
            this.CaixaDaSenha.Name = "CaixaDaSenha";
            this.CaixaDaSenha.PasswordChar = '$';
            this.CaixaDaSenha.Size = new System.Drawing.Size(181, 20);
            this.CaixaDaSenha.TabIndex = 4;
            this.CaixaDaSenha.TextChanged += new System.EventHandler(this.CaixaDaSenha_TextChanged);
            // 
            // panelSaldo
            // 
            this.panelSaldo.Controls.Add(this.AumentarSALDO);
            this.panelSaldo.Controls.Add(this.BotaoSALVARsaldo);
            this.panelSaldo.Controls.Add(this.lblSeuSALDO);
            this.panelSaldo.Controls.Add(this.txtAUMENTARsaldo);
            this.panelSaldo.Location = new System.Drawing.Point(231, 53);
            this.panelSaldo.Name = "panelSaldo";
            this.panelSaldo.Size = new System.Drawing.Size(216, 159);
            this.panelSaldo.TabIndex = 5;
            this.panelSaldo.Visible = false;
            // 
            // AumentarSALDO
            // 
            this.AumentarSALDO.AutoSize = true;
            this.AumentarSALDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AumentarSALDO.ForeColor = System.Drawing.Color.Coral;
            this.AumentarSALDO.Location = new System.Drawing.Point(19, 88);
            this.AumentarSALDO.Name = "AumentarSALDO";
            this.AumentarSALDO.Size = new System.Drawing.Size(88, 21);
            this.AumentarSALDO.TabIndex = 10;
            this.AumentarSALDO.Text = "Aumentar";
            this.AumentarSALDO.UseVisualStyleBackColor = true;
            // 
            // BotaoSALVARsaldo
            // 
            this.BotaoSALVARsaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoSALVARsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSALVARsaldo.ForeColor = System.Drawing.Color.Coral;
            this.BotaoSALVARsaldo.Location = new System.Drawing.Point(115, 109);
            this.BotaoSALVARsaldo.Name = "BotaoSALVARsaldo";
            this.BotaoSALVARsaldo.Size = new System.Drawing.Size(79, 26);
            this.BotaoSALVARsaldo.TabIndex = 9;
            this.BotaoSALVARsaldo.Text = "Salvar";
            this.BotaoSALVARsaldo.UseVisualStyleBackColor = true;
            // 
            // lblSeuSALDO
            // 
            this.lblSeuSALDO.AutoSize = true;
            this.lblSeuSALDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeuSALDO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSeuSALDO.Location = new System.Drawing.Point(55, 24);
            this.lblSeuSALDO.Name = "lblSeuSALDO";
            this.lblSeuSALDO.Size = new System.Drawing.Size(109, 17);
            this.lblSeuSALDO.TabIndex = 8;
            this.lblSeuSALDO.Text = "Seu saldo: R$ 0";
            // 
            // txtAUMENTARsaldo
            // 
            this.txtAUMENTARsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAUMENTARsaldo.Location = new System.Drawing.Point(18, 109);
            this.txtAUMENTARsaldo.Multiline = true;
            this.txtAUMENTARsaldo.Name = "txtAUMENTARsaldo";
            this.txtAUMENTARsaldo.Size = new System.Drawing.Size(79, 26);
            this.txtAUMENTARsaldo.TabIndex = 7;
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITULO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TITULO.Location = new System.Drawing.Point(35, 22);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(167, 20);
            this.TITULO.TabIndex = 6;
            this.TITULO.Text = "CONTADORA MIKE";
            this.TITULO.Click += new System.EventHandler(this.TITULO_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(234, 231);
            this.Controls.Add(this.TITULO);
            this.Controls.Add(this.panelSaldo);
            this.Controls.Add(this.CaixaDaSenha);
            this.Controls.Add(this.CaixaDoLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.Conectar);
            this.Name = "Login";
            this.Text = "Login";
            this.panelSaldo.ResumeLayout(false);
            this.panelSaldo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox CaixaDoLogin;
        private System.Windows.Forms.TextBox CaixaDaSenha;
        private System.Windows.Forms.Panel panelSaldo;
        private System.Windows.Forms.CheckBox AumentarSALDO;
        private System.Windows.Forms.Button BotaoSALVARsaldo;
        private System.Windows.Forms.Label lblSeuSALDO;
        private System.Windows.Forms.TextBox txtAUMENTARsaldo;
        private System.Windows.Forms.Label TITULO;
    }
}



namespace LogonViaAD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTBuser = new System.Windows.Forms.TextBox();
            this.TXTBpass = new System.Windows.Forms.TextBox();
            this.BTN_Esntrar = new System.Windows.Forms.Button();
            this.BTNsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha";
            // 
            // TXTBuser
            // 
            this.TXTBuser.Location = new System.Drawing.Point(15, 25);
            this.TXTBuser.Name = "TXTBuser";
            this.TXTBuser.Size = new System.Drawing.Size(141, 20);
            this.TXTBuser.TabIndex = 1;
            // 
            // TXTBpass
            // 
            this.TXTBpass.Location = new System.Drawing.Point(162, 25);
            this.TXTBpass.Name = "TXTBpass";
            this.TXTBpass.Size = new System.Drawing.Size(141, 20);
            this.TXTBpass.TabIndex = 1;
            // 
            // BTN_Esntrar
            // 
            this.BTN_Esntrar.Location = new System.Drawing.Point(15, 58);
            this.BTN_Esntrar.Name = "BTN_Esntrar";
            this.BTN_Esntrar.Size = new System.Drawing.Size(141, 23);
            this.BTN_Esntrar.TabIndex = 2;
            this.BTN_Esntrar.Text = "Entrar";
            this.BTN_Esntrar.UseVisualStyleBackColor = true;
            this.BTN_Esntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNsair
            // 
            this.BTNsair.Location = new System.Drawing.Point(162, 58);
            this.BTNsair.Name = "BTNsair";
            this.BTNsair.Size = new System.Drawing.Size(141, 23);
            this.BTNsair.TabIndex = 2;
            this.BTNsair.Text = "Fechar";
            this.BTNsair.UseVisualStyleBackColor = true;
            this.BTNsair.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(320, 96);
            this.Controls.Add(this.BTNsair);
            this.Controls.Add(this.BTN_Esntrar);
            this.Controls.Add(this.TXTBpass);
            this.Controls.Add(this.TXTBuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTBuser;
        private System.Windows.Forms.TextBox TXTBpass;
        private System.Windows.Forms.Button BTN_Esntrar;
        private System.Windows.Forms.Button BTNsair;
    }
}


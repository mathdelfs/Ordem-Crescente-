
namespace Ordem_Crescente
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
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblTerceiro = new System.Windows.Forms.Label();
            this.btmOrganizar = new System.Windows.Forms.Button();
            this.txtPrimeiro = new System.Windows.Forms.TextBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.txtTerceiro = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.txtMedio = new System.Windows.Forms.TextBox();
            this.txtMaior = new System.Windows.Forms.TextBox();
            this.lbl1o = new System.Windows.Forms.Label();
            this.lbl2o = new System.Windows.Forms.Label();
            this.lbl3o = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.Location = new System.Drawing.Point(105, 82);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(43, 13);
            this.lblPrimeiro.TabIndex = 0;
            this.lblPrimeiro.Text = "Valor 1:";
            this.lblPrimeiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrimeiro.UseWaitCursor = true;
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(234, 82);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(43, 13);
            this.lblSegundo.TabIndex = 1;
            this.lblSegundo.Text = "Valor 2:";
            this.lblSegundo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTerceiro
            // 
            this.lblTerceiro.AutoSize = true;
            this.lblTerceiro.Location = new System.Drawing.Point(360, 82);
            this.lblTerceiro.Name = "lblTerceiro";
            this.lblTerceiro.Size = new System.Drawing.Size(43, 13);
            this.lblTerceiro.TabIndex = 2;
            this.lblTerceiro.Text = "Valor 3:";
            // 
            // btmOrganizar
            // 
            this.btmOrganizar.Location = new System.Drawing.Point(237, 165);
            this.btmOrganizar.Name = "btmOrganizar";
            this.btmOrganizar.Size = new System.Drawing.Size(75, 23);
            this.btmOrganizar.TabIndex = 3;
            this.btmOrganizar.Text = "Organizar";
            this.btmOrganizar.UseVisualStyleBackColor = true;
            this.btmOrganizar.Click += new System.EventHandler(this.btmOrganizar_Click);
            // 
            // txtPrimeiro
            // 
            this.txtPrimeiro.Location = new System.Drawing.Point(96, 108);
            this.txtPrimeiro.Name = "txtPrimeiro";
            this.txtPrimeiro.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeiro.TabIndex = 4;
            this.txtPrimeiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimeiro_KeyPress);
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(225, 108);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(100, 20);
            this.txtSegundo.TabIndex = 5;
            // 
            // txtTerceiro
            // 
            this.txtTerceiro.Location = new System.Drawing.Point(348, 108);
            this.txtTerceiro.Name = "txtTerceiro";
            this.txtTerceiro.Size = new System.Drawing.Size(100, 20);
            this.txtTerceiro.TabIndex = 6;
            this.txtTerceiro.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMenor
            // 
            this.txtMenor.Enabled = false;
            this.txtMenor.Location = new System.Drawing.Point(96, 233);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(100, 20);
            this.txtMenor.TabIndex = 7;
            // 
            // txtMedio
            // 
            this.txtMedio.Enabled = false;
            this.txtMedio.Location = new System.Drawing.Point(225, 233);
            this.txtMedio.Name = "txtMedio";
            this.txtMedio.Size = new System.Drawing.Size(100, 20);
            this.txtMedio.TabIndex = 8;
            this.txtMedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedio_KeyPress);
            // 
            // txtMaior
            // 
            this.txtMaior.Enabled = false;
            this.txtMaior.Location = new System.Drawing.Point(348, 233);
            this.txtMaior.Name = "txtMaior";
            this.txtMaior.Size = new System.Drawing.Size(100, 20);
            this.txtMaior.TabIndex = 9;
            this.txtMaior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaior_KeyPress);
            // 
            // lbl1o
            // 
            this.lbl1o.AutoSize = true;
            this.lbl1o.Location = new System.Drawing.Point(120, 217);
            this.lbl1o.Name = "lbl1o";
            this.lbl1o.Size = new System.Drawing.Size(17, 13);
            this.lbl1o.TabIndex = 11;
            this.lbl1o.Text = "1º";
            // 
            // lbl2o
            // 
            this.lbl2o.AutoSize = true;
            this.lbl2o.Location = new System.Drawing.Point(261, 217);
            this.lbl2o.Name = "lbl2o";
            this.lbl2o.Size = new System.Drawing.Size(17, 13);
            this.lbl2o.TabIndex = 12;
            this.lbl2o.Text = "2º";
            // 
            // lbl3o
            // 
            this.lbl3o.AutoSize = true;
            this.lbl3o.Location = new System.Drawing.Point(384, 217);
            this.lbl3o.Name = "lbl3o";
            this.lbl3o.Size = new System.Drawing.Size(17, 13);
            this.lbl3o.TabIndex = 13;
            this.lbl3o.Text = "3º";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl3o);
            this.Controls.Add(this.lbl2o);
            this.Controls.Add(this.lbl1o);
            this.Controls.Add(this.txtMaior);
            this.Controls.Add(this.txtMedio);
            this.Controls.Add(this.txtMenor);
            this.Controls.Add(this.txtTerceiro);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.txtPrimeiro);
            this.Controls.Add(this.btmOrganizar);
            this.Controls.Add(this.lblTerceiro);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblPrimeiro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblTerceiro;
        private System.Windows.Forms.Button btmOrganizar;
        private System.Windows.Forms.TextBox txtPrimeiro;
        private System.Windows.Forms.TextBox txtSegundo;
        private System.Windows.Forms.TextBox txtTerceiro;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.TextBox txtMedio;
        private System.Windows.Forms.TextBox txtMaior;
        private System.Windows.Forms.Label lbl1o;
        private System.Windows.Forms.Label lbl2o;
        private System.Windows.Forms.Label lbl3o;
    }
}


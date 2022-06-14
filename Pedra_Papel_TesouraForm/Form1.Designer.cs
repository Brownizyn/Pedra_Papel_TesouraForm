namespace Pedra_Papel_TesouraForm
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
            this.btPedra = new System.Windows.Forms.Button();
            this.btPapel = new System.Windows.Forms.Button();
            this.btTesoura = new System.Windows.Forms.Button();
            this.PicJogador = new System.Windows.Forms.PictureBox();
            this.PicCpu = new System.Windows.Forms.PictureBox();
            this.LblDescricaoJogador = new System.Windows.Forms.Label();
            this.LblDescricaoCpu = new System.Windows.Forms.Label();
            this.LbPtJogador = new System.Windows.Forms.Label();
            this.LbPtCpu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // btPedra
            // 
            this.btPedra.BackgroundImage = global::Pedra_Papel_TesouraForm.Properties.Resources.PedraJ;
            this.btPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPedra.Location = new System.Drawing.Point(33, 286);
            this.btPedra.Name = "btPedra";
            this.btPedra.Size = new System.Drawing.Size(120, 120);
            this.btPedra.TabIndex = 0;
            this.btPedra.Tag = "0";
            this.btPedra.UseVisualStyleBackColor = true;
            this.btPedra.Click += new System.EventHandler(this.ClickJogada);
            // 
            // btPapel
            // 
            this.btPapel.BackgroundImage = global::Pedra_Papel_TesouraForm.Properties.Resources.PapelJ;
            this.btPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPapel.Location = new System.Drawing.Point(188, 286);
            this.btPapel.Name = "btPapel";
            this.btPapel.Size = new System.Drawing.Size(120, 120);
            this.btPapel.TabIndex = 1;
            this.btPapel.Tag = "1";
            this.btPapel.UseVisualStyleBackColor = true;
            this.btPapel.Click += new System.EventHandler(this.ClickJogada);
            // 
            // btTesoura
            // 
            this.btTesoura.BackgroundImage = global::Pedra_Papel_TesouraForm.Properties.Resources.TesouraJ;
            this.btTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTesoura.Location = new System.Drawing.Point(344, 286);
            this.btTesoura.Name = "btTesoura";
            this.btTesoura.Size = new System.Drawing.Size(120, 120);
            this.btTesoura.TabIndex = 2;
            this.btTesoura.Tag = "2";
            this.btTesoura.UseVisualStyleBackColor = true;
            this.btTesoura.Click += new System.EventHandler(this.ClickJogada);
            // 
            // PicJogador
            // 
            this.PicJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicJogador.Location = new System.Drawing.Point(13, 64);
            this.PicJogador.Name = "PicJogador";
            this.PicJogador.Size = new System.Drawing.Size(150, 150);
            this.PicJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicJogador.TabIndex = 3;
            this.PicJogador.TabStop = false;
            // 
            // PicCpu
            // 
            this.PicCpu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicCpu.Location = new System.Drawing.Point(344, 64);
            this.PicCpu.Name = "PicCpu";
            this.PicCpu.Size = new System.Drawing.Size(150, 150);
            this.PicCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCpu.TabIndex = 4;
            this.PicCpu.TabStop = false;
            // 
            // LblDescricaoJogador
            // 
            this.LblDescricaoJogador.AutoSize = true;
            this.LblDescricaoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescricaoJogador.Location = new System.Drawing.Point(170, 78);
            this.LblDescricaoJogador.Name = "LblDescricaoJogador";
            this.LblDescricaoJogador.Size = new System.Drawing.Size(67, 20);
            this.LblDescricaoJogador.TabIndex = 5;
            this.LblDescricaoJogador.Text = "Jogador";
            // 
            // LblDescricaoCpu
            // 
            this.LblDescricaoCpu.AutoSize = true;
            this.LblDescricaoCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescricaoCpu.Location = new System.Drawing.Point(287, 78);
            this.LblDescricaoCpu.Name = "LblDescricaoCpu";
            this.LblDescricaoCpu.Size = new System.Drawing.Size(38, 20);
            this.LblDescricaoCpu.TabIndex = 6;
            this.LblDescricaoCpu.Text = "Cpu";
            // 
            // LbPtJogador
            // 
            this.LbPtJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPtJogador.Location = new System.Drawing.Point(173, 110);
            this.LbPtJogador.Name = "LbPtJogador";
            this.LbPtJogador.Size = new System.Drawing.Size(40, 20);
            this.LbPtJogador.TabIndex = 7;
            this.LbPtJogador.Text = "0";
            this.LbPtJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPtCpu
            // 
            this.LbPtCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPtCpu.Location = new System.Drawing.Point(285, 110);
            this.LbPtCpu.Name = "LbPtCpu";
            this.LbPtCpu.Size = new System.Drawing.Size(40, 20);
            this.LbPtCpu.TabIndex = 8;
            this.LbPtCpu.Text = "0";
            this.LbPtCpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 418);
            this.Controls.Add(this.LbPtCpu);
            this.Controls.Add(this.LbPtJogador);
            this.Controls.Add(this.LblDescricaoCpu);
            this.Controls.Add(this.LblDescricaoJogador);
            this.Controls.Add(this.PicCpu);
            this.Controls.Add(this.PicJogador);
            this.Controls.Add(this.btTesoura);
            this.Controls.Add(this.btPapel);
            this.Controls.Add(this.btPedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pedra,Papel e Tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPedra;
        private System.Windows.Forms.Button btPapel;
        private System.Windows.Forms.Button btTesoura;
        private System.Windows.Forms.PictureBox PicJogador;
        private System.Windows.Forms.PictureBox PicCpu;
        private System.Windows.Forms.Label LblDescricaoJogador;
        private System.Windows.Forms.Label LblDescricaoCpu;
        private System.Windows.Forms.Label LbPtJogador;
        private System.Windows.Forms.Label LbPtCpu;
    }
}


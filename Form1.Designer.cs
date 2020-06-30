namespace Testando_Framerates
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
            this.PanelTeste = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFramerate = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbColorido = new System.Windows.Forms.CheckBox();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.PanelAleatorio = new System.Windows.Forms.Panel();
            this.btnStartAleatorio = new System.Windows.Forms.Button();
            this.tbMaximo = new System.Windows.Forms.TextBox();
            this.tbIncial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelTeste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelAleatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTeste
            // 
            this.PanelTeste.BackColor = System.Drawing.Color.Black;
            this.PanelTeste.Controls.Add(this.pictureBox1);
            this.PanelTeste.Location = new System.Drawing.Point(12, 12);
            this.PanelTeste.Name = "PanelTeste";
            this.PanelTeste.Size = new System.Drawing.Size(236, 133);
            this.PanelTeste.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Testando_Framerates.Properties.Resources.galinha__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbFramerate
            // 
            this.tbFramerate.Location = new System.Drawing.Point(52, 154);
            this.tbFramerate.Name = "tbFramerate";
            this.tbFramerate.Size = new System.Drawing.Size(100, 20);
            this.tbFramerate.TabIndex = 1;
            this.tbFramerate.TextChanged += new System.EventHandler(this.tbFramerate_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(173, 152);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hz:";
            // 
            // cbColorido
            // 
            this.cbColorido.AutoSize = true;
            this.cbColorido.Location = new System.Drawing.Point(15, 209);
            this.cbColorido.Name = "cbColorido";
            this.cbColorido.Size = new System.Drawing.Size(64, 17);
            this.cbColorido.TabIndex = 4;
            this.cbColorido.Text = "Colorido";
            this.cbColorido.UseVisualStyleBackColor = true;
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(178, 180);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(70, 23);
            this.btnAleatorio.TabIndex = 5;
            this.btnAleatorio.Text = "Aleatorio";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // PanelAleatorio
            // 
            this.PanelAleatorio.Controls.Add(this.btnStartAleatorio);
            this.PanelAleatorio.Controls.Add(this.tbMaximo);
            this.PanelAleatorio.Controls.Add(this.tbIncial);
            this.PanelAleatorio.Controls.Add(this.label3);
            this.PanelAleatorio.Controls.Add(this.label2);
            this.PanelAleatorio.Location = new System.Drawing.Point(15, 232);
            this.PanelAleatorio.Name = "PanelAleatorio";
            this.PanelAleatorio.Size = new System.Drawing.Size(238, 82);
            this.PanelAleatorio.TabIndex = 6;
            this.PanelAleatorio.Visible = false;
            // 
            // btnStartAleatorio
            // 
            this.btnStartAleatorio.Enabled = false;
            this.btnStartAleatorio.Location = new System.Drawing.Point(158, 40);
            this.btnStartAleatorio.Name = "btnStartAleatorio";
            this.btnStartAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnStartAleatorio.TabIndex = 4;
            this.btnStartAleatorio.Text = "iniciar";
            this.btnStartAleatorio.UseVisualStyleBackColor = true;
            this.btnStartAleatorio.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbMaximo
            // 
            this.tbMaximo.Location = new System.Drawing.Point(52, 42);
            this.tbMaximo.Name = "tbMaximo";
            this.tbMaximo.Size = new System.Drawing.Size(100, 20);
            this.tbMaximo.TabIndex = 3;
            this.tbMaximo.TextChanged += new System.EventHandler(this.tbFramerate_TextChanged);
            // 
            // tbIncial
            // 
            this.tbIncial.Location = new System.Drawing.Point(52, 11);
            this.tbIncial.Name = "tbIncial";
            this.tbIncial.Size = new System.Drawing.Size(100, 20);
            this.tbIncial.TabIndex = 2;
            this.tbIncial.TextChanged += new System.EventHandler(this.tbFramerate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maximo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicial";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(106, 180);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(61, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "imagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.PanelAleatorio);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.cbColorido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbFramerate);
            this.Controls.Add(this.PanelTeste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Testando Framerate";
            this.PanelTeste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelAleatorio.ResumeLayout(false);
            this.PanelAleatorio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTeste;
        private System.Windows.Forms.TextBox tbFramerate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbColorido;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Panel PanelAleatorio;
        private System.Windows.Forms.Button btnStartAleatorio;
        private System.Windows.Forms.TextBox tbMaximo;
        private System.Windows.Forms.TextBox tbIncial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}


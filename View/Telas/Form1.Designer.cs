namespace View.Telas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelCrudLocatario = new System.Windows.Forms.Panel();
            this.buttonDelCrud = new System.Windows.Forms.Button();
            this.buttonAtuCrud = new System.Windows.Forms.Button();
            this.buttonPesCrud = new System.Windows.Forms.Button();
            this.buttonCadCrud = new System.Windows.Forms.Button();
            this.buttonLocatario = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCarregamento = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.panelCrudLocatario.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelPrincipal.Controls.Add(this.panelCrudLocatario);
            this.panelPrincipal.Controls.Add(this.buttonLocatario);
            this.panelPrincipal.Controls.Add(this.panelLogo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(291, 749);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelCrudLocatario
            // 
            this.panelCrudLocatario.Controls.Add(this.buttonDelCrud);
            this.panelCrudLocatario.Controls.Add(this.buttonAtuCrud);
            this.panelCrudLocatario.Controls.Add(this.buttonPesCrud);
            this.panelCrudLocatario.Controls.Add(this.buttonCadCrud);
            this.panelCrudLocatario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrudLocatario.Location = new System.Drawing.Point(0, 136);
            this.panelCrudLocatario.Name = "panelCrudLocatario";
            this.panelCrudLocatario.Size = new System.Drawing.Size(291, 97);
            this.panelCrudLocatario.TabIndex = 2;
            // 
            // buttonDelCrud
            // 
            this.buttonDelCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelCrud.FlatAppearance.BorderSize = 0;
            this.buttonDelCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelCrud.Location = new System.Drawing.Point(0, 69);
            this.buttonDelCrud.Name = "buttonDelCrud";
            this.buttonDelCrud.Size = new System.Drawing.Size(291, 23);
            this.buttonDelCrud.TabIndex = 3;
            this.buttonDelCrud.Text = "Deletar";
            this.buttonDelCrud.UseVisualStyleBackColor = true;
            // 
            // buttonAtuCrud
            // 
            this.buttonAtuCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAtuCrud.FlatAppearance.BorderSize = 0;
            this.buttonAtuCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtuCrud.Location = new System.Drawing.Point(0, 46);
            this.buttonAtuCrud.Name = "buttonAtuCrud";
            this.buttonAtuCrud.Size = new System.Drawing.Size(291, 23);
            this.buttonAtuCrud.TabIndex = 2;
            this.buttonAtuCrud.Text = "Atualizar";
            this.buttonAtuCrud.UseVisualStyleBackColor = true;
            // 
            // buttonPesCrud
            // 
            this.buttonPesCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPesCrud.FlatAppearance.BorderSize = 0;
            this.buttonPesCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesCrud.Location = new System.Drawing.Point(0, 23);
            this.buttonPesCrud.Name = "buttonPesCrud";
            this.buttonPesCrud.Size = new System.Drawing.Size(291, 23);
            this.buttonPesCrud.TabIndex = 1;
            this.buttonPesCrud.Text = "Pesquisar";
            this.buttonPesCrud.UseVisualStyleBackColor = true;
            this.buttonPesCrud.Click += new System.EventHandler(this.buttonPesCrud_Click);
            // 
            // buttonCadCrud
            // 
            this.buttonCadCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCadCrud.FlatAppearance.BorderSize = 0;
            this.buttonCadCrud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadCrud.Location = new System.Drawing.Point(0, 0);
            this.buttonCadCrud.Name = "buttonCadCrud";
            this.buttonCadCrud.Size = new System.Drawing.Size(291, 23);
            this.buttonCadCrud.TabIndex = 0;
            this.buttonCadCrud.Text = "Cadastrar";
            this.buttonCadCrud.UseVisualStyleBackColor = true;
            this.buttonCadCrud.Click += new System.EventHandler(this.buttonCadCrud_Click);
            // 
            // buttonLocatario
            // 
            this.buttonLocatario.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLocatario.FlatAppearance.BorderSize = 0;
            this.buttonLocatario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocatario.ForeColor = System.Drawing.Color.Black;
            this.buttonLocatario.Location = new System.Drawing.Point(0, 100);
            this.buttonLocatario.Name = "buttonLocatario";
            this.buttonLocatario.Size = new System.Drawing.Size(291, 36);
            this.buttonLocatario.TabIndex = 1;
            this.buttonLocatario.Text = "Locatário";
            this.buttonLocatario.UseVisualStyleBackColor = true;
            this.buttonLocatario.Click += new System.EventHandler(this.buttonLocatario_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(291, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCarregamento
            // 
            this.panelCarregamento.BackColor = System.Drawing.SystemColors.Control;
            this.panelCarregamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarregamento.Location = new System.Drawing.Point(291, 0);
            this.panelCarregamento.Name = "panelCarregamento";
            this.panelCarregamento.Size = new System.Drawing.Size(693, 749);
            this.panelCarregamento.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.panelCarregamento);
            this.Controls.Add(this.panelPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPrincipal.ResumeLayout(false);
            this.panelCrudLocatario.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelPrincipal;
        private Panel panelCrudLocatario;
        private Button buttonDelCrud;
        private Button buttonAtuCrud;
        private Button buttonPesCrud;
        private Button buttonCadCrud;
        private Button buttonLocatario;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelCarregamento;
    }
}
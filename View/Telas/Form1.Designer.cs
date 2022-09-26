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
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLocatario = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCarregamento = new System.Windows.Forms.Panel();
            this.buttonContrato = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelCrudLocatario.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.panelPrincipal.Controls.Add(this.buttonContrato);
            this.panelPrincipal.Controls.Add(this.panelCrudLocatario);
            this.panelPrincipal.Controls.Add(this.buttonLocatario);
            this.panelPrincipal.Controls.Add(this.panelLogo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(208, 749);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelCrudLocatario
            // 
            this.panelCrudLocatario.Controls.Add(this.buttonPesquisar);
            this.panelCrudLocatario.Controls.Add(this.buttonCadastrar);
            this.panelCrudLocatario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrudLocatario.Location = new System.Drawing.Point(0, 160);
            this.panelCrudLocatario.Name = "panelCrudLocatario";
            this.panelCrudLocatario.Size = new System.Drawing.Size(208, 78);
            this.panelCrudLocatario.TabIndex = 2;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPesquisar.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.Image")));
            this.buttonPesquisar.Location = new System.Drawing.Point(0, 30);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(208, 30);
            this.buttonPesquisar.TabIndex = 1;
            this.buttonPesquisar.Text = "  Pesquisar";
            this.buttonPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadastrar.Image")));
            this.buttonCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadastrar.Location = new System.Drawing.Point(0, 0);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(208, 30);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "  Cadastrar";
            this.buttonCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonLocatario
            // 
            this.buttonLocatario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.buttonLocatario.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLocatario.FlatAppearance.BorderSize = 0;
            this.buttonLocatario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocatario.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLocatario.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLocatario.Image = ((System.Drawing.Image)(resources.GetObject("buttonLocatario.Image")));
            this.buttonLocatario.Location = new System.Drawing.Point(0, 100);
            this.buttonLocatario.Name = "buttonLocatario";
            this.buttonLocatario.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonLocatario.Size = new System.Drawing.Size(208, 60);
            this.buttonLocatario.TabIndex = 1;
            this.buttonLocatario.Text = "   Locatário";
            this.buttonLocatario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLocatario.UseVisualStyleBackColor = false;
            this.buttonLocatario.Click += new System.EventHandler(this.buttonLocatario_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(208, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCarregamento
            // 
            this.panelCarregamento.BackColor = System.Drawing.SystemColors.Control;
            this.panelCarregamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarregamento.Location = new System.Drawing.Point(208, 0);
            this.panelCarregamento.Name = "panelCarregamento";
            this.panelCarregamento.Size = new System.Drawing.Size(776, 749);
            this.panelCarregamento.TabIndex = 1;
            // 
            // buttonContrato
            // 
            this.buttonContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.buttonContrato.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonContrato.FlatAppearance.BorderSize = 0;
            this.buttonContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContrato.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContrato.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonContrato.Image = ((System.Drawing.Image)(resources.GetObject("buttonContrato.Image")));
            this.buttonContrato.Location = new System.Drawing.Point(0, 238);
            this.buttonContrato.Name = "buttonContrato";
            this.buttonContrato.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonContrato.Size = new System.Drawing.Size(208, 60);
            this.buttonContrato.TabIndex = 3;
            this.buttonContrato.Text = "   Contrato";
            this.buttonContrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonContrato.UseVisualStyleBackColor = false;
            this.buttonContrato.Click += new System.EventHandler(this.buttonContrato_Click);
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
        private Button buttonLocatario;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelCarregamento;
        private Panel panelCrudLocatario;
        private Button buttonPesquisar;
        private Button buttonCadastrar;
        private Button buttonContrato;
    }
}
namespace View.Telas
{
    partial class FormCadastrarContrato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textQtdMeses = new System.Windows.Forms.TextBox();
            this.groupFormaPagamento = new System.Windows.Forms.GroupBox();
            this.radioDepósito = new System.Windows.Forms.RadioButton();
            this.radioBoleto = new System.Windows.Forms.RadioButton();
            this.radioPix = new System.Windows.Forms.RadioButton();
            this.radioDinherio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textObservacoes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedCpf = new System.Windows.Forms.MaskedTextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupFormaPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(547, 491);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Locatário";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(615, 63);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(240, 23);
            this.textName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Início do Contrato";
            // 
            // maskedDataInicio
            // 
            this.maskedDataInicio.Location = new System.Drawing.Point(618, 165);
            this.maskedDataInicio.Mask = "00/00/0000";
            this.maskedDataInicio.Name = "maskedDataInicio";
            this.maskedDataInicio.Size = new System.Drawing.Size(100, 23);
            this.maskedDataInicio.TabIndex = 5;
            this.maskedDataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedDataInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedDataFinal
            // 
            this.maskedDataFinal.Location = new System.Drawing.Point(755, 165);
            this.maskedDataFinal.Mask = "00/00/0000";
            this.maskedDataFinal.Name = "maskedDataFinal";
            this.maskedDataFinal.Size = new System.Drawing.Size(100, 23);
            this.maskedDataFinal.TabIndex = 6;
            this.maskedDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedDataFinal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Final do Contrato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade de Meses";
            // 
            // textQtdMeses
            // 
            this.textQtdMeses.Location = new System.Drawing.Point(618, 219);
            this.textQtdMeses.Name = "textQtdMeses";
            this.textQtdMeses.Size = new System.Drawing.Size(100, 23);
            this.textQtdMeses.TabIndex = 9;
            // 
            // groupFormaPagamento
            // 
            this.groupFormaPagamento.Controls.Add(this.radioDepósito);
            this.groupFormaPagamento.Controls.Add(this.radioBoleto);
            this.groupFormaPagamento.Controls.Add(this.radioPix);
            this.groupFormaPagamento.Controls.Add(this.radioDinherio);
            this.groupFormaPagamento.Location = new System.Drawing.Point(618, 248);
            this.groupFormaPagamento.Name = "groupFormaPagamento";
            this.groupFormaPagamento.Size = new System.Drawing.Size(237, 124);
            this.groupFormaPagamento.TabIndex = 10;
            this.groupFormaPagamento.TabStop = false;
            this.groupFormaPagamento.Text = "Forma de Pagamento";
            // 
            // radioDepósito
            // 
            this.radioDepósito.AutoSize = true;
            this.radioDepósito.Location = new System.Drawing.Point(9, 92);
            this.radioDepósito.Name = "radioDepósito";
            this.radioDepósito.Size = new System.Drawing.Size(72, 19);
            this.radioDepósito.TabIndex = 3;
            this.radioDepósito.TabStop = true;
            this.radioDepósito.Tag = "Depósito";
            this.radioDepósito.Text = "Depósito";
            this.radioDepósito.UseVisualStyleBackColor = true;
            // 
            // radioBoleto
            // 
            this.radioBoleto.AutoSize = true;
            this.radioBoleto.Location = new System.Drawing.Point(9, 69);
            this.radioBoleto.Name = "radioBoleto";
            this.radioBoleto.Size = new System.Drawing.Size(59, 19);
            this.radioBoleto.TabIndex = 2;
            this.radioBoleto.TabStop = true;
            this.radioBoleto.Tag = "Boleto";
            this.radioBoleto.Text = "Boleto";
            this.radioBoleto.UseVisualStyleBackColor = true;
            // 
            // radioPix
            // 
            this.radioPix.AutoSize = true;
            this.radioPix.Location = new System.Drawing.Point(9, 44);
            this.radioPix.Name = "radioPix";
            this.radioPix.Size = new System.Drawing.Size(41, 19);
            this.radioPix.TabIndex = 1;
            this.radioPix.TabStop = true;
            this.radioPix.Tag = "Pix";
            this.radioPix.Text = "Pix";
            this.radioPix.UseVisualStyleBackColor = true;
            // 
            // radioDinherio
            // 
            this.radioDinherio.AutoSize = true;
            this.radioDinherio.Location = new System.Drawing.Point(9, 22);
            this.radioDinherio.Name = "radioDinherio";
            this.radioDinherio.Size = new System.Drawing.Size(70, 19);
            this.radioDinherio.TabIndex = 0;
            this.radioDinherio.TabStop = true;
            this.radioDinherio.Tag = "Dinheiro";
            this.radioDinherio.Text = "Dinheiro";
            this.radioDinherio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(618, 406);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 23);
            this.textValor.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Observações";
            // 
            // textObservacoes
            // 
            this.textObservacoes.Location = new System.Drawing.Point(618, 464);
            this.textObservacoes.Multiline = true;
            this.textObservacoes.Name = "textObservacoes";
            this.textObservacoes.Size = new System.Drawing.Size(237, 151);
            this.textObservacoes.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(616, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "CPF";
            // 
            // maskedCpf
            // 
            this.maskedCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedCpf.Location = new System.Drawing.Point(615, 109);
            this.maskedCpf.Mask = "000,000,000-00";
            this.maskedCpf.Name = "maskedCpf";
            this.maskedCpf.ReadOnly = true;
            this.maskedCpf.Size = new System.Drawing.Size(240, 29);
            this.maskedCpf.TabIndex = 16;
            this.maskedCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(21, 622);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSelecionar.TabIndex = 17;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(1055, 644);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 18;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // FormCadastrarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 679);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.maskedCpf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textObservacoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupFormaPagamento);
            this.Controls.Add(this.textQtdMeses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedDataFinal);
            this.Controls.Add(this.maskedDataInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCadastrarContrato";
            this.Text = "FormCadastrarContrato";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupFormaPagamento.ResumeLayout(false);
            this.groupFormaPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textName;
        private Label label2;
        private MaskedTextBox maskedDataInicio;
        private MaskedTextBox maskedDataFinal;
        private Label label3;
        private Label label4;
        private TextBox textQtdMeses;
        private GroupBox groupFormaPagamento;
        private RadioButton radioPix;
        private RadioButton radioDinherio;
        private RadioButton radioDepósito;
        private RadioButton radioBoleto;
        private Label label5;
        private TextBox textValor;
        private Label label6;
        private TextBox textObservacoes;
        private Label label7;
        private MaskedTextBox maskedCpf;
        private Button buttonSelecionar;
        private Button buttonCadastrar;
    }
}
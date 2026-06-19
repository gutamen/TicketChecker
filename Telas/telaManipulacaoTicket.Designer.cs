namespace TicketChecker.Telas
{
    partial class telaManipulacaoTicket
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
            this.ticketPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelMenuTicket = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelFuncionario = new System.Windows.Forms.Label();
            this.textBoxFuncionarioID = new System.Windows.Forms.TextBox();
            this.subpanelFuncionario = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBuscaFuncionario = new System.Windows.Forms.Button();
            this.textBoxFuncionarioNome = new System.Windows.Forms.TextBox();
            this.labelQuatidade = new System.Windows.Forms.Label();
            this.upDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.labelAtivo = new System.Windows.Forms.Label();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonRetroceder = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.ticketPanel.SuspendLayout();
            this.subpanelFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketPanel
            // 
            this.ticketPanel.ColumnCount = 3;
            this.ticketPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ticketPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ticketPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ticketPanel.Controls.Add(this.labelMenuTicket, 1, 0);
            this.ticketPanel.Controls.Add(this.textBoxID, 1, 1);
            this.ticketPanel.Controls.Add(this.labelID, 0, 1);
            this.ticketPanel.Controls.Add(this.labelFuncionario, 0, 2);
            this.ticketPanel.Controls.Add(this.textBoxFuncionarioID, 1, 2);
            this.ticketPanel.Controls.Add(this.subpanelFuncionario, 2, 2);
            this.ticketPanel.Controls.Add(this.labelQuatidade, 0, 3);
            this.ticketPanel.Controls.Add(this.upDownQuantidade, 1, 3);
            this.ticketPanel.Controls.Add(this.labelAtivo, 0, 4);
            this.ticketPanel.Controls.Add(this.checkBoxAtivo, 1, 4);
            this.ticketPanel.Controls.Add(this.textBox3, 1, 5);
            this.ticketPanel.Controls.Add(this.labelData, 0, 5);
            this.ticketPanel.Controls.Add(this.buttonRetroceder, 0, 6);
            this.ticketPanel.Controls.Add(this.buttonConfirmar, 2, 6);
            this.ticketPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketPanel.Location = new System.Drawing.Point(0, 0);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.RowCount = 7;
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ticketPanel.Size = new System.Drawing.Size(784, 561);
            this.ticketPanel.TabIndex = 0;
            // 
            // labelMenuTicket
            // 
            this.labelMenuTicket.AutoSize = true;
            this.labelMenuTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMenuTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuTicket.Location = new System.Drawing.Point(264, 0);
            this.labelMenuTicket.Name = "labelMenuTicket";
            this.labelMenuTicket.Size = new System.Drawing.Size(255, 25);
            this.labelMenuTicket.TabIndex = 0;
            this.labelMenuTicket.Text = "Nulo";
            this.labelMenuTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxID
            // 
            this.textBoxID.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.HideSelection = false;
            this.textBoxID.Location = new System.Drawing.Point(264, 28);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(40, 29);
            this.textBoxID.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(231, 25);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 89);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // labelFuncionario
            // 
            this.labelFuncionario.AutoSize = true;
            this.labelFuncionario.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncionario.Location = new System.Drawing.Point(147, 114);
            this.labelFuncionario.Name = "labelFuncionario";
            this.labelFuncionario.Size = new System.Drawing.Size(111, 89);
            this.labelFuncionario.TabIndex = 3;
            this.labelFuncionario.Text = "Funcionário";
            // 
            // textBoxFuncionarioID
            // 
            this.textBoxFuncionarioID.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxFuncionarioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFuncionarioID.Location = new System.Drawing.Point(264, 117);
            this.textBoxFuncionarioID.Name = "textBoxFuncionarioID";
            this.textBoxFuncionarioID.Size = new System.Drawing.Size(40, 29);
            this.textBoxFuncionarioID.TabIndex = 4;
            // 
            // subpanelFuncionario
            // 
            this.subpanelFuncionario.ColumnCount = 2;
            this.subpanelFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subpanelFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subpanelFuncionario.Controls.Add(this.buttonBuscaFuncionario, 1, 0);
            this.subpanelFuncionario.Controls.Add(this.textBoxFuncionarioNome, 0, 0);
            this.subpanelFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subpanelFuncionario.Location = new System.Drawing.Point(525, 117);
            this.subpanelFuncionario.Name = "subpanelFuncionario";
            this.subpanelFuncionario.RowCount = 1;
            this.subpanelFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subpanelFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.subpanelFuncionario.Size = new System.Drawing.Size(256, 83);
            this.subpanelFuncionario.TabIndex = 5;
            // 
            // buttonBuscaFuncionario
            // 
            this.buttonBuscaFuncionario.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBuscaFuncionario.Location = new System.Drawing.Point(131, 3);
            this.buttonBuscaFuncionario.Name = "buttonBuscaFuncionario";
            this.buttonBuscaFuncionario.Size = new System.Drawing.Size(75, 77);
            this.buttonBuscaFuncionario.TabIndex = 0;
            this.buttonBuscaFuncionario.Text = "Buscar";
            this.buttonBuscaFuncionario.UseVisualStyleBackColor = true;
            this.buttonBuscaFuncionario.Click += new System.EventHandler(this.buscarFuncionarioClickListener);
            // 
            // textBoxFuncionarioNome
            // 
            this.textBoxFuncionarioNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFuncionarioNome.Location = new System.Drawing.Point(3, 3);
            this.textBoxFuncionarioNome.Name = "textBoxFuncionarioNome";
            this.textBoxFuncionarioNome.Size = new System.Drawing.Size(122, 20);
            this.textBoxFuncionarioNome.TabIndex = 1;
            // 
            // labelQuatidade
            // 
            this.labelQuatidade.AutoSize = true;
            this.labelQuatidade.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelQuatidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuatidade.Location = new System.Drawing.Point(68, 203);
            this.labelQuatidade.Name = "labelQuatidade";
            this.labelQuatidade.Size = new System.Drawing.Size(190, 89);
            this.labelQuatidade.TabIndex = 6;
            this.labelQuatidade.Text = "Quantidade de Ticket";
            // 
            // upDownQuantidade
            // 
            this.upDownQuantidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.upDownQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownQuantidade.Location = new System.Drawing.Point(264, 206);
            this.upDownQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDownQuantidade.Name = "upDownQuantidade";
            this.upDownQuantidade.Size = new System.Drawing.Size(255, 29);
            this.upDownQuantidade.TabIndex = 7;
            // 
            // labelAtivo
            // 
            this.labelAtivo.AutoSize = true;
            this.labelAtivo.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtivo.Location = new System.Drawing.Point(207, 292);
            this.labelAtivo.Name = "labelAtivo";
            this.labelAtivo.Size = new System.Drawing.Size(51, 89);
            this.labelAtivo.TabIndex = 8;
            this.labelAtivo.Text = "Ativo";
            this.labelAtivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAtivo.Location = new System.Drawing.Point(264, 295);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(255, 83);
            this.checkBoxAtivo.TabIndex = 9;
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(264, 384);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 29);
            this.textBox3.TabIndex = 11;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(113, 381);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(145, 89);
            this.labelData.TabIndex = 12;
            this.labelData.Text = "Data de Entrega";
            // 
            // buttonRetroceder
            // 
            this.buttonRetroceder.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetroceder.Location = new System.Drawing.Point(58, 473);
            this.buttonRetroceder.Name = "buttonRetroceder";
            this.buttonRetroceder.Size = new System.Drawing.Size(200, 85);
            this.buttonRetroceder.TabIndex = 13;
            this.buttonRetroceder.Text = "Retroceder";
            this.buttonRetroceder.UseVisualStyleBackColor = true;
            this.buttonRetroceder.Click += new System.EventHandler(this.retornarClickListener);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(525, 473);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(200, 85);
            this.buttonConfirmar.TabIndex = 14;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // telaManipulacaoTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ticketPanel);
            this.Name = "telaManipulacaoTicket";
            this.Text = "Ticket";
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
            this.subpanelFuncionario.ResumeLayout(false);
            this.subpanelFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ticketPanel;
        private System.Windows.Forms.Label labelMenuTicket;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelFuncionario;
        private System.Windows.Forms.TextBox textBoxFuncionarioID;
        private System.Windows.Forms.TableLayoutPanel subpanelFuncionario;
        private System.Windows.Forms.Label labelQuatidade;
        private System.Windows.Forms.NumericUpDown upDownQuantidade;
        private System.Windows.Forms.Label labelAtivo;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonRetroceder;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonBuscaFuncionario;
        private System.Windows.Forms.TextBox textBoxFuncionarioNome;
    }
}
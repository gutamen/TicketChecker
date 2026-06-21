namespace TicketChecker.Telas
{
    partial class TelaRelatorio
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
            this.panelRelatorio = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRetroceder = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelRelatorio = new System.Windows.Forms.Label();
            this.radioNome = new System.Windows.Forms.RadioButton();
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.labelFuncionario = new System.Windows.Forms.Label();
            this.radioData = new System.Windows.Forms.RadioButton();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.panelFuncionario = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFuncionario = new System.Windows.Forms.TextBox();
            this.buttonBuscarFuncionario = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.panelDataInicio = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDataIncial = new System.Windows.Forms.TextBox();
            this.buttonDataInicial = new System.Windows.Forms.Button();
            this.panelDataFinal = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDataFinal = new System.Windows.Forms.TextBox();
            this.buttonDataFinal = new System.Windows.Forms.Button();
            this.panelRelatorio.SuspendLayout();
            this.panelFuncionario.SuspendLayout();
            this.panelDataInicio.SuspendLayout();
            this.panelDataFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRelatorio
            // 
            this.panelRelatorio.ColumnCount = 3;
            this.panelRelatorio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.panelRelatorio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.panelRelatorio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.panelRelatorio.Controls.Add(this.buttonRetroceder, 0, 5);
            this.panelRelatorio.Controls.Add(this.buttonConfirmar, 2, 5);
            this.panelRelatorio.Controls.Add(this.labelRelatorio, 1, 0);
            this.panelRelatorio.Controls.Add(this.radioNome, 0, 2);
            this.panelRelatorio.Controls.Add(this.labelOrdenar, 0, 1);
            this.panelRelatorio.Controls.Add(this.labelFuncionario, 2, 1);
            this.panelRelatorio.Controls.Add(this.radioData, 0, 3);
            this.panelRelatorio.Controls.Add(this.radioId, 0, 4);
            this.panelRelatorio.Controls.Add(this.panelFuncionario, 2, 2);
            this.panelRelatorio.Controls.Add(this.labelData, 1, 1);
            this.panelRelatorio.Controls.Add(this.panelDataInicio, 1, 2);
            this.panelRelatorio.Controls.Add(this.panelDataFinal, 1, 3);
            this.panelRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRelatorio.Location = new System.Drawing.Point(0, 0);
            this.panelRelatorio.Name = "panelRelatorio";
            this.panelRelatorio.RowCount = 6;
            this.panelRelatorio.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRelatorio.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRelatorio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelRelatorio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelRelatorio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelRelatorio.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRelatorio.Size = new System.Drawing.Size(784, 561);
            this.panelRelatorio.TabIndex = 0;
            // 
            // buttonRetroceder
            // 
            this.buttonRetroceder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetroceder.Location = new System.Drawing.Point(3, 458);
            this.buttonRetroceder.Name = "buttonRetroceder";
            this.buttonRetroceder.Size = new System.Drawing.Size(255, 100);
            this.buttonRetroceder.TabIndex = 16;
            this.buttonRetroceder.Text = "Retroceder";
            this.buttonRetroceder.UseVisualStyleBackColor = true;
            this.buttonRetroceder.Click += new System.EventHandler(this.retrocederClick);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(525, 458);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(256, 100);
            this.buttonConfirmar.TabIndex = 15;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.confirmarClick);
            // 
            // labelRelatorio
            // 
            this.labelRelatorio.AutoSize = true;
            this.labelRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelatorio.Location = new System.Drawing.Point(264, 0);
            this.labelRelatorio.Name = "labelRelatorio";
            this.labelRelatorio.Size = new System.Drawing.Size(255, 25);
            this.labelRelatorio.TabIndex = 0;
            this.labelRelatorio.Text = "Gerar Relatório";
            this.labelRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioNome
            // 
            this.radioNome.AutoSize = true;
            this.radioNome.Location = new System.Drawing.Point(3, 52);
            this.radioNome.Name = "radioNome";
            this.radioNome.Size = new System.Drawing.Size(53, 17);
            this.radioNome.TabIndex = 1;
            this.radioNome.TabStop = true;
            this.radioNome.Text = "Nome";
            this.radioNome.UseVisualStyleBackColor = true;
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenar.Location = new System.Drawing.Point(3, 25);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(255, 24);
            this.labelOrdenar.TabIndex = 17;
            this.labelOrdenar.Text = "Ordenar Por:";
            this.labelOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFuncionario
            // 
            this.labelFuncionario.AutoSize = true;
            this.labelFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncionario.Location = new System.Drawing.Point(525, 25);
            this.labelFuncionario.Name = "labelFuncionario";
            this.labelFuncionario.Size = new System.Drawing.Size(256, 24);
            this.labelFuncionario.TabIndex = 18;
            this.labelFuncionario.Text = "Funcionário:";
            this.labelFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioData
            // 
            this.radioData.AutoSize = true;
            this.radioData.Location = new System.Drawing.Point(3, 187);
            this.radioData.Name = "radioData";
            this.radioData.Size = new System.Drawing.Size(103, 17);
            this.radioData.TabIndex = 19;
            this.radioData.TabStop = true;
            this.radioData.Text = "Data de Entrega";
            this.radioData.UseVisualStyleBackColor = true;
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Location = new System.Drawing.Point(3, 322);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(36, 17);
            this.radioId.TabIndex = 20;
            this.radioId.TabStop = true;
            this.radioId.Text = "ID";
            this.radioId.UseVisualStyleBackColor = true;
            // 
            // panelFuncionario
            // 
            this.panelFuncionario.ColumnCount = 2;
            this.panelFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.75758F));
            this.panelFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.24242F));
            this.panelFuncionario.Controls.Add(this.textBoxFuncionario, 0, 0);
            this.panelFuncionario.Controls.Add(this.buttonBuscarFuncionario, 1, 0);
            this.panelFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFuncionario.Location = new System.Drawing.Point(525, 52);
            this.panelFuncionario.Name = "panelFuncionario";
            this.panelFuncionario.RowCount = 1;
            this.panelFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelFuncionario.Size = new System.Drawing.Size(256, 129);
            this.panelFuncionario.TabIndex = 21;
            // 
            // textBoxFuncionario
            // 
            this.textBoxFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFuncionario.Enabled = false;
            this.textBoxFuncionario.HideSelection = false;
            this.textBoxFuncionario.Location = new System.Drawing.Point(3, 3);
            this.textBoxFuncionario.Name = "textBoxFuncionario";
            this.textBoxFuncionario.Size = new System.Drawing.Size(187, 20);
            this.textBoxFuncionario.TabIndex = 0;
            // 
            // buttonBuscarFuncionario
            // 
            this.buttonBuscarFuncionario.AutoSize = true;
            this.buttonBuscarFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBuscarFuncionario.Location = new System.Drawing.Point(196, 3);
            this.buttonBuscarFuncionario.Name = "buttonBuscarFuncionario";
            this.buttonBuscarFuncionario.Size = new System.Drawing.Size(57, 23);
            this.buttonBuscarFuncionario.TabIndex = 1;
            this.buttonBuscarFuncionario.Text = "Buscar";
            this.buttonBuscarFuncionario.UseVisualStyleBackColor = true;
            this.buttonBuscarFuncionario.Click += new System.EventHandler(this.buscarFuncionarioClick);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(264, 25);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(255, 24);
            this.labelData.TabIndex = 22;
            this.labelData.Text = "Data:";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDataInicio
            // 
            this.panelDataInicio.ColumnCount = 2;
            this.panelDataInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.panelDataInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.panelDataInicio.Controls.Add(this.textBoxDataIncial, 0, 0);
            this.panelDataInicio.Controls.Add(this.buttonDataInicial, 1, 0);
            this.panelDataInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataInicio.Location = new System.Drawing.Point(264, 52);
            this.panelDataInicio.Name = "panelDataInicio";
            this.panelDataInicio.RowCount = 1;
            this.panelDataInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDataInicio.Size = new System.Drawing.Size(255, 129);
            this.panelDataInicio.TabIndex = 23;
            // 
            // textBoxDataIncial
            // 
            this.textBoxDataIncial.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDataIncial.Enabled = false;
            this.textBoxDataIncial.Location = new System.Drawing.Point(3, 3);
            this.textBoxDataIncial.Name = "textBoxDataIncial";
            this.textBoxDataIncial.Size = new System.Drawing.Size(213, 20);
            this.textBoxDataIncial.TabIndex = 0;
            // 
            // buttonDataInicial
            // 
            this.buttonDataInicial.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDataInicial.Location = new System.Drawing.Point(222, 3);
            this.buttonDataInicial.Name = "buttonDataInicial";
            this.buttonDataInicial.Size = new System.Drawing.Size(30, 23);
            this.buttonDataInicial.TabIndex = 1;
            this.buttonDataInicial.Text = "🔍";
            this.buttonDataInicial.UseVisualStyleBackColor = true;
            this.buttonDataInicial.Click += new System.EventHandler(this.selectDataClick);
            // 
            // panelDataFinal
            // 
            this.panelDataFinal.ColumnCount = 2;
            this.panelDataFinal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.panelDataFinal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.panelDataFinal.Controls.Add(this.textBoxDataFinal, 0, 0);
            this.panelDataFinal.Controls.Add(this.buttonDataFinal, 1, 0);
            this.panelDataFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataFinal.Location = new System.Drawing.Point(264, 187);
            this.panelDataFinal.Name = "panelDataFinal";
            this.panelDataFinal.RowCount = 1;
            this.panelDataFinal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDataFinal.Size = new System.Drawing.Size(255, 129);
            this.panelDataFinal.TabIndex = 24;
            // 
            // textBoxDataFinal
            // 
            this.textBoxDataFinal.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDataFinal.Enabled = false;
            this.textBoxDataFinal.Location = new System.Drawing.Point(3, 3);
            this.textBoxDataFinal.Name = "textBoxDataFinal";
            this.textBoxDataFinal.Size = new System.Drawing.Size(213, 20);
            this.textBoxDataFinal.TabIndex = 0;
            // 
            // buttonDataFinal
            // 
            this.buttonDataFinal.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDataFinal.Location = new System.Drawing.Point(222, 3);
            this.buttonDataFinal.Name = "buttonDataFinal";
            this.buttonDataFinal.Size = new System.Drawing.Size(30, 23);
            this.buttonDataFinal.TabIndex = 1;
            this.buttonDataFinal.Text = "🔍";
            this.buttonDataFinal.UseVisualStyleBackColor = true;
            this.buttonDataFinal.Click += new System.EventHandler(this.selectDataClick);
            // 
            // TelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelRelatorio);
            this.Name = "TelaRelatorio";
            this.Text = "Relatórios";
            this.Activated += new System.EventHandler(this.onActivated);
            this.panelRelatorio.ResumeLayout(false);
            this.panelRelatorio.PerformLayout();
            this.panelFuncionario.ResumeLayout(false);
            this.panelFuncionario.PerformLayout();
            this.panelDataInicio.ResumeLayout(false);
            this.panelDataInicio.PerformLayout();
            this.panelDataFinal.ResumeLayout(false);
            this.panelDataFinal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelRelatorio;
        private System.Windows.Forms.Label labelRelatorio;
        private System.Windows.Forms.RadioButton radioNome;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonRetroceder;
        private System.Windows.Forms.Label labelOrdenar;
        private System.Windows.Forms.Label labelFuncionario;
        private System.Windows.Forms.RadioButton radioData;
        private System.Windows.Forms.RadioButton radioId;
        private System.Windows.Forms.TableLayoutPanel panelFuncionario;
        private System.Windows.Forms.TextBox textBoxFuncionario;
        private System.Windows.Forms.Button buttonBuscarFuncionario;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TableLayoutPanel panelDataInicio;
        private System.Windows.Forms.TableLayoutPanel panelDataFinal;
        private System.Windows.Forms.TextBox textBoxDataIncial;
        private System.Windows.Forms.TextBox textBoxDataFinal;
        private System.Windows.Forms.Button buttonDataFinal;
        private System.Windows.Forms.Button buttonDataInicial;
    }
}
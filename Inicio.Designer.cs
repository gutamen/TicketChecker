namespace TicketChecker
{
    partial class Inicio
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
            this.cadastrarFuncionario = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.editarFuncionario = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.cadastrarTickets = new System.Windows.Forms.Button();
            this.editarTickets = new System.Windows.Forms.Button();
            this.gerarRelatorio = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastrarFuncionario
            // 
            this.cadastrarFuncionario.AutoSize = true;
            this.cadastrarFuncionario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cadastrarFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.cadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarFuncionario.Location = new System.Drawing.Point(264, 38);
            this.cadastrarFuncionario.MinimumSize = new System.Drawing.Size(0, 50);
            this.cadastrarFuncionario.Name = "cadastrarFuncionario";
            this.cadastrarFuncionario.Size = new System.Drawing.Size(255, 50);
            this.cadastrarFuncionario.TabIndex = 0;
            this.cadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.cadastrarFuncionario.UseVisualStyleBackColor = true;
            this.cadastrarFuncionario.Click += new System.EventHandler(this.cadastrarFuncionarioClickListener);
            // 
            // menuPanel
            // 
            this.menuPanel.ColumnCount = 3;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.menuPanel.Controls.Add(this.cadastrarFuncionario, 1, 1);
            this.menuPanel.Controls.Add(this.editarFuncionario, 1, 2);
            this.menuPanel.Controls.Add(this.labelMenu, 1, 0);
            this.menuPanel.Controls.Add(this.cadastrarTickets, 2, 1);
            this.menuPanel.Controls.Add(this.editarTickets, 2, 2);
            this.menuPanel.Controls.Add(this.gerarRelatorio, 0, 2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 3;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuPanel.Size = new System.Drawing.Size(784, 561);
            this.menuPanel.TabIndex = 1;
            // 
            // editarFuncionario
            // 
            this.editarFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.editarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarFuncionario.Location = new System.Drawing.Point(264, 301);
            this.editarFuncionario.MinimumSize = new System.Drawing.Size(0, 50);
            this.editarFuncionario.Name = "editarFuncionario";
            this.editarFuncionario.Size = new System.Drawing.Size(255, 50);
            this.editarFuncionario.TabIndex = 1;
            this.editarFuncionario.Text = "Editar Funcionário";
            this.editarFuncionario.UseVisualStyleBackColor = true;
            this.editarFuncionario.Click += new System.EventHandler(this.editarFuncionarioClickListener);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(264, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Padding = new System.Windows.Forms.Padding(5);
            this.labelMenu.Size = new System.Drawing.Size(255, 35);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "Selecione a Operação";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cadastrarTickets
            // 
            this.cadastrarTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.cadastrarTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarTickets.Location = new System.Drawing.Point(525, 38);
            this.cadastrarTickets.MinimumSize = new System.Drawing.Size(0, 50);
            this.cadastrarTickets.Name = "cadastrarTickets";
            this.cadastrarTickets.Size = new System.Drawing.Size(256, 50);
            this.cadastrarTickets.TabIndex = 3;
            this.cadastrarTickets.Text = "Cadastrar Tickets";
            this.cadastrarTickets.UseVisualStyleBackColor = true;
            // 
            // editarTickets
            // 
            this.editarTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.editarTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarTickets.Location = new System.Drawing.Point(525, 301);
            this.editarTickets.MinimumSize = new System.Drawing.Size(0, 50);
            this.editarTickets.Name = "editarTickets";
            this.editarTickets.Size = new System.Drawing.Size(256, 50);
            this.editarTickets.TabIndex = 4;
            this.editarTickets.Text = "Editar Tickets";
            this.editarTickets.UseVisualStyleBackColor = true;
            // 
            // gerarRelatorio
            // 
            this.gerarRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.gerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarRelatorio.Location = new System.Drawing.Point(3, 301);
            this.gerarRelatorio.MinimumSize = new System.Drawing.Size(0, 50);
            this.gerarRelatorio.Name = "gerarRelatorio";
            this.gerarRelatorio.Size = new System.Drawing.Size(255, 50);
            this.gerarRelatorio.TabIndex = 5;
            this.gerarRelatorio.Text = "Gerar Relatório";
            this.gerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuPanel);
            this.Name = "Inicio";
            this.Text = "Menu";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadastrarFuncionario;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.Button editarFuncionario;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button cadastrarTickets;
        private System.Windows.Forms.Button editarTickets;
        private System.Windows.Forms.Button gerarRelatorio;
    }
}


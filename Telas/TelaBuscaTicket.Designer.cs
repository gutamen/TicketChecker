namespace TicketChecker.Telas
{
    partial class TelaBuscaTicket
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
            this.panelBusca = new System.Windows.Forms.TableLayoutPanel();
            this.Buscar = new System.Windows.Forms.Button();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.listBuscaTicket = new System.Windows.Forms.ListBox();
            this.panelBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBusca
            // 
            this.panelBusca.ColumnCount = 2;
            this.panelBusca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.panelBusca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelBusca.Controls.Add(this.Buscar, 1, 1);
            this.panelBusca.Controls.Add(this.textBoxBusca, 0, 1);
            this.panelBusca.Controls.Add(this.listBuscaTicket, 0, 0);
            this.panelBusca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusca.Location = new System.Drawing.Point(0, 0);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.RowCount = 2;
            this.panelBusca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelBusca.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelBusca.Size = new System.Drawing.Size(584, 361);
            this.panelBusca.TabIndex = 0;
            // 
            // Buscar
            // 
            this.Buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buscar.Location = new System.Drawing.Point(528, 329);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(53, 29);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.buscarClickListener);
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusca.Location = new System.Drawing.Point(3, 329);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(519, 29);
            this.textBoxBusca.TabIndex = 1;
            // 
            // listBuscaTicket
            // 
            this.listBuscaTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBuscaTicket.FormattingEnabled = true;
            this.listBuscaTicket.Location = new System.Drawing.Point(3, 3);
            this.listBuscaTicket.Name = "listBuscaTicket";
            this.listBuscaTicket.Size = new System.Drawing.Size(519, 320);
            this.listBuscaTicket.TabIndex = 2;
            this.listBuscaTicket.DoubleClick += new System.EventHandler(this.selectIndexBusca);
            // 
            // TelaBuscaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panelBusca);
            this.Name = "TelaBuscaTicket";
            this.Text = "Busca Ticket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelBusca;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.ListBox listBuscaTicket;
    }
}
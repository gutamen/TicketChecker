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
            this.ticketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketPanel
            // 
            this.ticketPanel.ColumnCount = 3;
            this.ticketPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ticketPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ticketPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ticketPanel.Controls.Add(this.labelMenuTicket, 1, 0);
            this.ticketPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketPanel.Location = new System.Drawing.Point(0, 0);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.RowCount = 4;
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ticketPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ticketPanel.Size = new System.Drawing.Size(800, 450);
            this.ticketPanel.TabIndex = 0;
            // 
            // labelMenuTicket
            // 
            this.labelMenuTicket.AutoSize = true;
            this.labelMenuTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMenuTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuTicket.Location = new System.Drawing.Point(269, 0);
            this.labelMenuTicket.Name = "labelMenuTicket";
            this.labelMenuTicket.Size = new System.Drawing.Size(260, 25);
            this.labelMenuTicket.TabIndex = 0;
            this.labelMenuTicket.Text = "Nulo";
            this.labelMenuTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telaManipulacaoTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ticketPanel);
            this.Name = "telaManipulacaoTicket";
            this.Text = "Ticket";
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ticketPanel;
        private System.Windows.Forms.Label labelMenuTicket;
    }
}
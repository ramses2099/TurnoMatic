namespace Com.Hit.TurnoMatic
{
    partial class FrmDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbTipoServicio = new System.Windows.Forms.Label();
            this.lblNumTicket = new System.Windows.Forms.Label();
            this.lblTituloTicket = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.65894F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.34106F));
            this.tableLayoutPanel.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(777, 416);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(349, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbTipoServicio);
            this.splitContainer1.Panel1.Controls.Add(this.lblNumTicket);
            this.splitContainer1.Panel1.Controls.Add(this.lblTituloTicket);
            this.splitContainer1.Panel1.UseWaitCursor = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.UseWaitCursor = true;
            this.splitContainer1.Size = new System.Drawing.Size(425, 410);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 13;
            this.splitContainer1.UseWaitCursor = true;
            // 
            // lbTipoServicio
            // 
            this.lbTipoServicio.AutoSize = true;
            this.lbTipoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoServicio.ForeColor = System.Drawing.Color.Red;
            this.lbTipoServicio.Location = new System.Drawing.Point(72, 97);
            this.lbTipoServicio.Name = "lbTipoServicio";
            this.lbTipoServicio.Size = new System.Drawing.Size(138, 73);
            this.lbTipoServicio.TabIndex = 11;
            this.lbTipoServicio.Text = "FP-";
            this.lbTipoServicio.UseWaitCursor = true;
            // 
            // lblNumTicket
            // 
            this.lblNumTicket.AutoSize = true;
            this.lblNumTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTicket.ForeColor = System.Drawing.Color.Red;
            this.lblNumTicket.Location = new System.Drawing.Point(201, 97);
            this.lblNumTicket.Name = "lblNumTicket";
            this.lblNumTicket.Size = new System.Drawing.Size(143, 73);
            this.lblNumTicket.TabIndex = 10;
            this.lblNumTicket.Text = "000";
            this.lblNumTicket.UseWaitCursor = true;
            // 
            // lblTituloTicket
            // 
            this.lblTituloTicket.AutoSize = true;
            this.lblTituloTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTicket.ForeColor = System.Drawing.Color.Navy;
            this.lblTituloTicket.Location = new System.Drawing.Point(91, 24);
            this.lblTituloTicket.Name = "lblTituloTicket";
            this.lblTituloTicket.Size = new System.Drawing.Size(209, 73);
            this.lblTituloTicket.TabIndex = 1;
            this.lblTituloTicket.Text = "Ticket";
            this.lblTituloTicket.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::Com.Hit.TurnoMatic.Properties.Resources.printer1;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(425, 201);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inprimir";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::Com.Hit.TurnoMatic.Properties.Resources.hit_logo;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(340, 410);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // FrmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 434);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialog";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Turnos Hit V2.0 - Numero Ticket";
            this.Load += new System.EventHandler(this.FrmDialog_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblNumTicket;
        private System.Windows.Forms.Label lblTituloTicket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTipoServicio;
    }
}

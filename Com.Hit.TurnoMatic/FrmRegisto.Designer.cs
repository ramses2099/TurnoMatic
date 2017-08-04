using System.Drawing;
using System.Windows.Forms;

namespace Com.Hit.TurnoMatic
{
    partial class FrmRegisto
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelloyExpresso = new System.Windows.Forms.Button();
            this.btnFactCredito = new System.Windows.Forms.Button();
            this.btnFactyPago = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Controls.Add(this.panel1);
            this.pnlTitulo.Controls.Add(this.lblTitulo2);
            this.pnlTitulo.Controls.Add(this.lblTitulo1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1264, 156);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Com.Hit.TurnoMatic.Properties.Resources.hit_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblTitulo3);
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 76);
            this.panel1.TabIndex = 3;
            this.panel1.UseWaitCursor = true;
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.ForeColor = System.Drawing.Color.White;
            this.lblTitulo3.Location = new System.Drawing.Point(344, 0);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(135, 42);
            this.lblTitulo3.TabIndex = 2;
            this.lblTitulo3.Text = "Turnos";
            this.lblTitulo3.UseWaitCursor = true;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(344, 51);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(634, 42);
            this.lblTitulo2.TabIndex = 2;
            this.lblTitulo2.Text = "Enfocados en la Calidad y Seguridad";
            this.lblTitulo2.UseWaitCursor = true;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.White;
            this.lblTitulo1.Location = new System.Drawing.Point(344, 9);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(302, 42);
            this.lblTitulo1.TabIndex = 1;
            this.lblTitulo1.Text = "Puerto Rio Haina";
            this.lblTitulo1.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSelloyExpresso, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFactCredito, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFactyPago, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(299, 178);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 503);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnSelloyExpresso
            // 
            this.btnSelloyExpresso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelloyExpresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelloyExpresso.Location = new System.Drawing.Point(3, 337);
            this.btnSelloyExpresso.Name = "btnSelloyExpresso";
            this.btnSelloyExpresso.Size = new System.Drawing.Size(637, 163);
            this.btnSelloyExpresso.TabIndex = 2;
            this.btnSelloyExpresso.Text = "Para Información Tomar el Teléfono";
            this.btnSelloyExpresso.UseVisualStyleBackColor = true;
            this.btnSelloyExpresso.Click += new System.EventHandler(this.btnSelloyExpresso_Click);
            // 
            // btnFactCredito
            // 
            this.btnFactCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFactCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactCredito.Location = new System.Drawing.Point(3, 170);
            this.btnFactCredito.Name = "btnFactCredito";
            this.btnFactCredito.Size = new System.Drawing.Size(637, 161);
            this.btnFactCredito.TabIndex = 1;
            this.btnFactCredito.Text = "Revisión";
            this.btnFactCredito.UseVisualStyleBackColor = true;
            this.btnFactCredito.Click += new System.EventHandler(this.btnFactCredito_Click);
            // 
            // btnFactyPago
            // 
            this.btnFactyPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFactyPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactyPago.Location = new System.Drawing.Point(3, 3);
            this.btnFactyPago.Name = "btnFactyPago";
            this.btnFactyPago.Size = new System.Drawing.Size(637, 161);
            this.btnFactyPago.TabIndex = 0;
            this.btnFactyPago.Text = "Facturación y Pago";
            this.btnFactyPago.UseVisualStyleBackColor = true;
            this.btnFactyPago.Click += new System.EventHandler(this.btnFactyPago_Click);
            // 
            // FrmRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegisto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Turnos Hit V2.0 - Registo Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRegisto_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblTitulo1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSelloyExpresso;
        private Button btnFactCredito;
        private Button btnFactyPago;
    }
}
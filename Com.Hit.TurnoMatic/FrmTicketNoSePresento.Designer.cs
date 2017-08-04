namespace Com.Hit.TurnoMatic
{
    partial class FrmTicketNoSePresento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTicketNoSePresento));
            this.gvListadodeColas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegresarCola = new System.Windows.Forms.Button();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListadodeColas)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListadodeColas
            // 
            this.gvListadodeColas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListadodeColas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            this.gvListadodeColas.Location = new System.Drawing.Point(12, 12);
            this.gvListadodeColas.Name = "gvListadodeColas";
            this.gvListadodeColas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvListadodeColas.Size = new System.Drawing.Size(432, 211);
            this.gvListadodeColas.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Com.Hit.TurnoMatic.Properties.Resources.turn_off;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(308, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 49);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegresarCola
            // 
            this.btnRegresarCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarCola.Image = global::Com.Hit.TurnoMatic.Properties.Resources.apply;
            this.btnRegresarCola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresarCola.Location = new System.Drawing.Point(12, 229);
            this.btnRegresarCola.Name = "btnRegresarCola";
            this.btnRegresarCola.Size = new System.Drawing.Size(196, 49);
            this.btnRegresarCola.TabIndex = 28;
            this.btnRegresarCola.Text = "Regresar Cola";
            this.btnRegresarCola.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresarCola.UseVisualStyleBackColor = true;
            this.btnRegresarCola.Click += new System.EventHandler(this.btnRegresarCola_Click);
            // 
            // col1
            // 
            this.col1.DataPropertyName = "IdTicket";
            this.col1.HeaderText = "IdTicket";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col2.DataPropertyName = "NumeroTicket";
            this.col2.HeaderText = "Numero Ticket";
            this.col2.Name = "col2";
            // 
            // col3
            // 
            this.col3.DataPropertyName = "FechaSistema";
            this.col3.HeaderText = "Fecha";
            this.col3.Name = "col3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(214, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 49);
            this.button1.TabIndex = 30;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTicketNoSePresento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresarCola);
            this.Controls.Add(this.gvListadodeColas);
            this.Name = "FrmTicketNoSePresento";
            this.Text = "Ticket No Se Presento";
            this.Load += new System.EventHandler(this.FrmTicketNoSePresento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListadodeColas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListadodeColas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegresarCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.Button button1;
    }
}
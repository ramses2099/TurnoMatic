namespace Com.Hit.TurnoMatic
{
    partial class FrmCajero
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblNombreCajero = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRevision = new System.Windows.Forms.Button();
            this.btnLlamarCliente = new System.Windows.Forms.Button();
            this.btnNoSePresento = new System.Windows.Forms.Button();
            this.btnAtendido = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumTicket = new System.Windows.Forms.Label();
            this.btnNuevoRL = new System.Windows.Forms.Button();
            this.btnNuevoFP = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvListadodeColas = new System.Windows.Forms.DataGridView();
            this.trBindingGrid = new System.Windows.Forms.Timer(this.components);
            this.colTurnoFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRevision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRevisionListo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListadodeColas)).BeginInit();
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
            this.pnlTitulo.Size = new System.Drawing.Size(1047, 156);
            this.pnlTitulo.TabIndex = 2;
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
            this.panel1.Controls.Add(this.lblCaja);
            this.panel1.Controls.Add(this.lblNombreCajero);
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 76);
            this.panel1.TabIndex = 3;
            this.panel1.UseWaitCursor = true;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.ForeColor = System.Drawing.Color.White;
            this.lblCaja.Location = new System.Drawing.Point(345, 10);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(91, 33);
            this.lblCaja.TabIndex = 3;
            this.lblCaja.Text = "Caja1";
            this.lblCaja.UseWaitCursor = true;
            // 
            // lblNombreCajero
            // 
            this.lblNombreCajero.AutoSize = true;
            this.lblNombreCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCajero.ForeColor = System.Drawing.Color.White;
            this.lblNombreCajero.Location = new System.Drawing.Point(530, 10);
            this.lblNombreCajero.Name = "lblNombreCajero";
            this.lblNombreCajero.Size = new System.Drawing.Size(264, 33);
            this.lblNombreCajero.TabIndex = 2;
            this.lblNombreCajero.Text = "Cajero: Juan Perez";
            this.lblNombreCajero.UseWaitCursor = true;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(345, 51);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(409, 29);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnRevision);
            this.panel2.Controls.Add(this.btnLlamarCliente);
            this.panel2.Controls.Add(this.btnNoSePresento);
            this.panel2.Controls.Add(this.btnAtendido);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnNuevoRL);
            this.panel2.Controls.Add(this.btnNuevoFP);
            this.panel2.Location = new System.Drawing.Point(3, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 537);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Com.Hit.TurnoMatic.Properties.Resources.turn_off;
            this.btnCancelar.Location = new System.Drawing.Point(9, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(491, 89);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar Ticket";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRevision
            // 
            this.btnRevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevision.Image = global::Com.Hit.TurnoMatic.Properties.Resources.apply;
            this.btnRevision.Location = new System.Drawing.Point(259, 342);
            this.btnRevision.Name = "btnRevision";
            this.btnRevision.Size = new System.Drawing.Size(241, 85);
            this.btnRevision.TabIndex = 27;
            this.btnRevision.Text = "Revisión";
            this.btnRevision.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRevision.UseVisualStyleBackColor = true;
            this.btnRevision.Click += new System.EventHandler(this.btnRevision_Click);
            // 
            // btnLlamarCliente
            // 
            this.btnLlamarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamarCliente.Image = global::Com.Hit.TurnoMatic.Properties.Resources.dial;
            this.btnLlamarCliente.Location = new System.Drawing.Point(8, 342);
            this.btnLlamarCliente.Name = "btnLlamarCliente";
            this.btnLlamarCliente.Size = new System.Drawing.Size(245, 85);
            this.btnLlamarCliente.TabIndex = 26;
            this.btnLlamarCliente.Text = "Llamar Cliente";
            this.btnLlamarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLlamarCliente.UseVisualStyleBackColor = true;
            this.btnLlamarCliente.Click += new System.EventHandler(this.btnLlamarCliente_Click);
            // 
            // btnNoSePresento
            // 
            this.btnNoSePresento.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoSePresento.Image = global::Com.Hit.TurnoMatic.Properties.Resources.thumbs_down;
            this.btnNoSePresento.Location = new System.Drawing.Point(259, 251);
            this.btnNoSePresento.Name = "btnNoSePresento";
            this.btnNoSePresento.Size = new System.Drawing.Size(241, 85);
            this.btnNoSePresento.TabIndex = 25;
            this.btnNoSePresento.Text = "No se Presento";
            this.btnNoSePresento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNoSePresento.UseVisualStyleBackColor = true;
            this.btnNoSePresento.Click += new System.EventHandler(this.btnNoSePresento_Click);
            // 
            // btnAtendido
            // 
            this.btnAtendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendido.Image = global::Com.Hit.TurnoMatic.Properties.Resources.thumbs_up;
            this.btnAtendido.Location = new System.Drawing.Point(9, 251);
            this.btnAtendido.Name = "btnAtendido";
            this.btnAtendido.Size = new System.Drawing.Size(244, 85);
            this.btnAtendido.TabIndex = 24;
            this.btnAtendido.Text = "Atendido";
            this.btnAtendido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtendido.UseVisualStyleBackColor = true;
            this.btnAtendido.Click += new System.EventHandler(this.btnAtendido_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblNumTicket);
            this.panel4.Location = new System.Drawing.Point(9, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(491, 112);
            this.panel4.TabIndex = 23;
            // 
            // lblNumTicket
            // 
            this.lblNumTicket.AutoSize = true;
            this.lblNumTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTicket.ForeColor = System.Drawing.Color.Red;
            this.lblNumTicket.Location = new System.Drawing.Point(109, 16);
            this.lblNumTicket.Name = "lblNumTicket";
            this.lblNumTicket.Size = new System.Drawing.Size(249, 73);
            this.lblNumTicket.TabIndex = 11;
            this.lblNumTicket.Text = "FP-000";
            this.lblNumTicket.UseWaitCursor = true;
            // 
            // btnNuevoRL
            // 
            this.btnNuevoRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRL.Image = global::Com.Hit.TurnoMatic.Properties.Resources.list;
            this.btnNuevoRL.Location = new System.Drawing.Point(259, 16);
            this.btnNuevoRL.Name = "btnNuevoRL";
            this.btnNuevoRL.Size = new System.Drawing.Size(241, 83);
            this.btnNuevoRL.TabIndex = 22;
            this.btnNuevoRL.Text = "Nuevo (RL)";
            this.btnNuevoRL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoRL.UseVisualStyleBackColor = true;
            this.btnNuevoRL.Click += new System.EventHandler(this.btnNuevoRL_Click);
            // 
            // btnNuevoFP
            // 
            this.btnNuevoFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoFP.Image = global::Com.Hit.TurnoMatic.Properties.Resources.list;
            this.btnNuevoFP.Location = new System.Drawing.Point(9, 16);
            this.btnNuevoFP.Name = "btnNuevoFP";
            this.btnNuevoFP.Size = new System.Drawing.Size(244, 82);
            this.btnNuevoFP.TabIndex = 21;
            this.btnNuevoFP.Text = "Nuevo (FP)";
            this.btnNuevoFP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoFP.UseVisualStyleBackColor = true;
            this.btnNuevoFP.Click += new System.EventHandler(this.btnNuevoFP_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gvListadodeColas);
            this.panel3.Location = new System.Drawing.Point(536, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 537);
            this.panel3.TabIndex = 4;
            // 
            // gvListadodeColas
            // 
            this.gvListadodeColas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListadodeColas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTurnoFP,
            this.ColRevision,
            this.ColRevisionListo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvListadodeColas.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvListadodeColas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvListadodeColas.Location = new System.Drawing.Point(0, 0);
            this.gvListadodeColas.Name = "gvListadodeColas";
            this.gvListadodeColas.Size = new System.Drawing.Size(503, 537);
            this.gvListadodeColas.TabIndex = 0;
            // 
            // trBindingGrid
            // 
            this.trBindingGrid.Enabled = true;
            this.trBindingGrid.Interval = 15000;
            this.trBindingGrid.Tick += new System.EventHandler(this.trBindingGrid_Tick);
            // 
            // colTurnoFP
            // 
            this.colTurnoFP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTurnoFP.DataPropertyName = "TurnosFP";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.colTurnoFP.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTurnoFP.HeaderText = "Turno (FP)";
            this.colTurnoFP.Name = "colTurnoFP";
            // 
            // ColRevision
            // 
            this.ColRevision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColRevision.DataPropertyName = "Revision";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ColRevision.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColRevision.HeaderText = "Revision (RV)";
            this.ColRevision.Name = "ColRevision";
            // 
            // ColRevisionListo
            // 
            this.ColRevisionListo.DataPropertyName = "RevisionLista";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ColRevisionListo.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColRevisionListo.HeaderText = "Revision Listo (RL)";
            this.ColRevisionListo.Name = "ColRevisionListo";
            // 
            // FrmCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 732);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "FrmCajero";
            this.Text = "Turnos Hit V2.0 - Cajero";
            this.Load += new System.EventHandler(this.FrmCajero_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListadodeColas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreCajero;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gvListadodeColas;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Button btnNuevoFP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNuevoRL;
        private System.Windows.Forms.Label lblNumTicket;
        private System.Windows.Forms.Button btnRevision;
        private System.Windows.Forms.Button btnLlamarCliente;
        private System.Windows.Forms.Button btnNoSePresento;
        private System.Windows.Forms.Button btnAtendido;
        private System.Windows.Forms.Timer trBindingGrid;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnoFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRevision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRevisionListo;
    }
}
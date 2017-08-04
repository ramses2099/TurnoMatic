namespace Com.Hit.TurnoMatic
{
    partial class FrmLlamarCliente
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
            this.rTxtLlamandoCliente = new System.Windows.Forms.RichTextBox();
            this.tmrLlamar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rTxtLlamandoCliente
            // 
            this.rTxtLlamandoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtLlamandoCliente.Location = new System.Drawing.Point(0, 0);
            this.rTxtLlamandoCliente.Name = "rTxtLlamandoCliente";
            this.rTxtLlamandoCliente.Size = new System.Drawing.Size(545, 140);
            this.rTxtLlamandoCliente.TabIndex = 0;
            this.rTxtLlamandoCliente.Text = "";
            // 
            // tmrLlamar
            // 
            this.tmrLlamar.Interval = 4000;
            this.tmrLlamar.Tick += new System.EventHandler(this.tmrLlamar_Tick);
            // 
            // FrmLlamarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 140);
            this.Controls.Add(this.rTxtLlamandoCliente);
            this.Name = "FrmLlamarCliente";
            this.Text = "Llamar Cliente";
            this.Load += new System.EventHandler(this.FrmLlamarCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtLlamandoCliente;
        private System.Windows.Forms.Timer tmrLlamar;
    }
}
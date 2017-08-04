namespace Com.Hit.TurnoMatic
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llamarclientetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.regresartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.pantallaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.registroToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cajeroToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ResetSecuenciatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaToolStripMenuItem,
            this.llamarclientetoolStripMenuItem,
            this.registroToolStripMenuItem,
            this.toolStripSeparator3,
            this.cajeroToolStripMenuItem,
            this.toolStripSeparator4,
            this.regresartoolStripMenuItem,
            this.supervisorToolStripMenuItem,
            this.ResetSecuenciatoolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // pantallaToolStripMenuItem
            // 
            this.pantallaToolStripMenuItem.Image = global::Com.Hit.TurnoMatic.Properties.Resources.table;
            this.pantallaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.pantallaToolStripMenuItem.Name = "pantallaToolStripMenuItem";
            this.pantallaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pantallaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pantallaToolStripMenuItem.Text = "&Patalla";
            this.pantallaToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // llamarclientetoolStripMenuItem
            // 
            this.llamarclientetoolStripMenuItem.Image = global::Com.Hit.TurnoMatic.Properties.Resources.dial;
            this.llamarclientetoolStripMenuItem.Name = "llamarclientetoolStripMenuItem";
            this.llamarclientetoolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.llamarclientetoolStripMenuItem.Text = "&Llamar Cliente";
            this.llamarclientetoolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Image = global::Com.Hit.TurnoMatic.Properties.Resources.list;
            this.registroToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.registroToolStripMenuItem.Text = "&Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // cajeroToolStripMenuItem
            // 
            this.cajeroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cajeroToolStripMenuItem.Image")));
            this.cajeroToolStripMenuItem.Name = "cajeroToolStripMenuItem";
            this.cajeroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cajeroToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cajeroToolStripMenuItem.Text = "&Cajero";
            this.cajeroToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(190, 6);
            // 
            // regresartoolStripMenuItem
            // 
            this.regresartoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("regresartoolStripMenuItem.Image")));
            this.regresartoolStripMenuItem.Name = "regresartoolStripMenuItem";
            this.regresartoolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.regresartoolStripMenuItem.Text = "&Regresar ticket cola";
            this.regresartoolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // supervisorToolStripMenuItem
            // 
            this.supervisorToolStripMenuItem.Image = global::Com.Hit.TurnoMatic.Properties.Resources.boss;
            this.supervisorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.supervisorToolStripMenuItem.Name = "supervisorToolStripMenuItem";
            this.supervisorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.supervisorToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.supervisorToolStripMenuItem.Text = "&Supervisor";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.Image = global::Com.Hit.TurnoMatic.Properties.Resources.pinion;
            this.administracionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.administracionToolStripMenuItem.Text = "&Administracion";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.toolBarToolStripMenuItem.Text = "&Toolbar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configuracionToolStripMenuItem.Text = "&Configuracion";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaToolStripButton,
            this.registroToolStripButton,
            this.toolStripSeparator1,
            this.cajeroToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 62);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // pantallaToolStripButton
            // 
            this.pantallaToolStripButton.Image = global::Com.Hit.TurnoMatic.Properties.Resources.table;
            this.pantallaToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pantallaToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.pantallaToolStripButton.Name = "pantallaToolStripButton";
            this.pantallaToolStripButton.Size = new System.Drawing.Size(53, 59);
            this.pantallaToolStripButton.Text = "Pantalla";
            this.pantallaToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pantallaToolStripButton.Click += new System.EventHandler(this.pantallaToolStripButton_Click);
            // 
            // registroToolStripButton
            // 
            this.registroToolStripButton.Image = global::Com.Hit.TurnoMatic.Properties.Resources.list;
            this.registroToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registroToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.registroToolStripButton.Name = "registroToolStripButton";
            this.registroToolStripButton.Size = new System.Drawing.Size(54, 59);
            this.registroToolStripButton.Text = "Registro";
            this.registroToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.registroToolStripButton.Click += new System.EventHandler(this.registroToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // cajeroToolStripButton
            // 
            this.cajeroToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cajeroToolStripButton.Image")));
            this.cajeroToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cajeroToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.cajeroToolStripButton.Name = "cajeroToolStripButton";
            this.cajeroToolStripButton.Size = new System.Drawing.Size(45, 59);
            this.cajeroToolStripButton.Text = "Cajero";
            this.cajeroToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cajeroToolStripButton.Click += new System.EventHandler(this.cajeroToolStripButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelUsuario,
            this.toolStripLabelRol});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripLabelUsuario
            // 
            this.toolStripLabelUsuario.Name = "toolStripLabelUsuario";
            this.toolStripLabelUsuario.Size = new System.Drawing.Size(50, 17);
            this.toolStripLabelUsuario.Text = "Usuario:";
            // 
            // toolStripLabelRol
            // 
            this.toolStripLabelRol.Name = "toolStripLabelRol";
            this.toolStripLabelRol.Size = new System.Drawing.Size(27, 17);
            this.toolStripLabelRol.Text = "Rol:";
            // 
            // ResetSecuenciatoolStripMenuItem
            // 
            this.ResetSecuenciatoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ResetSecuenciatoolStripMenuItem.Image")));
            this.ResetSecuenciatoolStripMenuItem.Name = "ResetSecuenciatoolStripMenuItem";
            this.ResetSecuenciatoolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ResetSecuenciatoolStripMenuItem.Text = "&Reset Secuencia";
            this.ResetSecuenciatoolStripMenuItem.Click += new System.EventHandler(this.ResetSecuenciatoolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Com.Hit.TurnoMatic.Properties.Resources.hit_logo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMenu";
            this.Text = "Turnos Hit V2.0 - Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelUsuario;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem pantallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton pantallaToolStripButton;
        private System.Windows.Forms.ToolStripButton registroToolStripButton;
        private System.Windows.Forms.ToolStripButton cajeroToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelRol;
        private System.Windows.Forms.ToolStripMenuItem llamarclientetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresartoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetSecuenciatoolStripMenuItem;
    }
}




﻿namespace Com.Hit.TurnoMatic
{
    partial class FrmPrintTicket
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsTicket = new Com.Hit.TurnoMatic.dsTicket();
            this.DtTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtTicketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsTicket";
            reportDataSource1.Value = this.DtTicketBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Com.Hit.TurnoMatic.rptTicket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(509, 387);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsTicket
            // 
            this.dsTicket.DataSetName = "dsTicket";
            this.dsTicket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DtTicketBindingSource
            // 
            this.DtTicketBindingSource.DataMember = "DtTicket";
            this.DtTicketBindingSource.DataSource = this.dsTicket;
            // 
            // FrmPrintTicket
            // 
            this.ClientSize = new System.Drawing.Size(509, 387);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrintTicket";
            this.Load += new System.EventHandler(this.FrmPrintTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtTicketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DtTicketBindingSource;
        private dsTicket dsTicket;

    }
}

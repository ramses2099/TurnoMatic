using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Com.Hit.TurnoMatic
{
    internal partial class FrmPrintTicket : Form
    {
        private DataTable table;
        private DataSet DtTicket;
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        
        public int NumTicket { get; set; }

        private DataSet GetDataSet()
        {

            table = new System.Data.DataTable("DtTicket");
            DataColumn column;
            DataRow row;

            // Create new DataColumn, set DataType, 
            // ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "NumTicket";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "Fecha";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            // Make the ID column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["NumTicket"];
            table.PrimaryKey = PrimaryKeyColumns;

            // Instantiate the DataSet variable.
            DtTicket = new DataSet();
            // Add the new DataTable to the DataSet.
            DtTicket.Tables.Add(table);

            // Create three new DataRow objects and add 
            // them to the DataTable

            row = table.NewRow();
            row["NumTicket"] = NumTicket;
            row["Fecha"] = DateTime.Now;
            table.Rows.Add(row);

            return DtTicket;

        }
        
        public FrmPrintTicket(int NumTicket)
        {
            InitializeComponent();
            this.NumTicket = NumTicket;
        }

        private void FrmPrintTicket_Load(object sender, EventArgs e)
        {
            this.Hide();

            DataSet ds = GetDataSet();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsTicket", ds.Tables[0]));
            this.reportViewer1.RefreshReport();

            LocalReport report = this.reportViewer1.LocalReport;     
            this.reportViewer1.RefreshReport();

            Export(report);
            Print();

            
        }
        //
        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        //
        // Export the given report as an EMF (Enhanced Metafile) file.
        private void Export(LocalReport report)
        {

            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0in</MarginLeft>
                <MarginRight>0in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";



            try
            {


                Warning[] warnings;
                m_streams = new List<Stream>();
                report.Render("Image", deviceInfo, CreateStream,
                   out warnings);
                foreach (Stream stream in m_streams)
                    stream.Position = 0;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            
        }
        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                //TODO: desconmentar para imprimir
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }

            this.Close();
        }


    }
}

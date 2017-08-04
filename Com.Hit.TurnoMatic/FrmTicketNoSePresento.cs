using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Hit.TurnoMatic.Services;
using Com.Hit.TurnoMatic.Model;

namespace Com.Hit.TurnoMatic
{
    public partial class FrmTicketNoSePresento : Form
    {
        private void BindingGrid()
        {
            using (TicketService _service = new TicketService())
            {
                this.gvListadodeColas.DataSource = _service.GetTicketNoSePresento();
            }
        }

        public FrmTicketNoSePresento()
        {
            InitializeComponent();
        }

        private void FrmTicketNoSePresento_Load(object sender, EventArgs e)
        {
            BindingGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingGrid();
        }

        private void btnRegresarCola_Click(object sender, EventArgs e)
        {

            DialogResult rs = MessageBox.Show("Esta seguro que desea regresar este ticke a la cola", "Turnos Hit V2.0 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rs == DialogResult.Yes)
            {
                Int32 selectedRowCount = gvListadodeColas.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    int value = 0;

                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        value = Convert.ToInt32(gvListadodeColas.SelectedRows[i].Cells[0].Value);
                    }

                    if (value > 0)
                    {
                        using (TicketService _service = new TicketService())
                        {
                            _service.RegresarTicketCola(value);
                        }

                        BindingGrid();
                    }

                }
                else
                {

                    MessageBox.Show("Debe seleccionar un ticket", "Turnos Hit V2.0 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                }

            }

        }
    }
}

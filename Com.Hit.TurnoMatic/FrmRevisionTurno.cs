using Com.Hit.TurnoMatic.Services;
using Com.Hit.TurnoMatic.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Hit.TurnoMatic
{
    public partial class FrmRevisionTurno : Form
    {
        public int IdCaja
        {
            get
            {
                using (CajaService service = new CajaService())
                {
                    int IdCaja = service.GetCajaByIdUsuario(Session.Intance.CurrentSession.IdUsuario).IdCaja;

                    return IdCaja;
                }

            }
        }

        public FrmRevisionTurno()
        {
            InitializeComponent();
        }

        private void addDigit(string digit)
        {
            this.txtNumTurno.Text = this.txtNumTurno.Text + digit;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            addDigit("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            addDigit("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            addDigit("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            addDigit("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            addDigit("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            addDigit("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            addDigit("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            addDigit("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            addDigit("9");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            addDigit("0");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtNumTurno.Text = "";
            this.txtNumTurno.Focus();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtNumTurno.Text))
            {
                MessageBox.Show("Debe digitar el numero de ticket", "Turnos Hit V2.0 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int NumTicket = Convert.ToInt32(this.txtNumTurno.Text);

            using (TicketService service = new TicketService())
            {
                int IdTicket = service.EnviaRevisionListo(IdCaja, NumTicket);

                if (IdTicket == -1)
                {
                    MessageBox.Show("El numero de ticket es Incorrecto", "Turnos Hit V2.0 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close();
            }
            
        }
    }
}

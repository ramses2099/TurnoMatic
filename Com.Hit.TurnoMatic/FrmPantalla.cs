using Com.Hit.TurnoMatic.Model;
using Com.Hit.TurnoMatic.Services;
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
    public partial class FrmPantalla : Form
    {
        private void ClearCajas()
        {
            this.lblNumCaja1.Text = "000";
            this.lblNumCaja2.Text = "000";
            this.lblNumCaja3.Text = "000";
            this.lblNumCaja4.Text = "000";
            this.lblNumCaja5.Text = "000";
            this.lblNumCaja6.Text = "000";
            this.lblNumCaja7.Text = "000";
            this.lblNumCaja8.Text = "000";
        }
        //
        private String FormatNumero(int numero)
        {

            String rs = "";

            if (numero < 10)
            {
                rs = string.Format("00{0}", numero);
            }
            else if (numero >= 10 && numero <= 99)
            {
                rs = string.Format("0{0}", numero);
            }
            else
            {
                rs = numero.ToString();
            }

            return rs;
        }
        //
        private void BindingPantalla()
        {
            List<TurnosPantalla> _list = null;

            using (CajaService service = new CajaService())
            {
                _list = service.GetTurnosPantalla();
            }

            ClearCajas();

            if (_list != null)
            {

                foreach (TurnosPantalla row in _list)
                {
                    switch (row.IdCaja)
                    {
                        case 1:
                            {
                                this.lblNumCaja1.Text = this.FormatNumero(row.NumTicket);
                                break;
                            }
                        case 2:
                            {
                                this.lblNumCaja2.Text = this.FormatNumero(row.NumTicket);
                                break;
                            }

                        case 3:
                            {
                                this.lblNumCaja3.Text = this.FormatNumero(row.NumTicket);
                                break;
                            }

                        case 4:
                            {
                                this.lblNumCaja4.Text = this.FormatNumero(row.NumTicket);
                                break;
                            }
                        case 5:
                            {
                                this.lblNumCaja5.Text = this.FormatNumero(row.NumTicket);
                                break;
                            }
                        case 6:
                            {
                                this.lblNumCaja6.Text = this.FormatNumero(row.NumTicket);
                                break;
                            }
                        case 7:
                            {
                                this.lblNumCaja7.Text = this.FormatNumero(row.NumTicket);
                                break;
                            }
                        case 8:
                            {
                                this.lblNumCaja8.Text = this.FormatNumero(row.NumTicket);
                                break;
                            }


                    }


                }
            }

        }

        public FrmPantalla()
        {
            InitializeComponent();
            //
            this.textBox1.Focus();

        }

        private void FrmPantalla_Load(object sender, EventArgs e)
        {
            this.BindingPantalla();
        }
        //
        private void trTurnos_Tick(object sender, EventArgs e)
        {
            this.BindingPantalla();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Hit.TurnoMatic.Model;
using Com.Hit.TurnoMatic.Services;

namespace Com.Hit.TurnoMatic
{
    partial class FrmDialog : Form
    {
        public const String TAG = "FrmDialog";

        public int NumTicket { get; set; }

        private IdTipoServicio _IdTipoServicio;

        public IdTipoServicio IdTipoServicio
        {
            get
            {
                return _IdTipoServicio;
            }
            set
            {
                _IdTipoServicio = value;
            }
        }

        public FrmDialog(IdTipoServicio IdTipoServicio)
        {

            InitializeComponent();
            //
            this.IdTipoServicio = IdTipoServicio;
            //

            this.splitContainer1.Focus();
            this.splitContainer1.ActiveControl = this.button1;

            try
            {
                using (TicketService _service = new TicketService())
                {
                    int tipoService = 0;
                    string codeTipoService = "";

                    switch (this.IdTipoServicio)
                    {
                        case IdTipoServicio.FP:
                            tipoService = 1;
                            codeTipoService = "FP-";
                            break;
                        case IdTipoServicio.RV:
                            tipoService = 2;
                            break;
                        case IdTipoServicio.RL:
                            tipoService = 3;
                            break;
                        case IdTipoServicio.AC:
                            tipoService = 4;
                            codeTipoService = "AC-";
                            break;
                        default:
                            break;
                    }

                    this.NumTicket = _service.AddTicket(tipoService);
                    //
                    this.lbTipoServicio.Text = codeTipoService;
                    this.lblNumTicket.Text = this.FormatNumero(this.NumTicket);
                }
            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "FrmDialog", ex);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrintTicket print = new FrmPrintTicket(this.NumTicket);
            print.Show();

            this.Close();
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

        private void FrmDialog_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Hit.TurnoMatic.Model;

namespace Com.Hit.TurnoMatic
{
    public partial class FrmRegisto : Form
    {
        public const String TAG = "FrmRegisto";

        public FrmRegisto()
        {
            InitializeComponent();
        }

        private void FrmRegisto_Load(object sender, EventArgs e)
        {

        }

        private void btnFactyPago_Click(object sender, EventArgs e)
        {
            Form childForm = new FrmDialog(IdTipoServicio.FP);
            childForm.ShowDialog();
        }

        private void btnFactCredito_Click(object sender, EventArgs e)
        {
            Form childForm = new FrmRevisionTurno();
            childForm.ShowDialog();
        }

        private void btnSelloyExpresso_Click(object sender, EventArgs e)
        {
            //Form childForm = new FrmDialog(IdTipoServicio.AC);
            //childForm.ShowDialog();
        }
        
    }
}

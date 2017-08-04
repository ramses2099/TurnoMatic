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
using Com.Hit.TurnoMatic.Services;


namespace Com.Hit.TurnoMatic
{
    public partial class FrmLoggin : Form
    {

        public const String TAG = "FrmLoggin";
        public const bool DEBUG = false;


        public FrmLoggin()
        {
            InitializeComponent();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Esta seguro que desea salir", "Turnos Hit V2.0 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            String Usuario = this.txtUsuario.Text;
            String Clave = this.txtPassword.Text;

            try
            {

                if (String.IsNullOrWhiteSpace(Usuario) || String.IsNullOrWhiteSpace(Clave))
                {
                    MessageBox.Show("El Usuario o Clave son requeridos", "Turnos Hit V2.0 ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearControl();
                }
                else
                {
                    
                    using (UsuarioService _service = new UsuarioService())
                    {

                        Usuario user = _service.ValidaUsuario(Usuario,Clave);

                        if (user.IdUsuario == 0)
                        {
                            MessageBox.Show("El Usuario o la Clave son incorrectos", "Turnos Hit V2.0 ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            clearControl();

                            return;
                        }

                        Com.Hit.TurnoMatic.Utils.Session.Intance.CurrentSession = user;
                        //
                        this.Hide();
                        FrmMenu form = new FrmMenu();
                        form.Show();

                    }

                }
            }
            catch (Exception ex)
            {
                Com.Hit.TurnoMatic.Utils.Log.LogError(TAG, "UsuarioMap", ex);

            }
            
        }

        private void clearControl() {

            this.txtUsuario.Text = "";
            this.txtPassword.Text = "";
            this.txtUsuario.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(this, new EventArgs());
            }
        }

        private void FrmLoggin_Load(object sender, EventArgs e)
        {
            if (DEBUG)
            {
                this.txtUsuario.Text = "jose.encarnacion";
                this.txtPassword.Text = "123";
            }
        }
    }
}

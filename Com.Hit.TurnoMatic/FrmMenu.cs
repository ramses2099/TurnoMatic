using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Hit.TurnoMatic.Utils;
using Com.Hit.TurnoMatic.Services;

namespace Com.Hit.TurnoMatic
{
    public partial class FrmMenu : Form
    {
        
        public void Security(int IdRol)
        {
            try
            {

                switch (IdRol)
                {
                    case 1:
                        {
                            pantallaToolStripMenuItem.Enabled = true;
                            registroToolStripMenuItem.Enabled = true;
                            cajeroToolStripMenuItem.Enabled = true;
                            supervisorToolStripMenuItem.Enabled = true;
                            administracionToolStripMenuItem.Enabled = true;
                            configuracionToolStripMenuItem.Enabled = true;
                            regresartoolStripMenuItem.Enabled = true;
                            llamarclientetoolStripMenuItem.Enabled = true;

                            pantallaToolStripButton.Enabled = true;
                            registroToolStripButton.Enabled = true;
                            cajeroToolStripButton.Enabled = true;
                            ResetSecuenciatoolStripMenuItem.Enabled = true;
                            break;
                        }

                    case 2:
                        {
                            pantallaToolStripMenuItem.Enabled = true;
                            registroToolStripMenuItem.Enabled = true;
                            cajeroToolStripMenuItem.Enabled = true;
                            supervisorToolStripMenuItem.Enabled = true;
                            administracionToolStripMenuItem.Enabled = false;
                            configuracionToolStripMenuItem.Enabled = false;
                            llamarclientetoolStripMenuItem.Enabled = true;

                            regresartoolStripMenuItem.Enabled = true;
                            pantallaToolStripButton.Enabled = true;
                            registroToolStripButton.Enabled = true;
                            cajeroToolStripButton.Enabled = true;
                            ResetSecuenciatoolStripMenuItem.Enabled = true;
                           
                            break;
                        }
                    case 3:
                        {
                            pantallaToolStripMenuItem.Enabled = false;
                            registroToolStripMenuItem.Enabled = false;
                            supervisorToolStripMenuItem.Enabled = false;
                            cajeroToolStripMenuItem.Enabled = true;
                            administracionToolStripMenuItem.Enabled = false;
                            configuracionToolStripMenuItem.Enabled = false;
                            regresartoolStripMenuItem.Enabled = false;

                            llamarclientetoolStripMenuItem.Enabled = false;
                            pantallaToolStripButton.Enabled = false;
                            registroToolStripButton.Enabled = false;
                            cajeroToolStripButton.Enabled = true;
                            ResetSecuenciatoolStripMenuItem.Enabled = false;
                            break;
                        }
                        
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        //
        public FrmMenu()
        {
            InitializeComponent();
        }
        //
        private void ShowNewForm(object sender, EventArgs e)
        {

            String formName = ((ToolStripMenuItem)sender).Text;

            switch (formName)
            {
                case "&Patalla":
                    {
                        Form childForm = new FrmPantalla();
                        childForm.Show();
                        break;
                    }
                case "&Registro":
                    {
                        Form childForm = new FrmRegisto();
                        childForm.Show();
                        break;
                    }
                case "&Regresar ticket cola":
                    {
                        Form childForm = new FrmTicketNoSePresento();
                        childForm.Show();
                        break;
                    }

                case "&Llamar Cliente":
                    {
                        Form childForm = new FrmLlamarCliente();
                        childForm.MdiParent = this;
                        childForm.Show();
                        break;
                    }
                case "&Cajero":
                    {
                        Form childForm = new FrmCajero();
                        childForm.MdiParent = this;
                        childForm.Show();
                        break;
                    }
                case "&About":
                    {
                        Form childForm = new FrmAboutBox();
                        childForm.ShowDialog();
                        break;
                    }
                //

                default:
                    break;
            }

            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            //childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Esta seguro que desea salir", "Turnos Hit V2.0 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

            if (Session.Intance.CurrentSession != null)
            {
                this.toolStripLabelUsuario.Text = String.Format("Bienvenido {0} {1}", Session.Intance.CurrentSession.Nombres, Session.Intance.CurrentSession.Apellidos);

                using (RolService _service = new RolService())
                {

                    this.toolStripLabelRol.Text = String.Format("Rol {0}", _service.GetRol(Session.Intance.CurrentSession.IdRol).Descripcion);
                    Security(Session.Intance.CurrentSession.IdRol);

                }

            }

        }

        private void pantallaToolStripButton_Click(object sender, EventArgs e)
        {
            Form childForm = new FrmPantalla();
            childForm.Show();
        }

        private void registroToolStripButton_Click(object sender, EventArgs e)
        {
            Form childForm = new FrmRegisto();
            childForm.Show();
        }

        private void cajeroToolStripButton_Click(object sender, EventArgs e)
        {
            Form childForm = new FrmCajero();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Esta seguro que desea salir", "Turnos Hit V2.0 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ResetSecuenciatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Esta seguro que desea Reiniciar la secuencia de la fila", "Turnos Hit V2.0 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rs == DialogResult.Yes)
            {
                using (TicketService service = new TicketService())
                {
                    service.ResetSecuencia();
                }
            }
        }


    }
}

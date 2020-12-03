using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
            AsignarValoresATXT();
        }
        public static string ID;

        public static string NOMBRE;
        public static string APELLIDO;
        public static string FECHANACIMIENTO;
        public static string USUARIO;
        public static string CONTRA;
        public static string ROL;
        public static bool Editarse = false;
        E_usuarios objEntidad = new E_usuarios();
        N_usuarios objNegocios = new N_usuarios();

        // metodo para cambiar la funcion de guardar a editar
        // estas variables se llenan con el metodo de btnEditar de frmModificar
        public void AsignarValoresATXT()
        {
            if(Editarse == true)
            {
                txtNombre.Text = NOMBRE;
                txtApellido.Text = APELLIDO;
                txtUsuario.Text = USUARIO;
                txtContra.Text = CONTRA;
                txtContra2.Text = CONTRA;
                comboBox1.Text = ROL;
                dateTimePicker1.Value = Convert.ToDateTime(FECHANACIMIENTO);
                
            }
            if(Editarse == false)
            {
                txtNombre.Text = null;
                txtApellido.Text = null;
                txtUsuario.Text = null;
                txtContra.Text = null;
                txtContra2.Text = null;
                comboBox1.Text = null;
                

            }
        }
        // FIN METODO PARA CAMBIAR LA FUNCION
        // INICIO BOX SHADOW EFFECT
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        // FIN BOX SHADOW EFFECT
        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(Editarse == false) 
            {
                if (txtContra.Text == txtContra2.Text)
                {
                    try
                    {
                        objEntidad.NOMBRE = txtNombre.Text;
                        objEntidad.APELLIDO = txtApellido.Text;
                        objEntidad.USUARIO = txtUsuario.Text;
                        objEntidad.CONTRA = txtContra.Text;
                        objEntidad.FECHANACIMIENTO = dateTimePicker1.Value;
                        objEntidad.ROL = comboBox1.Text;

                        objNegocios.insertandoUsuario(objEntidad);

                        frmSuccess.confirmacionForm("Se ha guardado el registro con exito");
                    }
                    catch (Exception ez)
                    {
                        frmError.denegationForm("No se ha podido guardar el registro" + ez);

                    }
                }
                else if (txtContra.Text != txtContra2.Text)
                {
                    frmError.denegationForm("Las contraseñas no son iguales");
                }
                else
                {
                    frmError.denegationForm("Debe completar todos los campos");
                }
            }
           if (Editarse == true)
            {
                try
                {
                    if (txtContra.Text == txtContra2.Text)
                    {
                        try
                        {
                            objEntidad.ID = Convert.ToInt32(ID);
                            objEntidad.NOMBRE = txtNombre.Text;
                            objEntidad.APELLIDO = txtApellido.Text;
                            objEntidad.USUARIO = txtUsuario.Text;
                            objEntidad.CONTRA = txtContra.Text;
                            objEntidad.FECHANACIMIENTO = dateTimePicker1.Value;
                            objEntidad.ROL = comboBox1.Text;

                            objNegocios.EditandoUsuario(objEntidad);

                            frmSuccess.confirmacionForm("Se ha editado el registro con exito");
                            Editarse = false;
                            AsignarValoresATXT();

                            this.Close();
                            frmModificar frm = new frmModificar();
                            frm.Show();
                        }
                        catch (Exception ez)
                        {
                            frmError.denegationForm("No se ha podido editar el registro" + ez);

                        }
                    }
                    else if (txtContra.Text != txtContra2.Text)
                    {
                        frmError.denegationForm("Las contraseñas no son iguales");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }
           
        }

        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

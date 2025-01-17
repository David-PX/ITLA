﻿using System;
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
    public partial class frmLogin : Form
    {
        E_usuarios objEntidad = new E_usuarios();
        N_usuarios objNegocios = new N_usuarios();
        public frmLogin()
        {
            InitializeComponent();
            
            
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           DataTable obj = objNegocios.Ingresar(txtUsuario.text, txtContra.Text);
            
            try
            {
                if (obj.Rows.Count > 0)
                {


                    frmSuccess.confirmacionForm("Inicio de sesion correcto.");

                    if (frmSuccess.ParaIngresar == true) {
                        
                        if (obj.Rows[0][6].ToString() == "Admin")
                        {
                            frmMenuAdmin form = new frmMenuAdmin();
                            form.Show();
                            this.Hide();
                        }
                        if(obj.Rows[0][6].ToString() == "User")
                        {
                            frmMenuNormal frm = new frmMenuNormal();
                            frm.Show();
                            this.Hide();
                        }
                   
                    }
                }
                else
                {
                    frmError.denegationForm("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
                
                
            
            
        }

        private void txtContra_OnTextChange(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

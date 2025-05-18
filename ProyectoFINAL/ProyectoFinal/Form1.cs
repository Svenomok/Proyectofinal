namespace ProyectoFinal
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            return;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
        }


        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelMenu.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFrm<frmUsuarios>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFrm<frmEmpleados>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFrm<frmPagoE>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirFrm<frmCitas>();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            abrirFrm<frmPagoCitas>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirFrm<frmTratamientos>();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            abrirFrm<frmPacientes>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            abrirFrm<frmMedicamentos>();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            abrirFrm<frmHabitaciones>();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            abrirFrm<frmGestionH>();


        }

        private void abrirFrm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelMenu.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelMenu.Controls.Add(formulario);
                panelMenu.Tag = formulario;
                formulario.Show();

            }
            else
            {
                formulario.BringToFront();


            }
        }
    }
}

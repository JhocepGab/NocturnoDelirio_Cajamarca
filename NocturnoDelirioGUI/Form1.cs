using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        Arbol arbol = new Arbol();
        ListaCitas lista = new ListaCitas();
        PilaAcciones pila = new PilaAcciones();
        ColaEspera cola = new ColaEspera();
        Persona usuarioActual = null;

        public Form1()
        {
            InitializeComponent();
            cmbPlan.SelectedIndex = 0;
            rb30.Checked = true;
            ActualizarPrecio();
        }

        private void ActualizarPrecio()
        {
            lblPrecio.Text = "Precio: S/. " + (rb30.Checked ? "30" : "60");
        }

        private Persona ConstruirPersona()
        {
            int dni;
            if (!int.TryParse(txtDNI.Text, out dni))
            {
                MessageBox.Show("DNI inválido");
                return null;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Complete los datos");
                return null;
            }

            string plan = "Gratis";
            if (cmbPlan.SelectedIndex == 1) plan = "Premium";
            else if (cmbPlan.SelectedIndex == 2) plan = "VIP";

            if (plan != "Gratis" && string.IsNullOrWhiteSpace(txtTarjeta.Text))
            {
                MessageBox.Show("Ingrese tarjeta para plan de pago");
                return null;
            }

            Persona p = new Persona();
            p.dni = dni;
            p.nombre = txtNombre.Text;
            p.email = txtEmail.Text;
            p.password = txtPassword.Text;
            p.tarjeta = txtTarjeta.Text;
            p.plan = plan;

            return p;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Persona p = ConstruirPersona();
            if (p == null) return;

            arbol.Insertar(p);
            arbol.Listar(ref lbUsuarios);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int dni;
            if (!int.TryParse(txtDNI.Text, out dni))
            {
                MessageBox.Show("Ingrese DNI");
                return;
            }

            Persona p = arbol.Buscar(dni);
            if (p == null) return;

            if (p.password != txtPassword.Text)
            {
                MessageBox.Show("Clave incorrecta");
                return;
            }

            usuarioActual = p;
            MessageBox.Show("Bienvenido " + p.nombre);
        }

        private DateTime ObtenerFechaHora()
        {
            DateTime fecha = dtpFecha.Value.Date;
            TimeSpan h;
            if (!TimeSpan.TryParse(txtHora.Text, out h))
            {
                throw new Exception("Hora inválida");
            }
            return fecha.Add(h);
        }

        private void RbDuracion_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAnfitriona.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione anfitriona");
                    return;
                }

                DateTime fh = ObtenerFechaHora();
                bool ocupado = lista.ExisteConflicto(cmbAnfitriona.Text, fh);
                MessageBox.Show(ocupado ? "Ocupado" : "Libre");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("Inicie sesión");
                return;
            }
            if (cmbAnfitriona.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione anfitriona");
                return;
            }

            try
            {
                DateTime fh = ObtenerFechaHora();
                int dur = rb30.Checked ? 30 : 60;
                decimal precio = rb30.Checked ? 30 : 60;

                if (lista.ExisteConflicto(cmbAnfitriona.Text, fh))
                {
                    Cita ccola = new Cita();
                    ccola.dniCliente = usuarioActual.dni;
                    ccola.nombreCliente = usuarioActual.nombre;
                    ccola.anfitriona = cmbAnfitriona.Text;
                    ccola.fechaHoraInicio = fh;
                    ccola.duracionMin = dur;
                    ccola.precio = precio;

                    cola.Encolar(ccola);
                    MessageBox.Show("Horario en cola de espera");
                    return;
                }

                Cita c = new Cita();
                c.dniCliente = usuarioActual.dni;
                c.nombreCliente = usuarioActual.nombre;
                c.anfitriona = cmbAnfitriona.Text;
                c.fechaHoraInicio = fh;
                c.duracionMin = dur;
                c.precio = precio;

                lista.InsertarOrdenado(c);
                lista.LlenarListBox(lbCitas);
                pila.Push("RESERVA", c);
                MessageBox.Show("Cita reservada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (pila.EstaVacia())
            {
                MessageBox.Show("Nada para deshacer");
                return;
            }

            string acc;
            Cita c;
            if (pila.Pop(out acc, out c) && acc == "RESERVA")
            {
                lista.Eliminar(c);
                lista.LlenarListBox(lbCitas);
            }
        }

        private void lbCitas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

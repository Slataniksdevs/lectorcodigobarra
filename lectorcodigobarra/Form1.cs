using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace lectorcodigobarra
{
    public partial class mainform : Form
    {
        SerialPort serialPort;

        public mainform()
        {
            InitializeComponent();
            CargarPuertosCOM();
        }

        private void CargarPuertosCOM()
        {
            string[] puertos = SerialPort.GetPortNames();
            comboBoxPuertos.Items.AddRange(puertos);
            if (puertos.Length > 0)
                comboBoxPuertos.SelectedIndex = 0;
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                serialPort = new SerialPort(comboBoxPuertos.SelectedItem.ToString(), 9600);
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DatosRecibidos);
                try
                {
                    serialPort.Open();
                    textBoxEstado.Text = "Conectado a " + serialPort.PortName;
                    MessageBox.Show("Puerto abierto y conectado");
                }
                catch (Exception ex)
                {
                    textBoxEstado.Text = "Error al conectar: " + ex.Message;
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }

        private void DatosRecibidos(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    string datos = serialPort.ReadExisting();

                    // Mostrar los datos completos en textBoxDatos
                    this.Invoke(new Action(() =>
                    {
                        textBoxDatos.AppendText(datos + Environment.NewLine);
                    }));

                    if (datos.Length >= 25)
                    {
                        // Extraer Fecha (posiciones 6-11: aammdd)
                        string fecha = datos.Substring(6, 6);
                        string fechaFormateada = $"{fecha.Substring(4, 2)}/{fecha.Substring(2, 2)}/20{fecha.Substring(0, 2)}";

                        // Extraer Hora (posiciones 12-17: HHmmss)
                        string hora = datos.Substring(12, 6);
                        string horaFormateada = $"{hora.Substring(0, 2)}:{hora.Substring(2, 2)}:{hora.Substring(4, 2)}";

                        // Extraer Número de Ticket (últimos 6 dígitos)
                        string ticket = datos.Substring(datos.Length - 6);

                        // Mostrar los datos extraídos en los TextBox correspondientes
                        this.Invoke(new Action(() =>
                        {
                            textBoxRun.Text = fechaFormateada;     // Muestra la Fecha
                            textBoxSerial.Text = horaFormateada;   // Muestra la Hora
                            textBoxTicket.Text = ticket;           // Muestra el Número de Ticket
                        }));
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            textBoxEstado.Text = "Datos incompletos.";
                        }));
                    }
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        textBoxEstado.Text = "El puerto serial no está abierto.";
                    }));
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    textBoxEstado.Text = "Error al recibir datos: " + ex.Message;
                }));
                MessageBox.Show("Error al recibir datos: " + ex.Message);
            }
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                textBoxEstado.Text = "Desconectado";
                MessageBox.Show("Puerto desconectado.");
            }
            else
            {
                textBoxEstado.Text = "El puerto ya está cerrado.";
                MessageBox.Show("El puerto ya está cerrado.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPuertosCOM();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}

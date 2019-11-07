/*
 * AUTOR: JOSE ARMANDO SAENZ ESQUEDA
 * FECHA: 07/11/2019
 * DESCRIPCION: PROGRAMA PARA UNA POSICION DESEADA AL ROBOT BRACCIO 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports; //DIRECTIVA AGREGADA PARA MANEJAR LA CLASE SERIALPORT

namespace POSTURA
{
    public partial class Form1 : Form
    {
        //DEFINICIÓN DE VARIABLES PUBLICAS
        List<byte> comando = new List<byte>();

        //CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
        }

        //EVENTO LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            //CARGA LOS PUERTOS COM DETECTADOS
            foreach (string arg in SerialPort.GetPortNames())
            {
                cbPorts.Items.Add(arg);
            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            //VERIFICA SI EL PUERTO SERIAL ESTA ABIERTO
            if (serialPort1.IsOpen)
            {
                //EN CASO DE ESTAR ABIERTO EL PUERTO SERIAL LO CIERRA
                serialPort1.Close();
                //EL BOTON INDICA QUE LA CONEXIÓN NO ESTA ABIERTA
                btnOnOff.Checked = false;
            }
            else
            {
                //EN CASO DE ESTAR CERRADO EL PUERTO LO VA A INTENTAR ABRIR
                //VERIFICA QUE SE LOS COMBO BOX DE LOS PUERTOS Y DEL BAUD RATE NO TENGAN VALORES VACIOS
                if (String.IsNullOrEmpty(cbPorts.Text) || String.IsNullOrWhiteSpace(cbPorts.Text) || string.IsNullOrEmpty(cbBaudios.Text) || string.IsNullOrWhiteSpace(cbBaudios.Text))
                {
                    //EN CASO DE QUE TENGAN VALORES VACIOS  MARCA UN ERROR
                    MessageBox.Show("NO HAY PUERTO O BAUDRATE SELECCIONADO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    //EL BOTON INDICA QUE LA CONEXIÓN NO ESTA ABIERTA
                    btnOnOff.Checked = false;
                    //FINALIZA LA RUTINA
                    return;
                }
                else
                {
                    //CARGA EL NOMBRE DEL PUERTO
                    serialPort1.PortName = cbPorts.Text;
                    //CARGA LA VELOCIDAD DEL PUERTO
                    serialPort1.BaudRate = int.Parse(cbBaudios.Text);
                    //SETENCIA PARA DETECTAR ERRORES
                    try
                    {
                        //INTENTA ABRIR EL PUERTO
                        serialPort1.Open();
                        //EL BOTON INDICA QUE LA CONEXIÓN ESTA ABIERTA
                        btnOnOff.Checked = true;
                    }
                    catch (Exception err)
                    {
                        //EN CASO DE ERROR SE MANDA UN MESSAGE BOX CON EL ERROR
                        MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //EL BOTON INDICA QUE LA CONEXIÓN ESTA ABIERTA
                        btnOnOff.Checked = false;
                    }
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //VARIABLE TEMPORALES
            int motor1, motor2, motor3, motor4, motor5;
            //BORRA EL COMANDO ANTERIOR
            comando.Clear();
            //VERIFICA QUE EL VALOR DEL MOTOR 1 SEA VALIDO
            if (!int.TryParse(txtMotor1.Text, out motor1) || motor1 < 0 || motor1 > 255)
            {
                //MENSAJE EN CASO DE QUE SEA UN VALOR NO VALIDO
                MessageBox.Show("EL VALOR DEL MOTOR 1 NO ES VALIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //SELECCIONA EL TEXTBOX
                txtMotor1.Focus();
                //SELECCIONA EL TEXTO
                txtMotor1.SelectAll();
                //FINALIZA LA RUTINA
                return;
            }
            else
            {
                //SELECCION DE MOTOR
                comando.Add((byte)'A');
                //ANGULO DEL MOTOR
                comando.Add((byte)motor1);
            }

            if (!int.TryParse(txtMotor2.Text, out motor2) || motor2 < 1 || motor2 > 254)
            {
                //MENSAJE EN CASO DE QUE SEA UN VALOR NO VALIDO
                MessageBox.Show("EL VALOR DEL MOTOR 2 NO ES VALIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //SELECCIONA EL TEXTBOX
                txtMotor2.Focus();
                //SELECCIONA EL TEXTO
                txtMotor2.SelectAll();
                //FINALIZA LA RUTINA
                return;
            }
            else
            {
                //SELECCION DE MOTOR
                comando.Add((byte)'B');
                //ANGULO DEL MOTOR
                comando.Add((byte)motor2);
            }

            if (!int.TryParse(txtMotor3.Text, out motor3) || motor3 < 1 || motor3 > 254)
            {
                //MENSAJE EN CASO DE QUE SEA UN VALOR NO VALIDO
                MessageBox.Show("EL VALOR DEL MOTOR 3 NO ES VALIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //SELECCIONA EL TEXTBOX
                txtMotor3.Focus();
                //SELECCIONA EL TEXTO
                txtMotor3.SelectAll();
                //FINALIZA LA RUTINA
                return;
            }
            else
            {
                //SELECCION DE MOTOR
                comando.Add((byte)'C');
                //ANGULO DEL MOTOR
                comando.Add((byte)motor3);
            }

            if (!int.TryParse(txtMotor4.Text, out motor4) || motor4 < 1 || motor4 > 254)
            {
                //MENSAJE EN CASO DE QUE SEA UN VALOR NO VALIDO
                MessageBox.Show("EL VALOR DEL MOTOR 4 NO ES VALIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //SELECCIONA EL TEXTBOX
                txtMotor4.Focus();
                //SELECCIONA EL TEXTO
                txtMotor4.SelectAll();
                //FINALIZA LA RUTINA
                return;
            }
            else
            {
                //SELECCION DE MOTOR
                comando.Add((byte)'D');
                //ANGULO DEL MOTOR
                comando.Add((byte)motor4);
            }

            if (!int.TryParse(txtMotor5.Text, out motor5) || motor5 < 1 || motor5 > 254)
            {
                //MENSAJE EN CASO DE QUE SEA UN VALOR NO VALIDO
                MessageBox.Show("EL VALOR DEL MOTOR 5 NO ES VALIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //SELECCIONA EL TEXTBOX
                txtMotor5.Focus();
                //SELECCIONA EL TEXTO
                txtMotor5.SelectAll();
                //FINALIZA LA RUTINA
                return;
            }
            else
            {
                //SELECCION DE MOTOR
                comando.Add((byte)'D');
                //ANGULO DEL MOTOR
                comando.Add((byte)motor5);
            }
            //MUESTRA EL COMANDO EN LA ETIQUETA
            lComando.Text = String.Join(",", comando);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //VERFICA SI EL PUERTO ESTA ABIERTO
            if (!serialPort1.IsOpen)
            {
                //MENSAJE EN CASO DE NO ESTAR ABIERTO EL PUERTO
                MessageBox.Show("EL PUERTO NO ESTA ABIERTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //FINALIZA LA RUTINA
                return;
            }
            else
            {
                //MANDA EL COMANDO
                serialPort1.Write(comando.ToArray(), 0,comando.Count);
            }
        }
    }
}

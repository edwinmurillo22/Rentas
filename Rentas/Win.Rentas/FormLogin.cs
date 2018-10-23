using BL.Rentas;
using System;

using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormLogin : Form
    { 
        SeguridadBL _seguridad;
    
        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo! Le saluda Edwin Murillo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            var resultado = _seguridad.Autorizar(usuario, contrasena);

                if (resultado == true)
            {
                MessageBox.Show("Constrasena ingresada corectamente");
                this.Close();

                }
                    else
                    {
                        MessageBox.Show("Constrasena incorrecta");
                    }

            }
        }
    }


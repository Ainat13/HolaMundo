using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

//Asignamos el nombre al espacio de trabajo
namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Evento click del botón "Validar"
        private void Validar_Click(object sender, EventArgs e)
        {
            // Declaramos las variables "contraseña", "confirmar" y "patron" como tipo string 
            string contraseña = Contraseña.Text; //Se obtiene el texto escrito en el campo "Contraseña"
            string confirmar = ConfirmarContraseña.Text; //Se obtiene el texto escrito en el campo "ConfirmarContraseña"

            //Expresión regular que exige una letra mayúscula, una minúscula, un número y un símbolo
            string patron = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^a-zA-Z0-9]).+$";

            //Condicional que verifica si la contraseña cumple con los requisitos (los de la expresión regular)
            if (!Regex.IsMatch(contraseña, patron))
            {
                MessageBox.Show("La contraseña no cumple con los requisitos."); //Mensaje que se muestra en caso de que no cumpla
                return;
            }

            //Condicional que verifica si la confirmación coincide con la contraseña escrita al inicio
            if (contraseña != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden."); //Mensaje que se muestra en caso de que no coincida
                return;
            }
            MessageBox.Show("La contraseña ha sido validada"); //Mensaje que se muestra en caso de que cumpla todo lo requerido
        }
    }
}

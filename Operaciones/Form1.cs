using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;    
using Operaciones.Modelo;

namespace Operaciones
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green500,
                Primary.Green900,
                Primary.Green500,
                Accent.LightBlue200,
                TextShade.WHITE
            );

            //Para dejar fijo el tamaño del formulario
            this.MaximizeBox = false;
            //Define el tamaño mínimo del formulario
            this.Size = new Size(800, 788);
            //Bloquear los limites para impider queel arrastre los bordes
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            // opcional  deshabilitar el boton de tamaño de windows
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Operciones";

            materialTextBox21.Text = string.Empty;
            materialTextBox22.Text = string.Empty;
            listBox1.Text = string.Empty;

            // edicion de grupbox
            groupBox1.Text = "Numero";
            groupBox1.Font = new Font("Arial", 12, FontStyle.Bold);
            groupBox1.ForeColor = Color.Green;

            groupBox2.Text = "Rango";
            groupBox2.Font = new Font("Arial", 12, FontStyle.Bold);
            groupBox2.ForeColor = Color.Green;

            groupBox3.Text = "Tipo";
            groupBox3.Font = new Font("Arial", 12, FontStyle.Bold);
            groupBox3.ForeColor = Color.Green;

            groupBox4.Text = "Sellecionar";
            groupBox4.Font = new Font("Arial", 12, FontStyle.Bold);
            groupBox4.ForeColor = Color.Green;

            groupBox5.Text = "Operaciones";
            groupBox5.Font = new Font("Arial", 12, FontStyle.Bold);
            groupBox5.ForeColor = Color.Green;

            groupBox6.Text = "Resultado";
            groupBox6.Font = new Font("Arial", 12, FontStyle.Bold);
            groupBox6.ForeColor = Color.Green;

            // quietar contenido de radiobutton & checkbox
            materialRadioButton1.Text = "";
            materialRadioButton2.Text = "";
            materialCheckbox1.Text = "";
            materialCheckbox2.Text = "";    
            materialCheckbox3.Text = "";

            //Colocar el texto del label1 y cambiar su fuente, color y fondo
            label1.Text = "Inicio";
            label1.Font = new Font("Roboto", 12, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(18, 207, 14);

            label2.Text = "Fin";
            label2.Font = new Font("Roboto", 12, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(18, 207, 14);

            label3.Text = "Par";
            label3.Font = new Font("Roboto", 12, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(18, 207, 14);

            label4.Text = "Impar";
            label4.Font = new Font("Roboto", 12, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(18, 207, 14);

            label5.Text = "+\n"+ "-\n"+ "x\n";
            label5.Font = new Font("Roboto", 12, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(18, 207, 14);

            label6.Text = "Resta";
            label6.Font = new Font("Roboto", 12, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(18, 207, 14);

            label7.Text = "Suma";
            label7.Font = new Font("Roboto", 12, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(18, 207, 14);

            label8.Text = "Multiplicar";
            label8.Font = new Font("Roboto", 12, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(18, 207, 14);

            //Modificacdor de botones
            materialButton1.Text = "Aceptar";
            materialButton2.Text = "Realizar Operaciones";
            materialButton3.Text = "Limpiar";

           

        }

        operaciones operacion = new operaciones();

        private void materialButton1_Click(object sender, EventArgs e)
        {

            try
            {
                int inicio = int.Parse(materialTextBox21.Text);
                int fin = int.Parse(materialTextBox22.Text);

                // Validación: Inicio debe ser menor que Fin
                if (inicio >= fin)
                {
                    MessageBox.Show("El valor de Inicio debe ser menor que el valor de Fin.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Seleccionar Tipo
                if (!materialRadioButton1.Checked && !materialRadioButton2.Checked)
                {
                    MessageBox.Show("Debe seleccionar un Tipo (Par o Impar).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool esPar = materialRadioButton1.Checked;

                // Generar los números desde el modelo
                List<int> numeros = operacion.GenerarRango(inicio, fin, esPar);

                // Llenar los ComboBox
                materialComboBox1.DataSource = new List<int>(numeros);
                materialComboBox2.DataSource = new List<int>(numeros);
            } catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en el rango.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (materialComboBox1.SelectedItem == null || materialComboBox2.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar dos números de las listas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int n1 = (int)materialComboBox1.SelectedItem;
            int n2 = (int)materialComboBox2.SelectedItem;

            listBox1.Items.Clear();

            // Realizar operaciones seleccionadas y mostrarlas con el formato solicitado
            if (materialComboBox1.SelectedItem == null || materialComboBox2.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar dos números de las listas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

             n1 = (int)materialComboBox1.SelectedItem;
             n2 = (int)materialComboBox2.SelectedItem;

            listBox1.Items.Clear();

            // Realizar operaciones seleccionadas y mostrarlas con el formato solicitado
            if (materialCheckbox1.Checked)
            {
                int res = operacion.Sumar(n1, n2);
                listBox1.Items.Add($"La suma de {n1} + {n2} = {res}");
            }
            if (materialCheckbox2.Checked)
            {
                int res = operacion.Restar(n1, n2);
                listBox1.Items.Add($"La resta de {n1} - {n2} = {res}");
            }
            if (materialCheckbox3.Checked)
            {
                int res = operacion.Multiplicar(n1, n2);
                listBox1.Items.Add($"La multiplicación de {n1} x {n2} = {res}");
            }


            if (!materialCheckbox1.Checked && !materialCheckbox2.Checked && !materialCheckbox3.Checked)
            {
                MessageBox.Show("Debe seleccionar al menos una operación.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            // Quitar selecciones y limpiar controles
            materialTextBox21.Clear();
            materialTextBox22.Clear();
            materialRadioButton1.Checked = false;
            materialRadioButton2.Checked = false;

            materialComboBox1.DataSource = null;
            materialComboBox2.DataSource = null;

            materialCheckbox1.Checked = false;
            materialCheckbox2.Checked = false;
            materialCheckbox3.Checked = false;

            listBox1.Items.Clear();
        }
    }
}

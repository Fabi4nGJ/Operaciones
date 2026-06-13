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
            materialTextBox23.Text = string.Empty;

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

            //Llenadod de contenedores combobox
            materialComboBox1.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9"});
            materialComboBox1.SelectedIndex = 0; //posicionrme en un elemento del comboBox


        }
    }
}

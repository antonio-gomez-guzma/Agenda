using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        private Repository repository = new Repository();
        public Form1()
        {
            InitializeComponent();
            List<Contacto> contactos = repository.GetAllContacts();
            dataGridView_Contactos.DataSource = contactos;
            Reset();
        }
        private string TextId;
        private string Nombre;
        private string FechaNacimiento;
        private string Telefono;
        private string Observaciones;

        private enum state
        {
            ESPERA,
            ANIADIR,
            ELIMINAR,
            MODIFICAR
        }

        state ESTADO = state.ESPERA;

        private void groupBoxContactos(object sender, EventArgs e)
        {

        }

        private void labelID(object sender, EventArgs e)
        {

        }

        private void textBoxID(object sender, EventArgs e)
        {
            this.TextId = ((TextBox)sender).Text;
        }

        private void labelNombre(object sender, EventArgs e)
        {

        }

        private void textBoxNombre(object sender, EventArgs e)
        {
            this.Nombre = ((TextBox)sender).Text;
        }

        private void labelFechaNacimiento(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFechaNacimiento(object sender, EventArgs e)
        {

            DateTime fecha =  ((DateTimePicker)sender).Value;
            FechaNacimiento = fecha.ToString("yyyy-MM-dd");
        }

        private void labelTelefono(object sender, EventArgs e)
        {

        }

        private void textBoxTelefono(object sender, EventArgs e)
        {
            this.Telefono = ((TextBox)sender).Text;
        }

        private void labelObservaciones(object sender, EventArgs e)
        {

        }

        private void richTextBoxObservaciones(object sender, EventArgs e)
        {
            this.Observaciones = ((RichTextBox)sender).Text;
        }

        private void buttonAniadir(object sender, EventArgs e)
        {
            ESTADO = state.ANIADIR;
            Reset();
            button_Eliminar.Visible = false;
            button_Modificar.Visible = false;
            textBox_Nombre.Enabled = true;
            dateTimePicker_FechaNacimiento.Enabled = true;
            textBox_Telefono.Enabled = true;
            richTextBox_Observaciones.Enabled = true;
            
            
        }

        private void buttonEliminar(object sender, EventArgs e)
        {
            if (textBox_ID.Text != string.Empty)
            {
                ESTADO = state.ELIMINAR;
                button_Aniadir.Visible = false;
                button_Modificar.Visible = false;
                textBox_ID.BackColor = Color.DarkRed;
                                
            }

        }

        private void buttonModificar(object sender, EventArgs e)
        {
            if (textBox_ID.Text != string.Empty)
            { 
                ESTADO = state.MODIFICAR;
                button_Aniadir.Visible = false;
                button_Eliminar.Visible = false;
                textBox_Nombre.Enabled = true;
                dateTimePicker_FechaNacimiento.Enabled = true;
                textBox_Telefono.Enabled = true;
                richTextBox_Observaciones.Enabled = true;
                textBox_ID.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void buttonCancelar(object sender, EventArgs e)
        {
            if (ESTADO == state.ANIADIR)
            {
                button_Eliminar.Visible = true;
                button_Modificar.Visible = true;
                textBox_Nombre.Enabled = false;
                dateTimePicker_FechaNacimiento.Enabled = false;
                textBox_Telefono.Enabled = false;
                richTextBox_Observaciones.Enabled = false;
                Reset();
            }
            else if (ESTADO == state.ELIMINAR)
            {
                button_Aniadir.Visible = true;
                button_Modificar.Visible = true;
                Reset();

            }
            else if (ESTADO == state.MODIFICAR)
            {
                button_Eliminar.Visible = true;
                button_Aniadir.Visible = true;
                textBox_Nombre.Enabled = false;
                dateTimePicker_FechaNacimiento.Enabled = false;
                textBox_Telefono.Enabled = false;
                richTextBox_Observaciones.Enabled = false;
                Reset();
            }
            else
            {
                Reset();
            }
            ESTADO = state.ESPERA;
        }

        private void buttonGuardar(object sender, EventArgs e)
        {
            if(ESTADO == state.ANIADIR)
            {
                repository.AniadirContacto(1, Nombre, FechaNacimiento, Telefono, Observaciones);
                List<Contacto> contactos = repository.GetAllContacts();
                dataGridView_Contactos.DataSource = contactos;
                button_Eliminar.Visible = true;
                button_Modificar.Visible = true;
                textBox_Nombre.Enabled = false;
                dateTimePicker_FechaNacimiento.Enabled = false;
                textBox_Telefono.Enabled = false;
                richTextBox_Observaciones.Enabled = false;
                Reset();
            }
            else if (ESTADO == state.ELIMINAR)
            {
                repository.ErraseContactById(Int32.Parse(textBox_ID.Text));
                List<Contacto> contactos = repository.GetAllContacts();
                dataGridView_Contactos.DataSource = contactos;
                button_Aniadir.Visible = true;
                button_Modificar.Visible = true;
                
                Reset();

            }
            else if (ESTADO == state.MODIFICAR)
            {
                repository.AlterContactById(Int32.Parse(textBox_ID.Text),
                                            textBox_Nombre.Text,
                                            dateTimePicker_FechaNacimiento.Text,
                                            textBox_Telefono.Text,
                                            richTextBox_Observaciones.Text);
                List<Contacto> contactos = repository.GetAllContacts();
                dataGridView_Contactos.DataSource = contactos;
                button_Eliminar.Visible = true;
                button_Aniadir.Visible = true;
                textBox_Nombre.Enabled = false;
                dateTimePicker_FechaNacimiento.Enabled = false;
                textBox_Telefono.Enabled = false;
                richTextBox_Observaciones.Enabled = false;
                Reset();
            }
        }

        private void dataGridViewContactos(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridView_Contactos.Rows[e.RowIndex];
                //richTextBox_Observaciones.Text = selectedRow.Cells["Id"].Value.ToString();
                MostrarContactoById((int)selectedRow.Cells["Id"].Value);
            }catch (Exception ex)
            {
               Console.WriteLine(ex.ToString());
            }
        }

        private void Reset()
        {
            textBox_ID.Text = string.Empty;
            textBox_ID.BackColor = Color.WhiteSmoke;
            textBox_Nombre.Text= string.Empty;
            textBox_Telefono.Text= string.Empty;
            richTextBox_Observaciones.Text = string.Empty;
        }

        private void MostrarContactoById(int id)
        {
            Contacto contacto = repository.GetContactById(id);
            if (contacto != null)
            {
                textBox_ID.Text = contacto.Id.ToString();    
                textBox_Nombre.Text = contacto.Nombre;
                dateTimePicker_FechaNacimiento.Text = contacto.FechaNacimiento.ToString();
                textBox_Telefono.Text = contacto.Telefono;
                richTextBox_Observaciones.Text = contacto.Observaciones;

            }

        }
     
    }
}

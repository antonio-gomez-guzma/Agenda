using Microsoft.VisualBasic;

namespace Agenda
{
    public partial class Form1 : Form
    {
        private Repository repository = new Repository();
        public Form1()
        {
            InitializeComponent();
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
        }

        private void buttonEliminar(object sender, EventArgs e)
        {
            ESTADO = state.ELIMINAR;
        }

        private void buttonModificar(object sender, EventArgs e)
        {
            ESTADO = state.MODIFICAR;
        }

        private void buttonCancelar(object sender, EventArgs e)
        {

        }

        private void buttonGuardar(object sender, EventArgs e)
        {
            if(ESTADO == state.ANIADIR)
            {
                repository.AniadirContacto(1, Nombre, FechaNacimiento, Telefono, Observaciones);
                List<Contacto> contactos = repository.GetAllContacts();
                dataGridView_Contactos.DataSource = contactos;
            }else if (ESTADO == state.ELIMINAR)
            {
                
            }
            else if (ESTADO == state.MODIFICAR)
            {
                
            }
        }

        private void dataGridViewContactos(object sender, DataGridViewCellEventArgs e)
        {
          
        }
     
    }
}

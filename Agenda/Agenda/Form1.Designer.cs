namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox_Contacto = new GroupBox();
            richTextBox_Observaciones = new RichTextBox();
            label_Observaciones = new Label();
            textBox_Telefono = new TextBox();
            label_Telefono = new Label();
            dateTimePicker_FechaNacimiento = new DateTimePicker();
            label_FechaNacimiento = new Label();
            textBox_Nombre = new TextBox();
            label_Nombre = new Label();
            textBox_ID = new TextBox();
            label_ID = new Label();
            button_Aniadir = new Button();
            button_Eliminar = new Button();
            button_Modificar = new Button();
            button_Cancelar = new Button();
            button_Guardar = new Button();
            dataGridView_Contactos = new DataGridView();
            groupBox_Contacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Contactos).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Contacto
            // 
            groupBox_Contacto.Controls.Add(richTextBox_Observaciones);
            groupBox_Contacto.Controls.Add(label_Observaciones);
            groupBox_Contacto.Controls.Add(textBox_Telefono);
            groupBox_Contacto.Controls.Add(label_Telefono);
            groupBox_Contacto.Controls.Add(dateTimePicker_FechaNacimiento);
            groupBox_Contacto.Controls.Add(label_FechaNacimiento);
            groupBox_Contacto.Controls.Add(textBox_Nombre);
            groupBox_Contacto.Controls.Add(label_Nombre);
            groupBox_Contacto.Controls.Add(textBox_ID);
            groupBox_Contacto.Controls.Add(label_ID);
            groupBox_Contacto.Location = new Point(12, 12);
            groupBox_Contacto.Name = "groupBox_Contacto";
            groupBox_Contacto.Size = new Size(655, 285);
            groupBox_Contacto.TabIndex = 0;
            groupBox_Contacto.TabStop = false;
            groupBox_Contacto.Text = "Contactos";
            groupBox_Contacto.Enter += groupBoxContactos;
            // 
            // richTextBox_Observaciones
            // 
            richTextBox_Observaciones.Location = new Point(249, 178);
            richTextBox_Observaciones.Name = "richTextBox_Observaciones";
            richTextBox_Observaciones.Size = new Size(347, 101);
            richTextBox_Observaciones.TabIndex = 10;
            richTextBox_Observaciones.Text = "";
            richTextBox_Observaciones.TextChanged += richTextBoxObservaciones;
            // 
            // label_Observaciones
            // 
            label_Observaciones.AutoSize = true;
            label_Observaciones.Location = new Point(6, 181);
            label_Observaciones.Name = "label_Observaciones";
            label_Observaciones.Size = new Size(132, 25);
            label_Observaciones.TabIndex = 8;
            label_Observaciones.Text = "Observaciones:";
            label_Observaciones.Click += labelObservaciones;
            // 
            // textBox_Telefono
            // 
            textBox_Telefono.Location = new Point(249, 141);
            textBox_Telefono.Name = "textBox_Telefono";
            textBox_Telefono.Size = new Size(174, 31);
            textBox_Telefono.TabIndex = 7;
            textBox_Telefono.TextChanged += textBoxTelefono;
            // 
            // label_Telefono
            // 
            label_Telefono.AutoSize = true;
            label_Telefono.Location = new Point(6, 144);
            label_Telefono.Name = "label_Telefono";
            label_Telefono.Size = new Size(83, 25);
            label_Telefono.TabIndex = 6;
            label_Telefono.Text = "Teléfono:";
            label_Telefono.Click += labelTelefono;
            // 
            // dateTimePicker_FechaNacimiento
            // 
            dateTimePicker_FechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimePicker_FechaNacimiento.ImeMode = ImeMode.NoControl;
            dateTimePicker_FechaNacimiento.Location = new Point(249, 104);
            dateTimePicker_FechaNacimiento.Name = "dateTimePicker_FechaNacimiento";
            dateTimePicker_FechaNacimiento.Size = new Size(174, 31);
            dateTimePicker_FechaNacimiento.TabIndex = 5;
            dateTimePicker_FechaNacimiento.ValueChanged += dateTimePickerFechaNacimiento;
            // 
            // label_FechaNacimiento
            // 
            label_FechaNacimiento.AutoSize = true;
            label_FechaNacimiento.Location = new Point(6, 109);
            label_FechaNacimiento.Name = "label_FechaNacimiento";
            label_FechaNacimiento.Size = new Size(178, 25);
            label_FechaNacimiento.TabIndex = 4;
            label_FechaNacimiento.Text = "Fecha de nacimiento:";
            label_FechaNacimiento.Click += labelFechaNacimiento;
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(249, 67);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(223, 31);
            textBox_Nombre.TabIndex = 3;
            textBox_Nombre.TextChanged += textBoxNombre;
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.Location = new Point(6, 70);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(82, 25);
            label_Nombre.TabIndex = 2;
            label_Nombre.Text = "Nombre:";
            label_Nombre.Click += labelNombre;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(249, 30);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(58, 31);
            textBox_ID.TabIndex = 1;
            textBox_ID.TextChanged += textBoxID;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(6, 33);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(32, 25);
            label_ID.TabIndex = 0;
            label_ID.Text = "Id:";
            label_ID.Click += labelID;
            // 
            // button_Aniadir
            // 
            button_Aniadir.Location = new Point(12, 303);
            button_Aniadir.Name = "button_Aniadir";
            button_Aniadir.Size = new Size(112, 34);
            button_Aniadir.TabIndex = 1;
            button_Aniadir.Text = "Añadir";
            button_Aniadir.UseVisualStyleBackColor = true;
            button_Aniadir.Click += buttonAniadir;
            // 
            // button_Eliminar
            // 
            button_Eliminar.Location = new Point(130, 303);
            button_Eliminar.Name = "button_Eliminar";
            button_Eliminar.Size = new Size(112, 34);
            button_Eliminar.TabIndex = 2;
            button_Eliminar.Text = "Eliminar";
            button_Eliminar.UseVisualStyleBackColor = true;
            button_Eliminar.Click += buttonEliminar;
            // 
            // button_Modificar
            // 
            button_Modificar.Location = new Point(248, 303);
            button_Modificar.Name = "button_Modificar";
            button_Modificar.Size = new Size(112, 34);
            button_Modificar.TabIndex = 3;
            button_Modificar.Text = "Modificar";
            button_Modificar.UseVisualStyleBackColor = true;
            button_Modificar.Click += buttonModificar;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Location = new Point(555, 303);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(112, 34);
            button_Cancelar.TabIndex = 4;
            button_Cancelar.Text = "Cancelar";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += buttonCancelar;
            // 
            // button_Guardar
            // 
            button_Guardar.Location = new Point(437, 303);
            button_Guardar.Name = "button_Guardar";
            button_Guardar.Size = new Size(112, 34);
            button_Guardar.TabIndex = 5;
            button_Guardar.Text = "Guardar";
            button_Guardar.UseVisualStyleBackColor = true;
            button_Guardar.Click += buttonGuardar;
            // 
            // dataGridView_Contactos
            // 
            dataGridView_Contactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Contactos.Location = new Point(12, 388);
            dataGridView_Contactos.Name = "dataGridView_Contactos";
            dataGridView_Contactos.RowHeadersWidth = 62;
            dataGridView_Contactos.RowTemplate.Height = 33;
            dataGridView_Contactos.Size = new Size(818, 255);
            dataGridView_Contactos.TabIndex = 6;
            dataGridView_Contactos.CellContentClick += dataGridViewContactos;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 655);
            Controls.Add(dataGridView_Contactos);
            Controls.Add(button_Guardar);
            Controls.Add(button_Cancelar);
            Controls.Add(button_Modificar);
            Controls.Add(button_Eliminar);
            Controls.Add(button_Aniadir);
            Controls.Add(groupBox_Contacto);
            Name = "Form1";
            groupBox_Contacto.ResumeLayout(false);
            groupBox_Contacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Contactos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Contacto;
        private Label label_ID;
        private TextBox textBox_ID;
        private Label label_Nombre;
        private TextBox textBox_Nombre;
        private Label label_FechaNacimiento;
        private DateTimePicker dateTimePicker_FechaNacimiento;
        private Label label_Telefono;
        private TextBox textBox_Telefono;
        private Label label_Observaciones;
        private RichTextBox richTextBox_Observaciones;
        private Button button_Aniadir;
        private Button button_Eliminar;
        private Button button_Modificar;
        private Button button_Cancelar;
        private Button button_Guardar;
        private DataGridView dataGridView_Contactos;
    }
}

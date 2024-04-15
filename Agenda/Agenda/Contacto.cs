using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Contacto
    {
        //CREATE TABLE[dbo].[Contactos]
        //(
        //    [Id] INT           IDENTITY(1, 1) NOT NULL,
        //    [Nombre]          VARCHAR(100) NOT NULL,
        //    [FechaNacimiento] DATE NOT NULL,
        //    [Telefono] VARCHAR(9)   NOT NULL,
        //    [Observaciones]   VARCHAR(500) NULL,
        //    PRIMARY KEY CLUSTERED([Id] ASC)
        //);

        private int id;
        private string nombre;
        //private DateTime FechaNacimiento;
        private string telefono;
        private string? observaciones;
        private string? image;


        private const int NOMBRE_MAX_LENGTH = 100;
        private const int TELEFONO_MAX_LENGTH = 9;
        private const int OBSERVACIONES_MAX_LENGTH = 500;

        public Contacto(int id, string nombre, DateTime fechaNacimiento, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
        }

        public Contacto(int id, string nombre, DateTime fechaNacimiento, string telefono, string Observaciones)
        {
            this.id = id;
            this.nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.observaciones = Observaciones;
        }
        public Contacto(int id, string nombre, DateTime fechaNacimiento, string telefono, string Observaciones, string Image)
        {
            this.id = id;
            this.nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.observaciones = Observaciones;
            this.image = Image;
        }

        public int Id
        {
            get { return id; }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(value));
                else if (value.Length > NOMBRE_MAX_LENGTH)
                    throw new ArgumentException($"{nameof(value)} exceeded max length {NOMBRE_MAX_LENGTH}");
                nombre = value;
            }
        }

        public DateTime FechaNacimiento { get; set; }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(value));
                else if (value.Length > NOMBRE_MAX_LENGTH)
                    throw new ArgumentException($"{nameof(value)} exceeded max length {TELEFONO_MAX_LENGTH}");
                telefono = value;
            }
        }

        public string? Observaciones
        {
            get { return observaciones; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(value));
                else if (value.Length > OBSERVACIONES_MAX_LENGTH)
                    throw new ArgumentException($"{nameof(value)} exceeded max length {OBSERVACIONES_MAX_LENGTH}");
                observaciones = value;
            }
        }

        public string? Image
        {
            get { return image; }
        }
    }
}

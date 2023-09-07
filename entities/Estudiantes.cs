using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reto1.entities
{
    public class Estudiantes
    {
        //Atributos
        private string codigo;
        private string nombre;
        private string correo;
        private int edad ;

        //Propiedades
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        //Constructor de clase
            public Estudiantes()
            {
            }
        public Estudiantes(string codigo, string nombre, string correo, int edad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.correo = correo;
            this.edad = edad;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE24A1_FranGV
{
    public class Cuenta
    {

        // CONSTANTES

        private const int MAX_CARACTERES = 20;
        protected const string DEFATULT = "DESCONOCIDO";
        protected const double DEFATULT_NUM = 0;


        // MIEMBROS

        private string _titular;
        private double _cantidad;

        // CONSTRUCTORES

        public Cuenta()
        {
            _titular = DEFATULT;
            _cantidad = DEFATULT_NUM;
        }

        public Cuenta(string titular)
        {
            Titular = titular;
        }

        public Cuenta(string titular, double cantidad) 
        { 
            Titular = titular;
            Ingresar(cantidad);
        }

        // PROPIEDADES

        public string Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }

        public double Cantidad
        {
            // SOLO LECTURA
            get
            {
                return _cantidad;
            }
        }

        // MÉTODOS

        public virtual void Ingresar(double cantidad)
        {


            _cantidad = _cantidad + cantidad;
         

    
        }

        public void retirar(double cantidad)
        {

            if (Cantidad > 0)

            {
                _cantidad = _cantidad - cantidad;
            }

            else
            {
                throw new Exception("la cuenta está sin fondos ");
            }
        }

        public override string ToString()
        {
            // RECURSOS

            string cadena = "";

            // SALIDA

            cadena = $"Titular: {Titular}";
            cadena += $"Cantidad: {Cantidad}";

            return cadena;
        }

        // VALIDACIÓN

        public void ValidarTexto(string cadena)
        {
            if (cadena.Length > MAX_CARACTERES) throw new MaxCaracterException();

            if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaExeption();
        }
    }

    // EXCEPCIONES PERSONALIZADAS

    public class MaxCaracterException : Exception
    {
        public MaxCaracterException() : base("Supera el rango de caracteres permitido") { }

        public MaxCaracterException(string mensaje) : base(mensaje) { }
    }

    public class CadenaVaciaExeption : Exception 
    {
        public CadenaVaciaExeption() : base("Cadena vacía") { }

        public CadenaVaciaExeption(string mensaje) : base(mensaje) { }
    }

    public class MaxNumExpeption : Exception
    {
        public MaxNumExpeption() : base("Supera el rango de valoress establecido") { }

        public MaxNumExpeption(string mensaje) : base(mensaje) { }
    }
}

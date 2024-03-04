using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE24A1_FranGV
{
    public class CuentaJoven : Cuenta
    {

        // CONSTANTES

        private const int MAX_NUMCUENTA = 20;

        private const int EDAD_MAX = 26;
        private const int EDAD_MIN = 18;

        private const double INGRESO_MAX = 500;



        // MIEMBROS


        private string _numeroCuenta;

        private DateTime _fecha_Nacimiento;



        // CONSTRUCTORES

        public CuentaJoven() : base()
        {
            _numeroCuenta = DEFATULT;
        }

        // PROPIEDADES

        // METODOS

        public override void Ingresar(double cantidad)
        {
            ValidarIngreso(cantidad);

            base.Ingresar(cantidad);
        }

        public void ValidarIngreso(double num)
        {
            if (num > INGRESO_MAX) throw new MaxNumExpeption();
        }

    }
}

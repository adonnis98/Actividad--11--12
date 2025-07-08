using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad__11__12.Clase
{
    public class Beneficiario
    {
        public int id;
        public string idBeneficiario;
        public string nombre;
        public string apellido;
        public string fechanacimineto;
        public string telefono;
        public string direccion;
        private string historialmedico;
        private string Informefundacion;

        public Beneficiario(string idBeneficiario, string nombre, string apellido, string fechanacimineto, string telefono, 
            string direccion, string historialmedico, string informefundacion)
        {
            this.idBeneficiario = idBeneficiario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechanacimineto = fechanacimineto;
            this.telefono = telefono;
            this.direccion = direccion;
            this.historialmedico = historialmedico;
            this.Informefundacion = informefundacion;
        }

        public string GetHistorialMedico()
        {
            Console.WriteLine("Por favor, ingrese el código de acceso para ver el historial médico:");
            string codigoIngresado = Console.ReadLine();

            if (codigoIngresado == this.idBeneficiario)
            {
                return historialmedico;
            }
            else
            {
                Console.WriteLine("Acceso denegado, Código ingresado incorrecto. ");
                return "codigo incorrecto";
            }
        }
        public void SetHistorialMedico(string historialmedico)
        {
            this.historialmedico = historialmedico;
        }


        public string GetInformeFundacion()
        {
            Console.WriteLine("Por favor, ingrese el código de acceso para ver los informes del beneficiario: ");
            string codigoIngresado = Console.ReadLine();

            if (codigoIngresado == this.idBeneficiario)
            {
                return Informefundacion;
            }
            else
            {
                Console.WriteLine("Acceso denegado, Código ingresado incorrecto. ");
                return "codigo incorrecto";
            }
        }

        public void SetInformeFundacion(string informefundacion)
        {
            this.Informefundacion = informefundacion;
        }
     
    }

}

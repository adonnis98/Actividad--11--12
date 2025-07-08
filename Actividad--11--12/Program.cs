using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad__11__12.Clase;

namespace Actividad__11__12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Beneficiario ObjBeneficiario = new Beneficiario("001", "Jeslyn", "Pluas", "2014, 03, 13", "0952037554", 
                "Realidad de Dios Mz.6330 Sl.1", "Sin alergias conocidas", "Informe de fundación: Mejorar Comportamiento ");
            Console.WriteLine("IdBeneficiario: " + ObjBeneficiario.idBeneficiario);
            Console.WriteLine();
            Console.WriteLine("Nombre: " + ObjBeneficiario.nombre);
            Console.WriteLine();

            Console.WriteLine("Apellido: " + ObjBeneficiario.apellido);
            Console.WriteLine();

            Console.WriteLine("Fecha de Nacimiento: " + ObjBeneficiario.fechanacimineto);
            Console.WriteLine();

            Console.WriteLine("Teléfono: " + ObjBeneficiario.telefono);
            Console.WriteLine();

            Console.WriteLine("Dirección: " + ObjBeneficiario.direccion);
            Console.WriteLine();

            Console.WriteLine("Historial Médico: " + ObjBeneficiario.GetHistorialMedico());
            Console.WriteLine();

            Console.WriteLine("Informe de Fundación: " + ObjBeneficiario.GetInformeFundacion());
            Console.WriteLine();
            Console.ReadLine();

            instanciarObjeto();
        }

        private static void instanciarObjeto()
        {

            Console.Clear();
            Console.WriteLine("Bienvenido al sistema de gestión de beneficiarios.");
            Console.WriteLine();
            Console.WriteLine("Por favor, complete la siguiente información para crear un nuevo beneficiario.");
            Console.WriteLine();
            Console.WriteLine("Ingrese un IdBeneficiario: ");
            string idBeneficiario = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese un nuevo Beneficiario: ");
            Console.WriteLine();
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese la fecha de nacimiento (formato: AAAA, MM, DD): ");
            string fechanacimineto = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el teléfono: ");
            string telefono = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese la dirección: ");
            string direccion = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el historial médico: ");
            string historialmedico = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el informe de la fundación: ");
            string informefundacion = Console.ReadLine();
            Console.WriteLine();

 

            Beneficiario OBJETOBeneficiario = new Beneficiario(idBeneficiario, nombre, apellido, fechanacimineto, telefono,
                direccion, historialmedico, informefundacion);
            Console.WriteLine("Beneficiario creado con éxito:");
            Console.WriteLine("ID Beneficiario: " + OBJETOBeneficiario.idBeneficiario);
            Console.WriteLine("Nombre: " + OBJETOBeneficiario.nombre);
            Console.WriteLine("Apellido: " + OBJETOBeneficiario.apellido);
            Console.WriteLine("Fecha de Nacimiento: " + OBJETOBeneficiario.fechanacimineto);
            Console.WriteLine("Teléfono: " + OBJETOBeneficiario.telefono);
            Console.WriteLine("Dirección: " + OBJETOBeneficiario.direccion);
            Console.WriteLine("Historial Médico: " + OBJETOBeneficiario.GetHistorialMedico());
            Console.WriteLine("Informe de Fundación: " + OBJETOBeneficiario.GetInformeFundacion());
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();




           
        }
    }
}

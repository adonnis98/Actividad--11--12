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
        }
    }
}

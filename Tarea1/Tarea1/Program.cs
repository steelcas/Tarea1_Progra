using System;
//tarea#1
namespace Tarea1
{
    public abstract class Persona
    {
        public int ID;
        public string NombreUsuario;
        public string ApellidoUsuario;
        public double Salario;

        public Persona()
        {
            Console.WriteLine();
            Console.WriteLine("Constructor personas");
            Console.WriteLine();
        }

        public abstract void obtenerSalario();        
    }

    public class Empleado : Persona
    {
        int IDEmpleado;


        public Empleado()
        {
            
        }
        
        public override void obtenerSalario()
        {
            Salario = 1000000;
        }
        public void CalcularSalarioEmp()
        {

            IDEmpleado = IDEmpleado + 1;            
            ID = ID + 2;
            NombreUsuario = "ERICK";
            ApellidoUsuario = "steele castro";
            double SalarioNeto = Math.Pow(Salario, 2);

            Console.WriteLine("ID: " + ID);
            Console.WriteLine("ID empleado: " + IDEmpleado);
            Console.WriteLine("Salario bruto: " + Salario + ", salario neto (salario bruto ^ 2): " + SalarioNeto);
            Console.WriteLine("Nombre ingresado: " + NombreUsuario + ", largo de la palabra (Length): " + NombreUsuario.Length);
            Console.WriteLine("Apellido ingresado: " + ApellidoUsuario + ", utilizacion de la cadena de string a partir de un sub indice (Substring): " + ApellidoUsuario.Substring(7));
        }

    }

    public  class Usuario : Persona
    {
        int IDUsuario;


        public Usuario()
        {

        }

        public override void obtenerSalario()
        {
            Salario = 700000;
        }

        public void CalcularSalarioUser()
        {
            double SalarioNeto = 0;
            IDUsuario = IDUsuario + 1;
            ID = ID + 1;
            NombreUsuario = "RICARDO";
            ApellidoUsuario = "castro";

            if (Salario.Equals(700000))
            {
                SalarioNeto = Salario + 50000;
            }
            else
            {
                SalarioNeto = Salario;
            }            

            Console.WriteLine("ID: " + ID);
            Console.WriteLine("ID usuario: " + IDUsuario);
            Console.WriteLine("Salario bruto: " + Salario + ", salario con comisiones (para salarios iguales a 700k comision de 50k): " + SalarioNeto);
            Console.WriteLine("Nombre ingresado: " + NombreUsuario + ", nombre usuario (toLower): " + NombreUsuario.ToLower());
            Console.WriteLine("Apellido ingresado: " + ApellidoUsuario + ", apellido usuario (toUpper): " + ApellidoUsuario.ToUpper());
        }

    }

    class Program
    {
        static void Main()
        {
            Empleado objEmpleado = new Empleado();            

            objEmpleado.obtenerSalario();
            objEmpleado.CalcularSalarioEmp();

            Usuario objUsuario = new Usuario();

            objUsuario.obtenerSalario();            
            objUsuario.CalcularSalarioUser();

        }
    }
}


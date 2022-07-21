using System;

namespace Calcular_el_area_de_un_cuadrado_o_un_circulo_o_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double resultado;
            double Radio;
            Console.WriteLine("Escoja una figura:");
            do
            {
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Circulo");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while ((opcion < 1) || (opcion > 3));

            switch(opcion)
            {
                case 1:
                    AreaCuadrado();
                    break;
                case 2:
                    decimal Base= IngresarNumero("Ingresa la base del triángulo:");
                    decimal Altura= IngresarNumero("Ingresa la altura del triángulo:");
                    AreaTriangulo(Base, Altura);
                    break;
                case 3:
                    Console.Write("Dame el valor del radio de tu círculo: ");
                    Radio = Convert.ToDouble(Console.ReadLine());

                    resultado = AreaCirculo(Radio);
                    Console.WriteLine("El area del circulo es: {0}", resultado);
                    break;
            }
        }
        static void AreaCuadrado()
        {
            decimal Lado, resultado;
            Console.Write("Dame el lado del cuadrado: ");
            Lado = Convert.ToDecimal(Console.ReadLine());

            resultado = Lado * Lado;
            Console.Write("el area del cuadrado es: {0} ", resultado);
        }
        static void AreaTriangulo(decimal Base, decimal Altura)
        {
            decimal resultado;
            resultado = Base * Altura;
            Console.WriteLine("el area del triángulo:{0}", resultado);
        }

        static double AreaCirculo(double RadioA)
        {
            double resultado;
            resultado = Math.PI * (RadioA * RadioA);

            return resultado;
        }

        //MÉTODO PARA RECIBIR LOS NUMEROS
        static decimal IngresarNumero(string peticion)
        {
            //Variable local al método
            decimal numero;

            //pedimos el valor segùn corresponda
            Console.WriteLine(peticion);
            //Convertimos y asignamos
            numero = Convert.ToDecimal(Console.ReadLine());

            //Devolvemos el valor de tipo decimal
            return numero;

        }
    }
}

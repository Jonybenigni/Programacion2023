namespace ParcialdeJonathanBenigni
{
    internal class Program
    {
        static void Main(string[] args)
        {
 

        
            static double HallarElVolumen(double b, double h)
            {
                double resultado = b * h;
                return resultado;
            }

            static double HallarLaBase(double r)
            {
                const double PI = 3.14159;
                double resultado = PI * Math.Pow(r, 2);
                return resultado;
            }

            static double HallarElArea(double r, double h)
            {
                const double PI = 3.14159;
                double resultado = 2 * PI * r * (h + r);
                return resultado;
            }

            static void Main(string[] args)
            {
                double radio, altura, baseCilindro, area, volumen;
                int contador = 0;

                do
                {
                    Console.WriteLine("Ingrese la Altura del cilindro a continuación:");
                    altura = Convert.ToDouble(Console.ReadLine());

                    if (altura > 0)
                    {
                        Console.WriteLine("Ingrese el Radio del Cilindro a continuación:");
                        radio = Convert.ToDouble(Console.ReadLine());

                        if (radio <= 0)
                        {
                            Console.WriteLine("El Radio ingresado es incorrecto");
                        }
                        else
                        {
                            area = HallarElArea(radio, altura);
                            baseCilindro = HallarLaBase(radio);
                            volumen = HallarElVolumen(baseCilindro, altura);

                            Console.WriteLine("El área del cilindro es: " + area);
                            Console.WriteLine("La base del cilindro es: " + baseCilindro);
                            Console.WriteLine("El volumen del cilindro es: " + volumen);
                        }
                    }
                    else
                    {
                        Console.WriteLine("La altura ingresada es incorrecta");
                    }

                    if (altura != 0 || radio != 0)
                    {
                        contador++;
                        Console.WriteLine("El número de cilindros registrados es: " + contador);
                    }

                } while (altura > 0 || radio > 0);
            }
        }









    }
}
}
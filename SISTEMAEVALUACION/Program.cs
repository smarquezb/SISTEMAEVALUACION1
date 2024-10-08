public class sistemanotas
{
    public static void Main(string[]args)
    {
        bool continuar = true;
        int estudiantesGanaron = 0;
        int estudiantesPerdieron = 0;

        while (continuar)
        {
            Console.WriteLine("Ingrese el número de estudiantes:");
            int numEstudiantes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.Write($"Ingrese nombre del estudiante {i + 1}: ");
                string nombre = Console.ReadLine();
                Console.Write($"Ingrese nota 1 (0-5): ");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Ingrese nota 2 (0-5): ");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Ingrese nota 3 (0-5): ");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                double promedio = (nota1 + nota2 + nota3) / 3;

                string categoria = "";
                if (promedio >= 4.5)
                {
                    categoria = "Excelente";
                    estudiantesGanaron++;
                }
                else if (promedio >= 4.0 && promedio < 4.5)
                {
                    categoria = "Sobresaliente";
                    estudiantesGanaron++;
                }
                else if (promedio >= 3.5 && promedio < 4.0)
                {
                    categoria = "Bueno";
                    estudiantesGanaron++;
                }
                else
                {
                    categoria = "Insuficiente";
                    estudiantesPerdieron++;
                }

                Console.WriteLine($"Nombre: {nombre}, Promedio: {promedio:F2}, Categoría: {categoria}");
            }

            Console.Write("¿Desea ingresar otro grupo de estudiantes? (s/n): ");
            string respuesta = Console.ReadLine();
            continuar = respuesta.ToLower() == "s";
        }

        Console.WriteLine($"Estudiantes que ganaron: {estudiantesGanaron}");
        Console.WriteLine($"Estudiantes que perdieron: {estudiantesPerdieron}");
    }
}
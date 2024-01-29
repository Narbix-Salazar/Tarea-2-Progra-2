using System;

class Program
{
    static void Main()
    {
        int empleadosOperarios = 0;
        decimal acumuladoSalarioNetoOperarios = 0;
        int empleadosTecnicos = 0;
        decimal acumuladoSalarioNetoTecnicos = 0;
        int empleadosProfesionales = 0;
        decimal acumuladoSalarioNetoProfesionales = 0;

        while (true)
        {
            // Solicitar datos al usuario
            Console.Write("Ingrese el número de cédula del empleado (o '0' para salir): ");
            string cedula = Console.ReadLine();

            if (cedula == "0")
            {
                break;
            }

            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
            int tipoEmpleado = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de horas laboradas: ");
            decimal horasLaboradas = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio por hora: ");
            decimal precioPorHora = decimal.Parse(Console.ReadLine());

            // Calcular salario ordinario
            decimal salarioOrdinario = horasLaboradas * precioPorHora;

            // Calcular aumento
            decimal aumento = 0;
            switch (tipoEmpleado)
            {
                case 1:
                    aumento = salarioOrdinario * 0.15m;
                    empleadosOperarios++;
                    acumuladoSalarioNetoOperarios += salarioOrdinario + aumento;
                    break;
                case 2:
                    aumento = salarioOrdinario * 0.10m;
                    empleadosTecnicos++;
                    acumuladoSalarioNetoTecnicos += salarioOrdinario + aumento;
                    break;
                case 3:
                    aumento = salarioOrdinario * 0.05m;
                    empleadosProfesionales++;
                    acumuladoSalarioNetoProfesionales += salarioOrdinario + aumento;
                    break;
            }

            // Calcular salario bruto, deducciones y salario neto
            decimal salarioBruto = salarioOrdinario + aumento;
            decimal deduccionCCSS = salarioBruto * 0.0917m;
            decimal salarioNeto = salarioBruto - deduccionCCSS;

            // Mostrar resultados para cada transacción
            Console.WriteLine("\nResultados para la transacción:");
            Console.WriteLine($"Cedula: {cedula}");
            Console.WriteLine($"Nombre Empleado: {nombre}");
            Console.WriteLine($"Tipo Empleado: {tipoEmpleado}");
            Console.WriteLine($"Salario por Hora: {precioPorHora}");
            Console.WriteLine($"Cantidad de Horas: {horasLaboradas}");
            Console.WriteLine($"Salario Ordinario: {salarioOrdinario}");
            Console.WriteLine($"Aumento: {aumento}");
            Console.WriteLine($"Salario Bruto: {salarioBruto}");
            Console.WriteLine($"Deducción CCSS: {deduccionCCSS}");
            Console.WriteLine($"Salario Neto: {salarioNeto}");
        }

        // Mostrar estadísticas finales
        Console.WriteLine("\nEstadísticas Finales:");
        Console.WriteLine($"1) Cantidad Empleados Tipo Operarios: {empleadosOperarios}");
        Console.WriteLine($"2) Acumulado Salario Neto para Operarios: {acumuladoSalarioNetoOperarios}");
        Console.WriteLine($"3) Promedio Salario Neto para Operarios: {(empleadosOperarios > 0 ? acumuladoSalarioNetoOperarios / empleadosOperarios : 0)}");
        Console.WriteLine($"4) Cantidad Empleados Tipo Técnico: {empleadosTecnicos}");
        Console.WriteLine($"5) Acumulado Salario Neto para Técnicos: {acumuladoSalarioNetoTecnicos}");
        Console.WriteLine($"6) Promedio Salario Neto para Técnicos: {(empleadosTecnicos > 0 ? acumuladoSalarioNetoTecnicos / empleadosTecnicos : 0)}");
        Console.WriteLine($"7) Cantidad Empleados Tipo Profesional: {empleadosProfesionales}");
        Console.WriteLine($"8) Acumulado Salario Neto para Profesionales: {acumuladoSalarioNetoProfesionales}");
        Console.WriteLine($"9) Promedio Salario Neto para Profesionales: {(empleadosProfesionales > 0 ? acumuladoSalarioNetoProfesionales / empleadosProfesionales : 0)}");

    }
}


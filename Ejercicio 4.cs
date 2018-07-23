using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Reciba el salario bruto de un empleado por teclado y aplique porcentaje de impuestos sobre la renta según corresponda,
             * un cargo de 0.0287 de AFP y un cargo de 0.0304 de seguro familiar de salud, resultando el sueldo neto.*/

            double SueldoBruto, AFP = 0.0287, SFS = 0.0304, ISR;
            Console.WriteLine("Programa que calcula la nomina mensual de un empleado");
            Console.Write("Ingrese el sueldo del empleado: ");
            SueldoBruto = double.Parse(Console.ReadLine());

            double calcAFP = SueldoBruto * AFP;
            double calcSFS = SueldoBruto * SFS;
            double calcSueldoNeto = SueldoBruto - (calcAFP + calcSFS);
            double calEscalaAnual = calcSueldoNeto * 12;

            if (calEscalaAnual <= 416220.00)
            {
                ISR = 0;
                Resultado(SueldoBruto, ISR, calcAFP, calcSFS, calcSueldoNeto);
            }
            else if ((calEscalaAnual >= 416220.01) && (calEscalaAnual <= 624329.00))
            {
                ISR = Math.Abs((416220.01 - calEscalaAnual) * 0.15);
                Resultado(SueldoBruto, ISR, calcAFP, calcSFS, calcSueldoNeto);
            }
            else if ((calEscalaAnual >= 624329.01) && (calEscalaAnual <= 867123.00))
            {
                ISR = 31216.00 + Math.Abs((624329.01 - calEscalaAnual) * 0.20);
                Resultado(SueldoBruto, ISR, calcAFP, calcSFS, calcSueldoNeto);
            }
            else if (calEscalaAnual >= 867123.01)
            {
                ISR = 79776 + Math.Abs((867123.01 - calEscalaAnual) * 0.25);
                Resultado(SueldoBruto, ISR, calcAFP, calcSFS, calcSueldoNeto);
            }
        }
        static void Resultado(double SueldoBruto, double ISR, double calcAFP, double calcSFS, double calcSueldoNeto)
        {
            Console.WriteLine("Sueldo Bruto: {0}", SueldoBruto);
            Console.WriteLine("ISR: {0}", string.Format("{0:0.00}", ISR / 12));
            Console.WriteLine("AFP: {0}", calcAFP);
            Console.WriteLine("SFS: {0}", calcSFS);
            Console.WriteLine("Sueldo Neto: {0}", string.Format("{0:0.00}", calcSueldoNeto - ISR / 12));
        }
    }
}

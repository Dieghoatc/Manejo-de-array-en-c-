using System;

namespace c_
{
    class Numeros
    {


        void Operacion()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] Nums = { 2, 4, 1, 3, 5 };
            int[] Res = new int[Nums.Length];

            int y = 0;
            // int cont = 0;

            for (int cont = 0; cont < Nums.Length; cont++)
            {
                for (int x = 0; x < Nums.Length; x++)
                {
                    //13,11,14,12,10
                    if (x != cont)
                    {
                        y += Nums[x];
                        // Console.WriteLine("Bucle1 " + y);

                    }
                }
                Console.WriteLine("Bucle2 " + y);
                Res[cont] = y;
                y = 0;
            }
            // Console.WriteLine("Resultado de la suma: " + Res[0]);


            int mayor, menor;
            mayor = menor = Res[0];

            for (int z = 0; z < Res.Length; z++)
            {
                if (Res[z] > mayor)
                {
                    mayor = Res[z];
                }
                if (Res[z] < menor)
                {
                    menor = Res[z];
                }
            }
            Console.WriteLine("El Valor Mayor es " + mayor);
            Console.WriteLine("El Valor Menor es " + menor);

        }
    }
}

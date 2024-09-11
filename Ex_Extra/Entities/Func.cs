using System;

namespace Ex_Extra.Entities
{
    public class Func
    {

        public void MediaMaisMenosRandom(int tamanhoLista, out double mediaFinal, out List<int> AparecemMaisFinal, out List<int> AparecemMenosFinal)
        {
            //Nunca esquecer de instanciar os out antes de usa-los
            mediaFinal = 0;
            AparecemMaisFinal = new List<int>();
            AparecemMenosFinal = new List<int>();

            List<int> list = new List<int>();
            Random generator = new Random();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            Console.Write("List: ");

            //preenche lista
            for (int i = 0; i < tamanhoLista; i++)
            {
                int numeroAleatorio = generator.Next(1, 5);
                list.Add(numeroAleatorio);
                mediaFinal += list[i];

                Console.Write(" " + list[i]);
            }

            //preenche dict com keys distintos e valores à 0. Keys = numeros distintos na lista, Valores = # vezes aparecem
            for (int i = 0; i < list.Count; i++)
            {
                int current = list[i];

                for (int j = 1; j < list.Count; j++)
                {
                    if (!dict.ContainsKey(current))
                    {
                        dict.Add(current, 0);
                    }
                }
            }

            //preenche values, freq dos numeros, do dict
            foreach (int val in dict.Keys)
            {
                foreach (int num in list)
                {
                    if (val == num)
                    {
                        dict[val]++;
                    }
                }
            }

            int max = 0; //set para menor numero para pegar o maior value, nenhum terá 0 aparições
            int min = 1000000000; //set para numero gigante para pegar o menor value

            //Indetifica as frequência max e min, maiores e menores valores nas values
            foreach (int n in dict.Values)
            {
                if (max < n) max = n;
                if (min > n) min = n;
            }


            //Adiciona todos os valores de keys, cujo o value é compativel ao max e min, respectivamente
            foreach (int element in dict.Keys)
            {
                if (dict[element] == max) AparecemMaisFinal.Add(element);
                if (dict[element] == min) AparecemMenosFinal.Add(element);
            }

            mediaFinal /= list.Count;

        }



        public void MediaMaisMenos(List<int> list, out double mediaFinal, out List<int> AparecemMaisFinal, out List<int> AparecemMenosFinal)
        {
            //Nunca esquecer de instanciar os out antes de usa-los
            mediaFinal = 0;
            AparecemMaisFinal = new List<int>();
            AparecemMenosFinal = new List<int>();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            Console.Write("List: ");

            //não precisa preencher lista pois já foi dada
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(" " + list[i]);
            }

            //preenche dict com keys distintos e valores à 0. Keys = numeros distintos na lista, Valores = # vezes aparecem
            for (int i = 0; i < list.Count; i++)
            {
                int current = list[i];
                mediaFinal += current;

                for (int j = 1; j < list.Count; j++)
                {
                    if (!dict.ContainsKey(current))
                    {
                        dict.Add(current, 0);
                    }
                }
            }

            //preenche values, freq dos numeros, do dict
            foreach (int val in dict.Keys)
            {
                foreach (int num in list)
                {
                    if (val == num)
                    {
                        dict[val]++;
                    }
                }
            }

            int max = 0; //set para menor numero para pegar o maior value, nenhum terá 0 aparições
            int min = 1000000000; //set para numero gigante para pegar o menor value

            //Indetifica as frequência max e min, maiores e menores valores nas values
            foreach (int n in dict.Values)
            {
                if (max < n) max = n;
                if (min > n) min = n;
            }


            //Adiciona todos os valores de keys, cujo o value é compativel ao max e min, respectivamente
            foreach (int element in dict.Keys)
            {
                if (dict[element] == max) AparecemMaisFinal.Add(element);
                if (dict[element] == min) AparecemMenosFinal.Add(element);
            }

            mediaFinal /= list.Count;

        }


        public void PrintMediaMaisMenos(double media, List<int> AparecemMaisFinal, List<int> AparecemMenosFinal)
        {
            Console.WriteLine();
            Console.WriteLine("Média: " + media);

            Console.Write("Elementos que mais aparecem: ");

            foreach (int mais in AparecemMaisFinal)
            {
                Console.Write(mais + " ");
            }

            Console.WriteLine();

            Console.Write("Elementos que menos aparecem: ");
            foreach (int menos in AparecemMenosFinal)
            {
                Console.Write(menos + " ");
            }

        }


    }
}


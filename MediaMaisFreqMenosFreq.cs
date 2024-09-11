using System;

namespace MediaMaxFreqMenosFreq.Entities
{
    public class Func
    {

        public void MediaMaisMenosRandom(int tamanhoLista, out double media, out List<int> AparecemMais, out List<int> AparecemMenos)
        {
            List<int> list = new List<int>();
            Random generator = new Random();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            double media = 0;

            Console.Write("List: ");

            //preenche lista
            for (int i = 0; i < tamanhoLista; i++)
            {
                int numeroAleatorio = generator.Next(1, 101);
                list.Add(numeroAleatorio);
                media += list[i];

                Console.Write(" " + list[i]);
            }

            //preenche dict com keys distintos e valores à 0. Keys = numeros distintos na lista, Valores = # vezes aparecem
            for (int i = 0; i < list.Count; i++)
            {

                bool currentDiff = true;
                int current = list[i];

                for (int j = 1; j < list.Count && currentDiff; j++)
                {
                    if (list[i].Equals(list[j]))
                    {
                        dict.Add(current, 0);
                        currentDiff = false;
                    }
                }

                if (currentDiff)
                {
                    dict.Add(current, 0);
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

            int max = 0;
            int min = 0;

            //Indetifica as frequência max e min, maiores e menores valores nas values
            foreach (int n in dict.Values)
            {
                if (max < n) max = n;
                if (min > n) min = n;
            }

            List<int> AparecemMais = new List<int>();
            List<int> AparecemMenos = new List<int>();

            //Adiciona todos os valores de keys, cujo o value é compativel ao max e min, respectivamente
            foreach (int element in dict.Keys)
            {
                if (dict[element] == max) AparecemMais.Add(element);
                if (dict[element] == min) AparecemMenos.Add(element);
            }

            media /= list.Count;

        }


    }
}


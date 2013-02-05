using System;

namespace CodilityTest
{
    public class Test
    {
        public static int adjacent_points_min_distance ( int[] A )
        {
            var total_indices = A.Length -1;
            var indice_referencia_esquerda = 0;
            var menor_distancia_encontrada = -2;

            while (indice_referencia_esquerda <= total_indices)
            {

                for (int i = indice_referencia_esquerda; i < total_indices; i++)
                {
                    if (A[indice_referencia_esquerda] == A[i + 1])
                    {
                        menor_distancia_encontrada = 0;
                        continue;
                    }

                    if (Math.Abs(A[indice_referencia_esquerda] - A[i]) < menor_distancia_encontrada)
                    {
                        menor_distancia_encontrada = A[indice_referencia_esquerda] - A[i];
                    }
                }

                indice_referencia_esquerda++;
            }

            if (menor_distancia_encontrada > 100000000)
                return -1;
            return menor_distancia_encontrada;
        }

        public static int absDistinct(int[] A)
        {
            var ocorrencias = 0;
            var indiceEsquerda = 0;
            var indiceDireta = A.Length - 1;
            while (indiceEsquerda < indiceDireta)
            {
                if (Math.Abs(A[indiceEsquerda]) == Math.Abs(A[indiceEsquerda + 1]))
                {
                    ocorrencias++;
                    indiceEsquerda++;
                    continue;
                }

                if (A[indiceEsquerda] < 0)
                {
                    for (int count = indiceDireta; Math.Abs(A[indiceEsquerda]) <= Math.Abs(A[count]); count--)
                    {
                        if (Math.Abs(A[indiceEsquerda]) == Math.Abs(A[count]))
                        {
                            ocorrencias++;
                        }
                    }
                }
                indiceEsquerda++;
            }
            if (ocorrencias == 0)
                return 0;

            return A.Length - ocorrencias;
        }
    }
}

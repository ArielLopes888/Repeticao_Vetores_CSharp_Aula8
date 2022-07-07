using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula8
{
    public class Filmes
    {
        String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan", "o Bárbaro", "Highlander" };

        // 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
        public string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
        {

            string lista = String.Join(" ; ", listaDeFilmes);

            return lista;
        }

        // 1.1. Apresentar quantidade de filmes da lista.
        public int quantidadeTotalDeFilmes()
        {
            return listaDeFilmes.Length;
        }

        // 1.3. Buscar o nome do filme de acordo com seu índice.
        public string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
        {
            return listaDeFilmes[indiceDoFilme];
        }


        // 1.4. Adiciona um novo filme a lista pelo seu nome.
        public String adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
        {
            listaDeFilmes.Append(nomeDoFilme).ToArray();
            return apresentaTodosOsFilmesSeparadosPorPontoVirgula();
        }

        // 1.5. Atualiza um filme a partir do seu índice na lista.
        public String atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string novoNomeDoFilme)
        {
            //for (int i = 0; i < listaDeFilmes.Length; i++)
            //{
            //  if (i == indiceDoFilme)
            // {
            //     listaDeFilmes[i] = novoNomeDoFilme;
            //   }
            //}
            listaDeFilmes[indiceDoFilme] = novoNomeDoFilme;
            return apresentaTodosOsFilmesSeparadosPorPontoVirgula();
        }
        //1.6. Listar todos os filmes com seu índice/posição na lista.
        public String listarTodosOsFilmesComSeuIndiceNaLista()
        {
            string listaComIndice = string.Empty;
            for (int i = 0; i < listaDeFilmes.Length; i++)
            {
                listaComIndice += i + "-" + listaDeFilmes[i] + Environment.NewLine;
            }
            return listaComIndice;
        }
    }

    internal class Program : Filmes
    {
        static void Main(string[] args)
        {
            Filmes filmes = new Filmes();
            

            // Retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander


            Console.WriteLine($"1. Lista de todos os filmes separados por ponto e vírgula: {filmes.apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");


            // Retorna o número 7.

            Console.WriteLine($"2. Quantidade de filmes da lista: {filmes.quantidadeTotalDeFilmes()} ");


            // Se o índice for 0, retorna Clube dos Cinco;

            Console.WriteLine($"3. Filme por indice: {filmes.buscarNomeDoFilmePeloIndice(0)}");


            // Se o filme for Sexta-feira 13th, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander, Sexta-feira 13th

            Console.WriteLine($"4. Adiciona um filme pelo nome: {filmes.adicionaUmNovoFilmePeloSeuNome("Sexta-feira 13th")}");


            // Se o índice for 3 e o nome for atualizado para Velozes e Furiosos, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Velozes e Furiosos; Conan, o Bárbaro; Highlander, Sexta-feira 13th

            Console.WriteLine($"5. Atualizar um filme pelo seu índice: {filmes.atualizarUmFilmePeloSeuIndice(3, "Velozes e Furiosos")}");


            // Retorna 

            // 0 - Clube dos Cinco 

            // 1 - A Hora do Pesadelo 

            // 2 - Karatê Kid

            // 3 - Rocky III

            // 4 - Conan, o Bárbaro

            // 5 - Highlander

            // 6 - Sexta-feira 13th

            Console.WriteLine($"6. Listar todos os filmes com seu indice/posicao na lista. {filmes.listarTodosOsFilmesComSeuIndiceNaLista()}");

        }
    }   
    
        
}


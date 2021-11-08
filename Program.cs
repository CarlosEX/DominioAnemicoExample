using System;
using DominioAnemicoExample.Entities.DominioAnemico;
using DominioAnemicoExample.Enums;

namespace DominioAnemicoExample {
    class Program{
        static void Main(string[] args){

            var artigo = new Article();

            artigo.Id = 1;
            artigo.Date = DateTime.Now;
            artigo.Title = "Power";
            artigo.Content = "Artigo sobre domínios anêmicos...";
            artigo.ArticleCategory = ArticleCategory.Scientific;
            artigo.ArticleState = ArticleState.Scheduled;

            Console.WriteLine(artigo.Title);
        }
    }
}

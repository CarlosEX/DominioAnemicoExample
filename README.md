# AntiPattern - Domínios Anêmicos

Compreender e conhecer os Anti-Padrões permite-nos evitá-los pois são uma armadilha que levam a situações desastrosas.

## Introdução

Neste post, vamos fazer uma breve explanação a respeito de domínios anêmicos, que é considerado um AntiPattern.

Meu objetivo é atuar como backend .NET C#, e entender os princípios de designer do DDD, é algo crucial para projetar modelos de domínios de softwares mais consistentes e robustos. E a medida em que eu aprendo, percebo que alguns conceitos são aplicáveis a qualquer software, seja ele, grande e complexo, ou pequeno e simples.

## O que é um domínio anêmico?

Em poucas palavras; são classes que contém apenas propriedades com seus getters e setters. Essa prática, não é recomenda porque não explora o verdadeiro poder da POO, e também, a longo prazo, gerar gargalos na estrutura de código do projeto.

## Mão na massa

Para não ficarmos apenas na teoria, vamos criar um projeto simples de console em .NET 5 com C#.


Primeiro criei dois enums:

ArticleCategory

    public enum ArticleCategory{
       Motivational,
       Scientific,
       Documentary
    }

ArticleState

    public enum ArticleState  {
       Published,
       Scheduled,
       CalledOff
    }


Agora vamos criar a classe anêmica, só com as propriedades getters e setters , sem nenhum construtor, sem nenhum método e nenhuma validação. Esse modelo apresenta diversos problemas que iremos discutir nos próximos artigos.

    public class Article{
       public int Id { get; set; }
       public DateTime Date { get; set; }
       public string Title { get; set; }
       public string Content { get; set; }
       public ArticleCategory ArticleCategory { get; set; }
       public ArticleState ArticleState { get; set; }
    }


E por último, vamos fazer a chamada e criação de um objeto com essa classe.

      class Program{
         static void Main(string[] args){

            var artigo = new Article();

            artigo.Id = 1;
            artigo.Date = DateTime.Now;
            artigo.Title = "AntiPattern";
            artigo.Content = "Artigo, domínios anêmicos...";
            artigo.ArticleCategory = ArticleCategory.Scientific;
            artigo.ArticleState = ArticleState.Scheduled;

            Console.WriteLine(artigo.Title);
         }
      }

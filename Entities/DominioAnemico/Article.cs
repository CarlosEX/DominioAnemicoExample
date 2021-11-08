using System;
using System.ComponentModel.DataAnnotations;
using DominioAnemicoExample.Enums;

namespace DominioAnemicoExample.Entities.DominioAnemico{
    public class Article{
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [StringLength(10)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public ArticleCategory ArticleCategory { get; set; }
        [Required]
        public ArticleState ArticleState { get; set; }

    }
}
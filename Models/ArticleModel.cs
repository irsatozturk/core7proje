using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core7proje.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string? Header {get; set;}
        public string? Description {get; set;}
        public string? Image {get; set;}
    }
}
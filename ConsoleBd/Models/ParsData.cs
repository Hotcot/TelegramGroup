namespace ConsoleBd
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ParsData")]
    public partial class ParsData
    {
        public int Id { get; set; }

        public TimeSpan DateArticle { get; set; }

        [Required]
        public string NameArticle { get; set; }

        [Required]
        public string LinkArticle { get; set; }

        [Required]
        public string TextArticle { get; set; }
    }
}

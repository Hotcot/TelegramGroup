namespace ConsoleBd
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    [Table("TegsData")]
    public partial class TegsData
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Teg { get; set; }
    }
}

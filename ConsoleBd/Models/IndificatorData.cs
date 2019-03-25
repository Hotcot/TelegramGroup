namespace ConsoleBd
{
  
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    [Table("IndificatorData")]
    public partial class IndificatorData
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string IndificTeg { get; set; }
    }
}

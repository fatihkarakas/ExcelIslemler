namespace ExcelIslemler
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HastaneBilgi")]
    public  class HastaneBilgi
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Column("HastaneAdi")]
        public string KurumAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string Vkn { get; set; }


        public byte IsActive { get; set; } = 1;
    }
}
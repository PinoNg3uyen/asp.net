using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Database.Entities
{
    [Table("HangHoa")]
    public class HangHoaEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HangHoaId { get; set; }

        public int NhomHangId { get; set; }

        [StringLength(200)]
        public string TenHangHoa { get; set; } = null!;

        public int GiaBan { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; } = "";

        [ForeignKey(nameof(NhomHangId))]
        public NhomHangEntity NhomHang { get; set; } = null!;
    }
}

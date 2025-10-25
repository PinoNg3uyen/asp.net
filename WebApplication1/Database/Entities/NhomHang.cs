using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("NhomHang")]
public class NhomHangEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int NhomId { get; set; }

    [StringLength(200)]
    public string TenNhom { get; set; } = null!;

    [StringLength(500)]
    public string GhiChu { get; set; } = "";

    public ICollection<NhomHangEntity> HangHoas { get; set; } = [];
}

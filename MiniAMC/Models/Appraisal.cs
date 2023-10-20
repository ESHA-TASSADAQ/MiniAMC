using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Appraisal")]
public class Appraisal
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AppraisalId { get; set; }
    public string PropertyAddress { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? AppraisalDate { get; set; }
    public decimal AppraisalValue { get; set; }
    [Required]
    public int ProductId { get; set; }
    [Required]
    public int StatusId { get; set; }
    public List<Comment> Comments { get; set; }
    public Product Product { get; set; }
    public Status Status { get; set; }
}
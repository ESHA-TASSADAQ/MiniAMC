using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Status
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StatusId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
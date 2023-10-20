using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Comment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CommentId { get; set; }
    public int AppraisalId { get; set; }
    public string Text { get; set; }
    public DateTime CommentDate { get; set; }

    public Appraisal Appraisal { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace DevShareWebApi.Data.Entities;

public class User
{
    [Key]
    public int UserID { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required, MaxLength(255)]
    public string Email { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; set; }
}
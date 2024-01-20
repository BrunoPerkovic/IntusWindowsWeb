using System.ComponentModel.DataAnnotations;

namespace IntusWindowsWeb.Models;

public abstract class DbBase
{
    [Key] public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
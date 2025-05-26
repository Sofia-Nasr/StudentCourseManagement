using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Student
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [JsonPropertyName("stname")]
    public string Name { get; set; }

    [Required]
    [MaxLength(100)]
    public string Course { get; set; }
}

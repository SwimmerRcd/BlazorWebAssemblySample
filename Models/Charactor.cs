namespace BlazorWebAssemblySample.Models
{
  using System.ComponentModel.DataAnnotations;
  public class Charactor
  {
    [Required]
    [StringLength(14, ErrorMessage = "Identifier too long (14 character limit).")]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = "Frodo";
    public int HitPoints { get; set; } = 100;
    public int Strength { get; set; } = 10;
    public int Defense { get; set; } = 10;
    public int Intelligence { get; set; } = 10;
    public RpgClass Class { get; set; } = RpgClass.Knight;
  }
}
using System.ComponentModel.DataAnnotations;

namespace Clean.Architecture.Web.Pep;

public class GetPepRequest
{
  public const string Route = "/Pep";
  
  [Required]
  public string? Document { get; set; }
}

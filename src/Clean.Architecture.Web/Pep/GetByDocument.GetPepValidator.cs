using FastEndpoints;
using FluentValidation;

namespace Clean.Architecture.Web.Pep;

public class GetPepValidator : Validator<GetPepRequest>
{
  public GetPepValidator()
  {
    RuleFor(x => x.Document)
      .NotEmpty()
      .WithMessage("Document is required.")
      .MinimumLength(11)
      .MaximumLength(14);
  }
}

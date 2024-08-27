using Ardalis.Result;
using Clean.Architecture.UseCases.Pep;
using Clean.Architecture.UseCases.Pep.Get;
using FastEndpoints;
using MediatR;

namespace Clean.Architecture.Web.Pep;

public class GetByDocument : Endpoint<GetPepRequest, List<PepDTO>>
{
  private readonly IMediator _mediator;

  public GetByDocument(IMediator mediator)
  {
    _mediator = mediator;
  }
  
  public override void Configure()
  {
    Get(GetPepRequest.Route);
    AllowAnonymous();
  }

  public override async Task HandleAsync(
    GetPepRequest request,
    CancellationToken cancellationToken)
  {
    
    var command = new GetPepQuery(request.Document!);
    var result = await _mediator.Send(command);
  
    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }
  
    if (result.IsSuccess)
    {
      //Response = result.Value.Select(dto => new PepRecord(dto)).ToList();
      Response = result.Value;
    }
  }
}

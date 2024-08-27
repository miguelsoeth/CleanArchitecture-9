using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Clean.Architecture.UseCases.Pep.Get;

public class GetPepHandler : IQueryHandler<GetPepQuery, Result<List<PepDTO>>>
{
  private readonly IGetPepQueryService _getPepQueryService;

  public GetPepHandler(IGetPepQueryService getPepQueryService)
  {
    _getPepQueryService = getPepQueryService;
  }
  
  public async Task<Result<List<PepDTO>>> Handle(GetPepQuery request, CancellationToken cancellationToken)
  {

    var result = await _getPepQueryService.GetPepAsync(request.Document);
    return Result.Success(result);
  }
}

namespace Clean.Architecture.UseCases.Pep.Get;

public interface IGetPepQueryService
{
  Task<List<PepDTO>> GetPepAsync(string documento);
}

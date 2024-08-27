using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Clean.Architecture.UseCases.Pep.Get;

public record GetPepQuery(string Document) : IQuery<Result<List<PepDTO>>>;

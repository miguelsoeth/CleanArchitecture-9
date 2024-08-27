using System.Text.Json;
using Clean.Architecture.UseCases.Pep;
using Clean.Architecture.UseCases.Pep.Get;

namespace Clean.Architecture.Infrastructure.Data.Queries;

public class GetPepQueryService : IGetPepQueryService
{
  private readonly string apiKey = "7c137febe8f79a03ffe7a437026f0e05";
  
  public async Task<List<PepDTO>> GetPepAsync(string documento)
  {
    var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.portaldatransparencia.gov.br/api-de-dados/peps?cpf={documento}");            
    request.Headers.Add("chave-api-dados", apiKey);

    var client = new HttpClient();
    var response = await client.SendAsync( request );
    var contentResponse = await response.Content.ReadAsStringAsync();
    var objResponse = JsonSerializer.Deserialize<List<PepDTO>>( contentResponse );

    if (response.IsSuccessStatusCode)
    {
      if (objResponse != null)
      {
        return objResponse;
      }
    }
    
    return new List<PepDTO>();
  }
}

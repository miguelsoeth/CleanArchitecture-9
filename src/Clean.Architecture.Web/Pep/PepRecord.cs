using Clean.Architecture.UseCases.Pep;

namespace Clean.Architecture.Web.Pep;

public record PepRecord(
  string cpf,
  string nome,
  string sigla_funcao,
  string descricao_funcao,
  string nivel_funcao,
  string cod_orgao,
  string nome_orgao,
  string dt_inicio_exercicio,
  string dt_fim_exercicio,
  string dt_fim_carencia)
{
  public PepRecord(PepDTO dto)
    : this(
      dto.cpf, 
      dto.nome,
      dto.sigla_funcao,
      dto.descricao_funcao,
      dto.nivel_funcao,
      dto.cod_orgao,
      dto.nome_orgao,
      dto.dt_inicio_exercicio,
      dto.dt_fim_exercicio,
      dto.dt_fim_carencia)
  {
  }
}

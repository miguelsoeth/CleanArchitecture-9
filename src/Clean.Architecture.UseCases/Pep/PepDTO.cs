using System.Text.Json.Serialization;

namespace Clean.Architecture.UseCases.Pep;

public record PepDTO(
  string cpf,
  string nome,
  string sigla_funcao,
  string descricao_funcao,
  string nivel_funcao,
  string cod_orgao,
  string nome_orgao,
  string dt_inicio_exercicio,
  string dt_fim_exercicio,
  string dt_fim_carencia);

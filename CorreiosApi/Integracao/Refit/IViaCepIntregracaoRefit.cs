using CorreiosApi.Integracao.Response;
using Refit;

namespace CorreiosApi.Integracao.Refit;

public interface IViaCepIntregracaoRefit
{
    [Get("/ws/{cep}/json")]
    Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
}

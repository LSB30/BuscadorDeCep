using CorreiosApi.Integracao.Refit;
using CorreiosApi.Integracao.Response;

namespace CorreiosApi.Integracao.Interfaces;

public class ViaCepIntegracao: IViaCepIntegracao
{
    private readonly IViaCepIntregracaoRefit _viaCepIntregracaoRefit;
    public ViaCepIntegracao(IViaCepIntregracaoRefit viaCepIntregracaoRefit)
    {
        _viaCepIntregracaoRefit = viaCepIntregracaoRefit;
    }
    public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
    {
        var responseData = await _viaCepIntregracaoRefit.ObterDadosViaCep(cep);

        if(responseData != null && responseData.IsSuccessStatusCode)
        {
            
            return responseData.Content;
        }

        return null;
    }
}

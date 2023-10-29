using IntroducaoAPI.Integration.Response;
using Refit;

namespace IntroducaoAPI.Integration.Refit
{
    public interface IViaCepIntegracaoRefit
    {

        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}

using IntroducaoAPI.Integration.Response;

namespace IntroducaoAPI.Integration.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);
    }
}

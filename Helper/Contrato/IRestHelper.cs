namespace Helper.Contrato
{
    public interface IRestHelper
    {
        public Task<string> consumirGet(string URL);
        public Task<string> consumirPost <T>(string URL, T objeto);
        public Task<string> consumirPut <T>(string URL, T objeto);
        public Task<string> consumirDelete(string URL);
    }
}

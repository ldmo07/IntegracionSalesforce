using Helper.Contrato;

namespace Negocio.Integracion2
{
    public class NegocioIntegracion2 
    {
        private readonly IRestHelper restHelper;
        public NegocioIntegracion2(IRestHelper _restHelper)
        {
            restHelper= _restHelper;
            
        }

        public async void Ejecutar(string url)
        {
            string resultadoGet = await restHelper.consumirGet(url);
        }
    }
}

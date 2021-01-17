using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class IDentranVerificadorPontosCNHService
    {
         Task<IEnumerable<PontosCNH>> ConsultarPontos(CNH cnh);
    }
}
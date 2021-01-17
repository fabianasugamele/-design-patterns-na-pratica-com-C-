using AutoMapper;
using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using DesignPatternSamples.WebAPI.Models;
using DesignPatternSamples.WebAPI.Models.Detran;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers.Detran
{
    [Route("api/Detran/[controller]")]
    [ApiController]
    public class PontosCNHController : ControllerBase 
    {
        private readonly IMapper _Mapper;
        private readonly IDetranVerificadorPontosCNHService _DetranVerificadorPontosCNHServices;

        public PontosCNHController(IMapper mapper, IDetranVerificadorPontosCNHService detranVerificadorPontosCNHServices)
        {
            _Mapper = mapper;
            _DetranVerificadorPontosCNHServices = detranVerificadorPontosCNHServices;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(SuccessResultModel<IEnumerable<PontosCNHModel>>), StatusCodes.Status200OK)]
        public async Task<ActionResult> Get([FromQuery]CNHModel model)
        {
            var pontos = await _DetranVerificadorPontosCNHServices.ConsultarPontos(_Mapper.Map<Veiculo>(model));

            var result = new SuccessResultModel<IEnumerable<PontosCNHModel>>(_Mapper.Map<IEnumerable<PontosCNHModel>>(pontos));

            return Ok(result);
        }
    }


   

}
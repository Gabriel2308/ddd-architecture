using Microsoft.AspNetCore.Mvc;
using projectEntity.Domain.DTO;
using projectEntity.Domain.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Entity.Service.Rest.Controllers
{
    [ApiController]
    [Route("api")]
    public class ClientController : ControllerBase
    {
        private readonly IDepartamentoServices _departamentoService;

        public ClientController(IDepartamentoServices departamentoService)
        {
            _departamentoService = departamentoService;
        }

        [HttpGet("listarDepartamentos")]
        public ActionResult<List<DepartamentoDTO>> ListarDepartamentos()
        {
            try
            {
                var listaDepartamentos = _departamentoService.ListarDepartamentos();
                return Ok(listaDepartamentos);
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}

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
        private readonly IEmployeesServices _employeesService;

        public ClientController(IDepartamentoServices departamentoService, IEmployeesServices employeesServices)
        {
            _departamentoService = departamentoService;
            _employeesService = employeesServices;
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
        [HttpPost("criarDepartamento/{name}/{group}")]
        public ActionResult CriarDepartamento(string name, string group)
        {
            try
            {
                var departamento = _departamentoService.CriarDepartamento(name, group);
                return Ok(departamento);
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("deletarDepartamento/{name}")]
        public ActionResult DeleteDepartamento(string name)
        {
            try
            {
                var dpt = _departamentoService.DeletarDepartamento(name);

                return Ok(dpt);
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("consultarEmpregado/{nationalIdNumber}")]
        public ActionResult ConsultarEmpregado(string nationalIdNumber)
        {
            try
            {
                var emp = _employeesService.ConsultarEmpregado(nationalIdNumber);

                return Ok(emp);
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}

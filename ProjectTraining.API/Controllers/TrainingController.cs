using Microsoft.AspNetCore.Mvc;
using ProjectTraining.Application.Service.Interface;
using ProjectTraining.Application.ViewModel;

namespace ProjectTraining.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController(ITrainingService projectService) : ControllerBase
    {
        [HttpGet("ListAll")]
        public async Task<ActionResult<List<ProjectViewModel_List>>> GetListAll()
        {
            try
            {
                var result = await projectService.GetListAll();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public async Task<ActionResult> Create(ProjectViewModel_Insert input)
        {
            try
            {
                await projectService.Add(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

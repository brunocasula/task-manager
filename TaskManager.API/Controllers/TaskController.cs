using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCase.TaskManager.Create;
using TaskManager.Application.UseCase.TaskManager.Delete;
using TaskManager.Application.UseCase.TaskManager.Get;
using TaskManager.Application.UseCase.TaskManager.GetById;
using TaskManager.Application.UseCase.TaskManager.Update;
using TaskManager.Communication.Collation;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.API.Controllers;

public class TaskController : BaseController
{
    [HttpPost]    
    [ProducesResponseType(typeof(RequestTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTaskJson request)
    {
        var response = new CreateTaskUseCase().Execute(request);
      
        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTaskUseCase();
        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Get(int id)
    {
        var useCase = new GetByIdTaskUseCase();
        var response = useCase.Execute(id);

        if (response != null)
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTaskUseCase();        
        useCase.Execute(id);

        return NoContent();
    }


}

using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class MemberController(DataContext dataContext) : ControllerBase
{   
    private readonly DataContext _dataContext = dataContext;

    public DataContext DataContext => _dataContext;

    [HttpGet]
    public  ActionResult<IEnumerable<Member>> GetMembers()
    {
        return _dataContext.Members;
    }
    [HttpGet("{id:int}", Name = "x")]
    public ActionResult<Member> GetMember(int id)
    {
       
        var member=_dataContext.Members.Find(id);
        if (member == null) return NotFound();
        return Ok(member);
    }

}

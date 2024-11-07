using Microsoft.AspNetCore.Mvc;
using petfriend_api.Database;

namespace petfriend_api.Controllers;

[ApiController]
[Route("[controller]")]
public class OwnerController : ControllerBase
{
    private readonly OwnerProfileCollection _ownerProfileCollection;

    public OwnerController(OwnerProfileCollection ownerProfileCollection)
    {
        _ownerProfileCollection = ownerProfileCollection;
    }

    [HttpGet("/owners")]
    public async Task<IActionResult> GetAllOwners()
    {
        var owners = await _ownerProfileCollection.GetAllOwnersAsync();
        return Ok(owners);
    }
}
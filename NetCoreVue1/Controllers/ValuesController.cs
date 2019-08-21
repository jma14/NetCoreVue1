using Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private IRepositoryWrapper _repoWrapper;

    public ValuesController(IRepositoryWrapper repoWrapper)
    {
        _repoWrapper = repoWrapper;
    }
    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
        var domesticAccounts = _repoWrapper.Account.FindByCondition(x => x.AccountType.Equals("Domestic"));
        var owners = _repoWrapper.Owner.FindAll();

        return new string[] { "value1", "value2" };
    }
}
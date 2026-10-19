using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OdataRESTAPI.Persistence;

namespace OdataRESTAPI.Controllers;

public class ProductsController(OdataDbContext dbContext) : ODataController
{
    [EnableQuery]
    [HttpGet]
    public IActionResult Get()
    {
        var query = dbContext.Products;
        return Ok(query);
    }
}
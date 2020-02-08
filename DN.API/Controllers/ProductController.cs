using DN.Domain.Commands.Product;
using DN.Domain.Services;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace DN.API.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductApplicationService _service;

        public ProductController(IProductApplicationService service)
            => _service = service;

        [HttpPost]
        [Route("api/products")]
        public Task<HttpResponseMessage> Post([FromBody]CreateProductCommand command)
        {
            var product = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, product);
        }

        [HttpPut]
        [Route("api/products")]
        public Task<HttpResponseMessage> Put([FromBody]UpdateProductCommand command)
        {
            var product = _service.Update(command);

            return CreateResponse(HttpStatusCode.OK, product);
        }
    }
}
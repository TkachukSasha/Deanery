using System.Net;

namespace Deanery.Domain.Models.Response
{
    public class CreateResponse
    {
        public string Id { get; set; }
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
    }
}

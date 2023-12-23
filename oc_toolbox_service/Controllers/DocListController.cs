using Microsoft.AspNetCore.Mvc;
using oc_toolbox_service.Models;
using oc_toolbox_service.Services;

namespace oc_toolbox_service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocListController : ControllerBase
    {
        public DocListController(DocListService docListService) =>
            DocListService = docListService;

        public DocListService DocListService { get; }

        [HttpGet]
        //api/DocList?AccessKey=B2C002F1-FA35-4F93-81FB-315D48A9342B
        public DocList Get([FromQuery] string accessKey) => DocListService.GetDocList(accessKey);

        public class DocListRequest
        {
            public string? AccessKey { get; set; }
        }

        [Route("GetByPost")]
        [HttpPost]
        public DocList GetByPost(DocListRequest request)
        {
            var ret = DocListService.GetDocList(request.AccessKey);
            return ret;
        }
    }
}
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
        public DocList Get([FromQuery] string accessKey) => DocListService.GetDocList(accessKey, false);

        public class DocListRequest
        {
            public string? AccessKey { get; set; }
            public bool? InFrench { get; set; }
        }

        [Route("GetByPost")]
        [HttpPost]
        public DocList GetByPost(DocListRequest request)
        {
            var ret = DocListService.GetDocList(request.AccessKey, request.InFrench);
            return ret;
        }

        [Route("DownloadDoc")]
        [HttpGet]
        //api/DocList/DownloadDoc?AccessKey=B2C002F1-FA35-4F93-81FB-315D48A9342B&DocId=2
        public ActionResult DownloadDoc([FromQuery] string accessKey, [FromQuery] int docId)
        {
            DocFile file = DocListService.GetDocFile(accessKey, docId, false);
            return File(file.Content == null ? new byte[] { } : file.Content, file.ContentType == null ? "" : file.ContentType, file.Name);
        }

        public class DownloadDocRequest
        {
            public string? AccessKey { get; set; }
            public int? DocId { get; set; }
            public bool? InFrench { get; set; }
        }

        [Route("DownloadDocByPost")]
        [HttpPost]
        public ActionResult DownloadDocByPost(DownloadDocRequest request)
        {
            DocFile file = DocListService.GetDocFile(request.AccessKey, request.DocId, request.InFrench);
            return File(file.Content == null ? new byte[] { } : file.Content, file.ContentType == null ? "" : file.ContentType, file.Name);
        }
    }
}
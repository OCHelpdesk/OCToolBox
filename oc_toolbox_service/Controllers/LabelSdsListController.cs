using Microsoft.AspNetCore.Mvc;
using oc_toolbox_service.Models;
using oc_toolbox_service.Services;

namespace oc_toolbox_service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LabelSdsListController : ControllerBase
    {
        public LabelSdsListController(LabelSdsListService labelSdsListService) =>
            LabelSdsListService = labelSdsListService;

        public LabelSdsListService LabelSdsListService { get; }

        [HttpGet]
        //api/LabelSdsList?AccessKey=B2C002F1-FA35-4F93-81FB-315D48A9342B
        public LabelSdsProductList Get([FromQuery] string accessKey) => LabelSdsListService.GetLabelSdsProductList(accessKey, false, true);

        public class LabelSdsListRequest
        {
            public string? AccessKey { get; set; }
            public bool? InFrench { get; set; }
            public bool? InPreview { get; set; }
        }

        [Route("GetByPost")]
        [HttpPost]
        public LabelSdsProductList GetByPost(LabelSdsListRequest request)
        {
            var ret = LabelSdsListService.GetLabelSdsProductList(request.AccessKey, request.InFrench, request.InPreview);
            return ret;
        }

        [Route("DownloadDoc")]
        [HttpGet]
        //api/LabelSdsList/DownloadDoc?AccessKey=B2C002F1-FA35-4F93-81FB-315D48A9342B&DocId=2
        public ActionResult DownloadDoc([FromQuery] string accessKey, [FromQuery] int docId, [FromQuery] int inFrench)
        {
            LabelSdsProducDocFile file = LabelSdsListService.GetDocFile(accessKey, docId);
            return File(file.Content == null ? new byte[] { } : file.Content, file.ContentType == null ? "" : file.ContentType, file.Name);
        }
    }
}

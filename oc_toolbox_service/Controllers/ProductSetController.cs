using Microsoft.AspNetCore.Mvc;
using oc_toolbox_service.Models;
using oc_toolbox_service.Services;

namespace oc_toolbox_service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductSetController : ControllerBase
    {
        public ProductSetController(ProductSetService productSetService) =>
            ProductSetService = productSetService;

        public ProductSetService ProductSetService { get; }

        [HttpGet]
        //api/ProductSet?AccessKey=B2C002F1-FA35-4F93-81FB-315D48A9342B
        public ProductSet Get([FromQuery] string accessKey) => ProductSetService.GetProductSet(accessKey, "", false, true);

        public class ProductSetRequest
        {
            public string? AccessKey { get; set; }
            public string? AppSideVersionNumber { get; set; }
            public bool? RequestVersionNumberOnly { get; set; }
            public bool? RequestPreviewVersion { get; set; }
        }

        [Route("GetByPost")]
        [HttpPost]
        public ProductSet GetByPost(ProductSetRequest request)
        {
            var ret = ProductSetService.GetProductSet(
                request.AccessKey,
                request.AppSideVersionNumber,
                request.RequestVersionNumberOnly == null ? false : (bool)request.RequestVersionNumberOnly,
                request.RequestPreviewVersion == null ? false : (bool)request.RequestPreviewVersion
            );
            return ret;
        }
    }
}
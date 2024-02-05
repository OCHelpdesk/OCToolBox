using Microsoft.AspNetCore.Mvc;
using oc_toolbox_service.Models;
using oc_toolbox_service.Services;

namespace oc_toolbox_service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoListController : ControllerBase
    {
        public VideoListController(VideoListService videoListService) =>
            this.VideoListService = videoListService;

        public VideoListService VideoListService { get; }

        [HttpGet]
        //api/VideoList?AccessKey=B2C002F1-FA35-4F93-81FB-315D48A9342B
        public VideoList Get([FromQuery] string accessKey) => VideoListService.GetVideoList(accessKey, false, true);

        public class VideoListRequest
        {
            public string? AccessKey { get; set; }
            public bool? InFrench { get; set; }
            public bool? InPreview { get; set; }
        }

        [Route("GetByPost")]
        [HttpPost]
        public VideoList GetByPost(VideoListRequest request)
        {
            var ret = VideoListService.GetVideoList(request.AccessKey, request.InFrench, request.InPreview);
            return ret;
        }
    }
}
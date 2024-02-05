using oc_toolbox_service.Models;
using System.Data;
using System.Data.SqlClient;

namespace oc_toolbox_service.Services
{
    public class VideoListService : ServiceBase
    {
        public VideoListService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public VideoList GetVideoList(string? accessKey, bool? inFrench, bool? inPreview)
        {
            VideoList ret = new VideoList();
            if (accessKey != ret.AccessKey)
                throw new ArgumentException("Access Key Invalid");
            List<VideoCategory> cats = new List<VideoCategory>();
            List<Video> videos = new List<Video>();
            using (SqlConnection conn = new SqlConnection(OCToolboxDbConnectionString))
            {
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = new SqlCommand();
                adpt.SelectCommand.Connection = conn;
                adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adpt.SelectCommand.CommandText = "VideoList";
                adpt.SelectCommand.Parameters.Add(new SqlParameter("@inFrench", SqlDbType.Bit));
                adpt.SelectCommand.Parameters.Add(new SqlParameter("@forPreview", SqlDbType.Bit));
                adpt.SelectCommand.Parameters[0].Value = inFrench == null || !((bool)inFrench) ? false : true;
                adpt.SelectCommand.Parameters[1].Value = inPreview == null || !((bool)inPreview) ? false : true;
                DataSet tbls = new DataSet();
                adpt.Fill(tbls);
                for (int i = 0; i < tbls.Tables[0].Rows.Count; i++)
                {
                    VideoCategory cat = new VideoCategory();
                    cat.Id = (string)tbls.Tables[0].Rows[i]["CategoryId"];
                    cat.Name = (string)tbls.Tables[0].Rows[i]["Category"];
                    cats.Add(cat);
                }
                for (int i = 0; i < tbls.Tables[1].Rows.Count; i++)
                {
                    Video video = new Video();
                    video.Id = (int)tbls.Tables[1].Rows[i]["VideoId"];
                    video.CategoryId = (int)tbls.Tables[1].Rows[i]["CategoryId"];
                    video.Category = (string)tbls.Tables[1].Rows[i]["Category"];
                    video.SubcategoryId = (int)tbls.Tables[1].Rows[i]["SubcategoryId"];
                    video.Subcategory = (string)tbls.Tables[1].Rows[i]["Subcategory"];
                    video.Name = (string)tbls.Tables[1].Rows[i]["Name"];
                    video.Description = tbls.Tables[1].Rows[i]["Description"].ToString();
                    video.URL = tbls.Tables[1].Rows[i]["URL"].ToString();
                    video.ThumbnailURL = tbls.Tables[1].Rows[i]["ThumbnailURL"].ToString();
                    video.IsPublished = (bool)tbls.Tables[1].Rows[i]["IsPublished"];
                    videos.Add(video);
                }
            }
            ret.VideoCategories = cats.ToArray();
            ret.Videos = videos.ToArray();
            return ret;
        }
    }
}

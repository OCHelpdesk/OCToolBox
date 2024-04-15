using oc_toolbox_service.Models;
using System.Data;
using System.Data.SqlClient;

namespace oc_toolbox_service.Services
{
    public class ProductSetService : ServiceBase
    {
        public ProductSetService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public ProductSet GetProductSet(string? accessKey, string? appSideVersionNumber, bool requestVersionNumberOnly, bool requestPreviewVersion)
        {
            ProductSet ret = requestPreviewVersion ?
                             Models.ProductSetV20240402.ProductSet :
                             Models.ProductSetV20240402.ProductSet;
            if (appSideVersionNumber == ret.Version || requestVersionNumberOnly)
            {
                ret = new ProductSet() { Version = ret.Version };
            }
            if (accessKey != ret.AccessKey)
                throw new ArgumentException("Access Key Invalid");
            List<ServiceRateCard> rateCards = new List<ServiceRateCard>();
            using (SqlConnection conn = new SqlConnection(OCToolboxDbConnectionString))
            {
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = new SqlCommand();
                adpt.SelectCommand.Connection = conn;
                adpt.SelectCommand.CommandText = "SELECT RateCardType, VersionNumber, ImageType, ImageWidth, ImageHeight FROM RateCard";
                DataTable tbl = new DataTable();
                adpt.Fill(tbl);
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    ServiceRateCard card = new ServiceRateCard();
                    card.RateCardType = (string)tbl.Rows[i]["RateCardType"];
                    card.VersionNumber = (string)tbl.Rows[i]["VersionNumber"];
                    card.ImageType = (string)tbl.Rows[i]["ImageType"];
                    card.Width = (int)tbl.Rows[i]["ImageWidth"];
                    card.Height = (int)tbl.Rows[i]["ImageHeight"];
                    rateCards.Add(card);
                }
            }
            ret.ServiceRateCards = rateCards.ToArray();
            return ret;
        }

        public RateCardImage GetRateCardImage(string? accessKey, string rateCardType)
        {
            RateCardImage ret = new RateCardImage();
            if (accessKey != ret.AccessKey)
                throw new ArgumentException("Access Key Invalid");
            using (SqlConnection conn = new SqlConnection(OCToolboxDbConnectionString))
            {
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = new SqlCommand();
                adpt.SelectCommand.Connection = conn;
                adpt.SelectCommand.CommandText = "select ImageData, VersionNumber, ImageType from RateCard where RateCardType='" + rateCardType + "'";
                DataTable tbl = new DataTable();
                adpt.Fill(tbl);
                ret.ImageData = (byte[])tbl.Rows[0]["ImageData"];
                ret.Name = rateCardType + tbl.Rows[0]["VersionNumber"] + "." + tbl.Rows[0]["ImageType"];
            }
            return ret;
        }
    }
}

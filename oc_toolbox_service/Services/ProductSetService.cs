using oc_toolbox_service.Models;

namespace oc_toolbox_service.Services
{
    public class ProductSetService
    {
        public ProductSetService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public ProductSet GetProductSet(string? accessKey, string? appSideVersionNumber, bool requestVersionNumberOnly, bool requestPreviewVersion)
        {
            ProductSet ret = requestPreviewVersion ?
                             Models.ProductSetV20231129.ProductSet :
                             Models.ProductSetV20231129.ProductSet;
            if (appSideVersionNumber == ret.Version || requestVersionNumberOnly)
            {
                ret = new ProductSet() { Version = ret.Version };
            }
            if (accessKey != ret.AccessKey)
                throw new ArgumentException("Access Key Invalid");
            return ret;
        }
    }
}

using oc_toolbox_service.Models;
using System.Data;
using System.Data.SqlClient;

namespace oc_toolbox_service.Services
{
    public class DocListService
    {
        public DocListService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public DocList GetDocList(string? accessKey)
        {
            DocList ret = new DocList();
            if (accessKey != ret.AccessKey)
                throw new ArgumentException("Access Key Invalid");
            List<Doc> docs = new List<Doc>();
            using (SqlConnection conn = new SqlConnection(Database.OCToolboxDbConnectionString))
            {

            }
            ret.Docs = docs.ToArray();
            return ret;
        }
    }
}

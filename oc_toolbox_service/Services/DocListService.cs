using oc_toolbox_service.Models;
using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace oc_toolbox_service.Services
{
    public class DocListService
    {
        public DocListService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public DocList GetDocList(string? accessKey, bool? inFrench)
        {
            DocList ret = new DocList();
            if (accessKey != ret.AccessKey)
                throw new ArgumentException("Access Key Invalid");
            List<Doc> docs = new List<Doc>();
            using (SqlConnection conn = new SqlConnection(Database.OCToolboxDbConnectionString))
            {
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = new SqlCommand();
                adpt.SelectCommand.Connection = conn;
                adpt.SelectCommand.CommandText = @"
select DocId, Category=DocCategoryNameEn, Type=DocType, Name=DocNameEn, Description=DocDescriptionEn, IsPublished
from Doc inner join DocCategory Cat on Doc.DocCategoryId = Cat.DocCategoryId
where Doc.IsDeleted = 0 and DocDataEn is not null
order by DocCategoryNameEn, DocNameEn
";
                if (inFrench != null && (bool)inFrench)
                {
                    adpt.SelectCommand.CommandText = @"
select DocId, Category=DocCategoryNameFr, Type=DocType, Name=DocNameFr, Description=DocDescriptionFr, IsPublished
from Doc inner join DocCategory Cat on Doc.DocCategoryId = Cat.DocCategoryId
where Doc.IsDeleted = 0 and DocDataFr is not null
order by DocCategoryNameFr, DocNameFr
";
                }
                DataTable tbl = new DataTable();
                adpt.Fill(tbl);
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    Doc doc = new Doc();
                    doc.Id = (int)tbl.Rows[i]["DocId"];
                    doc.Category = (string)tbl.Rows[i]["Category"];
                    doc.Type = (string)tbl.Rows[i]["Type"];
                    doc.Name = (string)tbl.Rows[i]["Name"];
                    doc.Description = tbl.Rows[i]["Description"].ToString();
                    doc.IsPublished = (bool)tbl.Rows[i]["IsPublished"];
                    docs.Add(doc);
                }
            }
            ret.Docs = docs.ToArray();
            return ret;
        }
    }
}

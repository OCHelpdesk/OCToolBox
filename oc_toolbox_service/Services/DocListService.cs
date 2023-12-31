using oc_toolbox_service.Models;
using System.Data;
using System.Data.SqlClient;

namespace oc_toolbox_service.Services
{
    public class DocListService : ServiceBase
    {
        public DocListService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public DocList GetDocList(string? accessKey, bool? inFrench, bool? inPreview)
        {
            DocList ret = new DocList();
            if (accessKey != ret.AccessKey)
                throw new ArgumentException("Access Key Invalid");
            List<Doc> docs = new List<Doc>();
            using (SqlConnection conn = new SqlConnection(OCToolboxDbConnectionString))
            {
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = new SqlCommand();
                adpt.SelectCommand.Connection = conn;
                adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adpt.SelectCommand.CommandText = "DocList";
                adpt.SelectCommand.Parameters.Add(new SqlParameter("@inFrench", SqlDbType.Bit));
                adpt.SelectCommand.Parameters.Add(new SqlParameter("@forPreview", SqlDbType.Bit));
                adpt.SelectCommand.Parameters[0].Value = inFrench == null || !((bool)inFrench) ? false : true;
                adpt.SelectCommand.Parameters[1].Value = inPreview == null || !((bool)inPreview) ? false : true;
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
                    doc.DateLastUpdated = tbl.Rows[i]["DateLastUpdated"].ToString();
                    doc.FileName = (string)tbl.Rows[i]["FileName"];
                    doc.SizeKB = (int)tbl.Rows[i]["SizeKB"];
                    doc.IconName = (string)tbl.Rows[i]["IconName"];
                    doc.IconColor = (string)tbl.Rows[i]["IconColor"];
                    doc.IsPublished = (bool)tbl.Rows[i]["IsPublished"];
                    docs.Add(doc);
                }
            }
            ret.Docs = docs.ToArray();
            return ret;
        }

        public DocFile GetDocFile(string? accessKey, int? docId, bool? inFrench)
        {
            DocFile ret = new DocFile();
            if (accessKey != ret.AccessKey)
                throw new ArgumentException("Access Key Invalid");
            using (SqlConnection conn = new SqlConnection(OCToolboxDbConnectionString))
            {
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = new SqlCommand();
                adpt.SelectCommand.Connection = conn;
                adpt.SelectCommand.CommandText = "select DocType, DocNameEn, DocData=DocDataEn from Doc where DocId=" + docId;
                if (inFrench != null && (bool)inFrench)
                {
                    adpt.SelectCommand.CommandText = "select DocType, DocNameEn, DocData=DocDataFr from Doc where DocId=" + docId;
                }
                DataTable tbl = new DataTable();
                adpt.Fill(tbl);
                ret.Id = docId;
                string docType = (string)tbl.Rows[0]["DocType"];
                ret.ContentType = docType.Equals("pdf", StringComparison.OrdinalIgnoreCase) ? "application/pdf" : "application/octet-stream";
                ret.Content = (byte[])tbl.Rows[0]["DocData"];
                ret.Name = ((string)tbl.Rows[0]["DocNameEn"]).Replace("\\", "_").Replace("/", "_") + "." + docType;
            }
            return ret;
        }
    }
}

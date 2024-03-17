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
            List<Category> cats = new List<Category>();
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
                DataSet tbls = new DataSet();
                adpt.Fill(tbls);
                for (int i = 0; i < tbls.Tables[0].Rows.Count; i++)
                {
                    Category cat = new Category();
                    cat.Id = (string)tbls.Tables[0].Rows[i]["CategoryId"];
                    cat.Name = (string)tbls.Tables[0].Rows[i]["Category"];
                    cats.Add(cat);
                }
                for (int i = 0; i < tbls.Tables[1].Rows.Count; i++)
                {
                    Doc doc = new Doc();
                    doc.Id = (int)tbls.Tables[1].Rows[i]["DocId"];
                    doc.CategoryId = (int)tbls.Tables[1].Rows[i]["CategoryId"];
                    doc.Category = (string)tbls.Tables[1].Rows[i]["Category"];
                    doc.SubcategoryId = (int)tbls.Tables[1].Rows[i]["SubcategoryId"];
                    doc.Subcategory = (string)tbls.Tables[1].Rows[i]["Subcategory"];
                    doc.Type = (string)tbls.Tables[1].Rows[i]["Type"];
                    doc.Name = (string)tbls.Tables[1].Rows[i]["Name"];
                    doc.Description = tbls.Tables[1].Rows[i]["Description"].ToString();
                    doc.DateLastUpdated = tbls.Tables[1].Rows[i]["DateLastUpdated"].ToString();
                    doc.FileName = (string)tbls.Tables[1].Rows[i]["FileName"];
                    doc.SizeKB = (int)tbls.Tables[1].Rows[i]["SizeKB"];
                    doc.IconName = (string)tbls.Tables[1].Rows[i]["IconName"];
                    doc.IconColor = (string)tbls.Tables[1].Rows[i]["IconColor"];
                    doc.IsPublished = (bool)tbls.Tables[1].Rows[i]["IsPublished"];
                    docs.Add(doc);
                }
            }
            ret.Categories = cats.ToArray();
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
                adpt.SelectCommand.CommandText = "select DocType=DocTypeEn, DocNameEn, DocData=DocDataEn from Doc where DocId=" + (docId % 1000000);
                if (inFrench != null && (bool)inFrench)
                {
                    adpt.SelectCommand.CommandText = "select DocType=DocTypeFr, DocNameEn, DocData=DocDataFr from Doc where DocId=" + (docId % 1000000);
                }
                DataTable tbl = new DataTable();
                adpt.Fill(tbl);
                ret.Id = docId;
                string docType = (string)tbl.Rows[0]["DocType"];
                ret.ContentType = docType.Equals("pdf", StringComparison.OrdinalIgnoreCase) ? "application/pdf" :
                                  docType.Equals("xlsx", StringComparison.OrdinalIgnoreCase) ? "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" :
                                  docType.Equals("xls", StringComparison.OrdinalIgnoreCase) ? "application/vnd.ms-excel" :
                                  docType.Equals("docx", StringComparison.OrdinalIgnoreCase) ? "application/vnd.openxmlformats-officedocument.wordprocessingml.document" :
                                  docType.Equals("doc", StringComparison.OrdinalIgnoreCase) ? "application/msword" :
                                  "application/octet-stream";
                ret.Content = (byte[])tbl.Rows[0]["DocData"];
                ret.Name = ((string)tbl.Rows[0]["DocNameEn"]).Replace("\\", "_").Replace("/", "_") + "." + docType;
            }
            return ret;
        }
    }
}

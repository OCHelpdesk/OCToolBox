using oc_toolbox_service.Models;
using System.Data;
using System.Data.SqlClient;

namespace oc_toolbox_service.Services
{
    public class LabelSdsListService : ServiceBase
    {
        public LabelSdsListService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public LabelSdsProductList GetLabelSdsProductList(string? accessKey, bool? inFrench, bool? inPreview)
        {
            LabelSdsProductList ret = new LabelSdsProductList();
            if (accessKey != ret.AccessKey)
                throw new ArgumentException("Access Key Invalid");
            List<LabelSdsManufacturer> manufacturers = new List<LabelSdsManufacturer>();
            List<LabelSdsLocation> locations = new List<LabelSdsLocation>();
            List<LabelSdsPesticideClass> pesticideClasses = new List<LabelSdsPesticideClass>();
            List<LabelSdsFormulationType> formulationTypes = new List<LabelSdsFormulationType>();
            List<LabelSdsTargetPest> targetPests = new List<LabelSdsTargetPest>();
            List<LabelSdsProduct> products = new List<LabelSdsProduct>();
            using (SqlConnection conn = new SqlConnection(OCToolboxDbConnectionString))
            {
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = new SqlCommand();
                adpt.SelectCommand.Connection = conn;
                adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adpt.SelectCommand.CommandText = "LabelSdsProductList";
                adpt.SelectCommand.Parameters.Add(new SqlParameter("@inFrench", SqlDbType.Bit));
                adpt.SelectCommand.Parameters.Add(new SqlParameter("@forPreview", SqlDbType.Bit));
                adpt.SelectCommand.Parameters[0].Value = inFrench == null || !((bool)inFrench) ? false : true;
                adpt.SelectCommand.Parameters[1].Value = inPreview == null || !((bool)inPreview) ? false : true;
                DataSet tbls = new DataSet();
                adpt.Fill(tbls);
                int tblIndex = 0;
                for (int i = 0; i < tbls.Tables[tblIndex].Rows.Count; i++)
                {
                    LabelSdsManufacturer item = new LabelSdsManufacturer();
                    item.Id = tbls.Tables[tblIndex].Rows[i]["Id"].ToString();
                    item.Name = tbls.Tables[tblIndex].Rows[i]["Name"].ToString();
                    manufacturers.Add(item);
                }
                tblIndex++;
                for (int i = 0; i < tbls.Tables[tblIndex].Rows.Count; i++)
                {
                    LabelSdsLocation item = new LabelSdsLocation();
                    item.Id = tbls.Tables[tblIndex].Rows[i]["Id"].ToString();
                    item.Name = tbls.Tables[tblIndex].Rows[i]["Name"].ToString();
                    locations.Add(item);
                }
                tblIndex++;
                for (int i = 0; i < tbls.Tables[tblIndex].Rows.Count; i++)
                {
                    LabelSdsPesticideClass item = new LabelSdsPesticideClass();
                    item.Id = tbls.Tables[tblIndex].Rows[i]["Id"].ToString();
                    item.Name = tbls.Tables[tblIndex].Rows[i]["Name"].ToString();
                    pesticideClasses.Add(item);
                }
                tblIndex++;
                for (int i = 0; i < tbls.Tables[tblIndex].Rows.Count; i++)
                {
                    LabelSdsFormulationType item = new LabelSdsFormulationType();
                    item.Id = tbls.Tables[tblIndex].Rows[i]["Id"].ToString();
                    item.Name = tbls.Tables[tblIndex].Rows[i]["Name"].ToString();
                    formulationTypes.Add(item);
                }
                tblIndex++;
                for (int i = 0; i < tbls.Tables[tblIndex].Rows.Count; i++)
                {
                    LabelSdsTargetPest item = new LabelSdsTargetPest();
                    item.Id = tbls.Tables[tblIndex].Rows[i]["Id"].ToString();
                    item.Name = tbls.Tables[tblIndex].Rows[i]["Name"].ToString();
                    targetPests.Add(item);
                }
                tblIndex++;
                for (int i = 0; i < tbls.Tables[tblIndex].Rows.Count; i++)
                {
                    LabelSdsProduct prod = new LabelSdsProduct();
                    DataRow row = tbls.Tables[tblIndex].Rows[i];
                    prod.Id = (int)row["Id"];
                    prod.Name = row["Name"].ToString();
                    prod.Manufacturer = row["Manufacturer"].ToString();
                    prod.PCP = row["PCP"].ToString();
                    prod.RevisionNumber = row["RevisionNumber"].ToString();
                    prod.Ingredient = row["Ingredient"].ToString();
                    prod.LocationId = row["LocationId"].ToString();
                    prod.Location = row["Location"].ToString();
                    prod.PesticideClassId = row["PesticideClassId"].ToString();
                    prod.PesticideClass = row["PesticideClass"].ToString();
                    prod.FormulationTypeId = row["FormulationTypeId"].ToString();
                    prod.FormulationType = row["FormulationType"].ToString();
                    prod.TargetPestIds = row["TargetPestIds"].ToString();
                    prod.TargetPests = row["TargetPests"].ToString();
                    prod.LabelDocId = row["LabelDocId"].ToString();
                    prod.LabelDocName = row["LabelDocName"].ToString();
                    prod.SDSDocId = row["SDSDocId"].ToString();
                    prod.SDSDocName = row["SDSDocName"].ToString();
                    prod.IsPublished = (bool)row["IsPublished"];
                    products.Add(prod);
                }
            }
            ret.Manufacturers = manufacturers.ToArray();
            ret.Locations = locations.ToArray();
            ret.PesticideClasses = pesticideClasses.ToArray();
            ret.FormulationTypes = formulationTypes.ToArray();
            ret.TargetPests = targetPests.ToArray();
            ret.Products = products.ToArray();
            return ret;
        }

        public LabelSdsProducDocFile GetDocFile(string? accessKey, int? docId)
        {
            LabelSdsProducDocFile ret = new LabelSdsProducDocFile();
            if (accessKey != ret.AccessKey)
                throw new ArgumentException("Access Key Invalid");
            using (SqlConnection conn = new SqlConnection(OCToolboxDbConnectionString))
            {
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = new SqlCommand();
                adpt.SelectCommand.Connection = conn;
                adpt.SelectCommand.CommandText = "select DocName, DocData from ProductDoc where ProductDocId=" + docId;
                DataTable tbl = new DataTable();
                adpt.Fill(tbl);
                ret.Id = docId;
                ret.ContentType = "application/octet-stream";
                ret.Content = (byte[])tbl.Rows[0]["DocData"];
                ret.Name = tbl.Rows[0]["DocName"].ToString();
            }
            return ret;
        }
    }
}

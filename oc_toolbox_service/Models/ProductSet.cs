using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace oc_toolbox_service.Models
{
    public class ServiceRateCard
    {
        public string? RateCardType { get; set; }
        public string? VersionNumber { get; set; }
        public string? ImageType { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }
    public class RateCardImage
    {
        [JsonIgnore]
        public string AccessKey { get { return "B2C002F1-FA35-4F93-81FB-315D48A9342B"; } }
        public byte[]? ImageData { get; set; }
        public string? Name { get; set; }
    }

    public class ProductCategory
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? image { get; set; }
        public string[]? subcategories { get; set; }
    }
    public class Product
    {
        public string? Category { get; set; }
        public string? Name { get; set; }
        public string? Vendor { get; set; }
        public string? ProductId { get; set; }
        public string? PCPNum { get; set; }
        public string? UOM { get; set; }
        public string? OrkinUOM { get; set; }
        public double? Price { get; set; }
        public double? OrkinPrice { get; set; }
        public double? PercentOffForNational { get; set; }
    }

    public class ProductSet
    {
        [JsonIgnore]
        public string AccessKey { get { return "B2C002F1-FA35-4F93-81FB-315D48A9342B"; } }

        public string? Version { get; set; }

        public ServiceRateCard[]? ServiceRateCards { get; set; }

        public ProductCategory[]? ProductCategories { get; set; }
        public Product[]? Products { get; set; }
        public ProductCategory[]? ProductCategoriesFr { get; set; }
        public Product[]? ProductsFr { get; set; }

        public string GetJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(
                this,
                new System.Text.Json.JsonSerializerOptions { WriteIndented = true }
            );
        }
    }
}

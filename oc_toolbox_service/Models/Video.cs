using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace oc_toolbox_service.Models
{
    public class VideoCategory
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
    }

    public class Video
    {
        public int? Id { get; set; }
        public int? CategoryId { get; set; }
        public string? Category { get; set; }
        public int? SubcategoryId { get; set; }
        public string? Subcategory { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? URL { get; set; }
        public string? ThumbnailURL { get; set; }
        public bool? IsPublished { get; set; }
    }

    public class VideoList
    {
        [JsonIgnore]
        public string AccessKey { get { return "B2C002F1-FA35-4F93-81FB-315D48A9342B"; } }

        public VideoCategory[]? VideoCategories { get; set; }
        public Video[]? Videos { get; set; }

        public string GetJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(
                this,
                new System.Text.Json.JsonSerializerOptions { WriteIndented = true }
            );
        }
    }
}

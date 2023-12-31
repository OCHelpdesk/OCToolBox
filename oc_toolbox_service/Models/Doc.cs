using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace oc_toolbox_service.Models
{
    public class Doc
    {
        public int? Id { get; set; }
        public string? Category { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? DateLastUpdated { get; set; }
        public string? FileName { get; set; }
        public int? SizeKB { get; set; }
        public string? IconName { get; set; }
        public string? IconColor { get; set; }
        public bool? IsPublished { get; set; }
    }

    public class DocList
    {
        [JsonIgnore]
        public string AccessKey { get { return "B2C002F1-FA35-4F93-81FB-315D48A9342B"; } }

        public Doc[]? Docs { get; set; }

        public string GetJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(
                this,
                new System.Text.Json.JsonSerializerOptions { WriteIndented = true }
            );
        }
    }

    public class DocFile
    {
        [JsonIgnore]
        public string AccessKey { get { return "B2C002F1-FA35-4F93-81FB-315D48A9342B"; } }
        public int? Id { get; set; }
        public byte[]? Content { get; set; }
        public string? ContentType { get; set; }
        public string? Name { get; set; }
    }
}

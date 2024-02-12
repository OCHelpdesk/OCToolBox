using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace oc_toolbox_service.Models
{
    public class LabelSdsLocation
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
    }
    public class LabelSdsPesticideClass
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
    }
    public class LabelSdsFormulationType
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
    }
    public class LabelSdsTargetPest
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
    }

    public class LabelSdsProduct
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public string? PCP { get; set; }
        public string? RevisionNumber { get; set; }
        public string? Ingredient { get; set; }
        public int? LocationId { get; set; }
        public string? Location { get; set; }
        public int? PesticideClassId { get; set; }
        public string? PesticideClass { get; set; }
        public int? FormulationTypeId { get; set; }
        public string? FormulationType { get; set; }
        public string? TargetPestIds { get; set; }
        public string? TargetPests { get; set; }
        public bool? IsPublished { get; set; }
    }

    public class LabelSdsProductList
    {
        [JsonIgnore]
        public string AccessKey { get { return "B2C002F1-FA35-4F93-81FB-315D48A9342B"; } }

        public LabelSdsLocation[]? Locations { get; set; }
        public LabelSdsPesticideClass[]? PesticideClasses { get; set; }
        public LabelSdsFormulationType[]? FormulationTypes { get; set; }
        public LabelSdsTargetPest[]? TargetPests { get; set; }
        public LabelSdsProduct[]? Products { get; set; }

        public string GetJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(
                this,
                new System.Text.Json.JsonSerializerOptions { WriteIndented = true }
            );
        }
    }

    public class LabelSdsProducDocFile
    {
        [JsonIgnore]
        public string AccessKey { get { return "B2C002F1-FA35-4F93-81FB-315D48A9342B"; } }
        public int? Id { get; set; }
        public byte[]? Content { get; set; }
        public string? ContentType { get; set; }
        public string? Name { get; set; }
    }
}

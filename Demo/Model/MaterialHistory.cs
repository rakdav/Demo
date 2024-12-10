using System;
using System.Collections.Generic;

namespace Demo.Model;

public partial class MaterialHistory
{
    public int? IdMaterialHistory { get; set; }

    public int? IdMaterial { get; set; }

    public string? Operation { get; set; }

    public int? Count { get; set; }
}

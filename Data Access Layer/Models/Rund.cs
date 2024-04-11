using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models;

public partial class Rund
{
    public int Seqrund { get; set; }

    public string Codslachthuis { get; set; } = null!;

    public string Weegnr { get; set; } = null!;

    public DateTime Datgeslacht { get; set; }

    public int Filenr { get; set; }

    public string Codveebeslag { get; set; } = null!;

    public string Codlandbeslag { get; set; } = null!;

    public string Codlandofwn { get; set; } = null!;

    public string Oormerk { get; set; } = null!;

    public string? Codgeslacht { get; set; }

    public string? Codland { get; set; }

    public int? Lotnr { get; set; }

    public DateTime? Datgeboorte { get; set; }

    public string? Codlandofgeboorte { get; set; }

    public int? Fileseq { get; set; }

    public int? Fileupdnr { get; set; }

    public DateTime Credat { get; set; }

    public DateTime Upddat { get; set; }

    public string? Creusr { get; set; }

    public string? Updusr { get; set; }

    public string Verzenden { get; set; } = null!;

    public string Tonen { get; set; } = null!;

    public string? Btwnrbestemmeling { get; set; }

    public string? Codgroothandel { get; set; }

    public string? Codleverancier { get; set; }

    public float? Seqlot { get; set; }
}

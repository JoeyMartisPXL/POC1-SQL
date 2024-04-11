using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models;

public partial class Varken
{
    public int Seqvarken { get; set; }

    public string Codslachthuis { get; set; } = null!;

    public string Codveebeslag { get; set; } = null!;

    public short Filenr { get; set; }

    public string Verzenden { get; set; } = null!;

    public string Tonen { get; set; } = null!;

    public string Weegnr { get; set; } = null!;

    public DateTime Datgeslacht { get; set; }

    public string Codlandbeslag { get; set; } = null!;

    public string Klophamer { get; set; } = null!;

    public string? Oormerk { get; set; }

    public string? Codgeslacht { get; set; }

    public int? Fileseq { get; set; }

    public short? Fileupdnr { get; set; }

    public DateTime Credat { get; set; }

    public DateTime Upddat { get; set; }

    public string? Creusr { get; set; }

    public string? Updusr { get; set; }

    public string? Codleverancier { get; set; }

    public decimal? OperKlant { get; set; }

    public decimal? Seqlot { get; set; }

    public int? Lotnr { get; set; }
}

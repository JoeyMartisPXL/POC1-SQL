using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models;

public partial class Metingrund
{
    public int Seqmeting { get; set; }

    public int Seqrund { get; set; }

    public string Codclass { get; set; } = null!;

    public float Tarra { get; set; }

    public float Warmgewicht { get; set; }

    public float? Omgwarmgewicht { get; set; }

    public string Codcat { get; set; } = null!;

    public string Codbevklasse { get; set; } = null!;

    public string? Codbevsubklasse { get; set; }

    public string Codvetklasse { get; set; } = null!;

    public string? Codvetsubklasse { get; set; }

    public bool? Codlbh { get; set; }

    public byte? Codabdvorm { get; set; }

    public byte? Codonvkar { get; set; }

    public byte? Codgeenmet { get; set; }

    public byte? Codasynchmet { get; set; }

    public string? Codsankwal { get; set; }

    public float? Malsheid { get; set; }

    public string? Reflexie { get; set; }

    public int? Klantnr { get; set; }

    public int? Levgewicht { get; set; }

    public string? Etiketnr { get; set; }

    public DateTime Credat { get; set; }

    public DateTime Upddat { get; set; }

    public string? Creusr { get; set; }

    public string? Updusr { get; set; }

    public byte? Karkasgroei { get; set; }

    public string? Codidentificatieletter { get; set; }

    public string? Dnacode { get; set; }

    public byte? Codasynchmed { get; set; }

    public string? Reinheid { get; set; }

    public string? Reserve1 { get; set; }

    public string? Reserve2 { get; set; }

    public float? Levendgewicht { get; set; }

    public string? IdWeegtoestel { get; set; }

    public string? UniekIdArsGew1 { get; set; }

    public string? UniekIdArsGew2 { get; set; }

    public string? UniekIdArsInd { get; set; }

    public string? Reserve3 { get; set; }

    public string? Reserve4 { get; set; }

    public string? Reserve5 { get; set; }

    public string? Reserve6 { get; set; }
}

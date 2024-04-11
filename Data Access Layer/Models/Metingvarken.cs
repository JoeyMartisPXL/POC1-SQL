using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models;

public partial class Metingvarken
{
    public int Seqmeting { get; set; }

    public int Seqvarken { get; set; }

    public byte? Codabdvorm { get; set; }

    public string Codclass1 { get; set; } = null!;

    public string? UniekIdArsInd { get; set; }

    public float Tarra { get; set; }

    public float Warmgewicht { get; set; }

    public float? X1 { get; set; }

    public float? X2 { get; set; }

    public float Germagvls { get; set; }

    public float? Germagvlsber { get; set; }

    public byte? GeenMetingFysio { get; set; }

    public byte? Codasynchmet { get; set; }

    public byte? GeenMetingTechno { get; set; }

    public byte? Codinvgewmet { get; set; }

    public string? Codsankwal { get; set; }

    public byte? Codonvkar { get; set; }

    public bool? Codlbh { get; set; }

    public int? Seqapp1 { get; set; }

    public int? Seqapp2 { get; set; }

    public float? Tssribwaarde { get; set; }

    public float? X3totalewaarde { get; set; }

    public float? X1eersteprik { get; set; }

    public byte? Basispse { get; set; }

    public byte? Indicatiepse { get; set; }

    public float? Reflexie { get; set; }

    public float? Hamhoek { get; set; }

    public byte? Maxbreedteham { get; set; }

    public float? Typegetal { get; set; }

    public float? Typegetalber { get; set; }

    public byte? Comklas { get; set; }

    public string? Comklasman { get; set; }

    public string? Individueelnr { get; set; }

    public int? Klantnr { get; set; }

    public string? Levgewicht { get; set; }

    public string? Alarm1 { get; set; }

    public string? Alarm2 { get; set; }

    public string? Alarm3 { get; set; }

    public DateTime Credat { get; set; }

    public DateTime Upddat { get; set; }

    public string? Creusr { get; set; }

    public string? Updusr { get; set; }

    public float? Germagvlsberint { get; set; }

    public byte? Asynchmet { get; set; }

    public string? Codimpgewmet { get; set; }

    public byte? Comclass { get; set; }

    public string? Comclassman { get; set; }

    public string? IdWeegtoestel { get; set; }

    public string? UniekIdArsGew { get; set; }

    public string? IdIndtoestel { get; set; }

    public string? Reserve1 { get; set; }

    public string? Reserve2 { get; set; }

    public string? Reserve3 { get; set; }

    public string? Reserve4 { get; set; }

    public string? Reserve5 { get; set; }

    public string? Reserve6 { get; set; }

    public string? Reserve7 { get; set; }

    public string? Reserve8 { get; set; }

    public string? Reserve9 { get; set; }

    public string? Reserve10 { get; set; }
}

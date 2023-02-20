namespace Brauser.Common.Import;

/// <summary>
///     Json export of a recipe from the german site <see cref="https://www.maischemalzundmehr.de/" />
/// </summary>
public record MaischeMalzUndMehrRecipe
{
    public string? Name { get; set; }
    public string? Datum { get; set; }

    public string? Sorte { get; set; }

    public int? Ausschlagswuerze { get; set; }
    public int? Sudhausausbeute { get; set; }

    public int? Stammwuerze { get; set; }
    public int? Bittere { get; set; }
    public string? Farbe { get; set; }
    public double? Alkohol { get; set; }
    public string? Kurzbeschreibung { get; set; }
    public int? Infusion_Hauptguss { get; set; }
    public string? Malz1 { get; set; }
    public double? Malz1_Menge { get; set; }
    public string? Malz1_Einheit { get; set; }
    public string? Malz2 { get; set; }
    public double? Malz2_Menge { get; set; }
    public string? Malz2_Einheit { get; set; }
    public string? Malz3 { get; set; }
    public double? Malz3_Menge { get; set; }
    public string? Malz3_Einheit { get; set; }
    public string? Maischform { get; set; }
    public double? Infusion_Einmaischtemperatur { get; set; }
    public string? Infusion_Rasttemperatur1 { get; set; }
    public string? Infusion_Rastzeit1 { get; set; }
    public string? Infusion_Rasttemperatur2 { get; set; }
    public string? Infusion_Rastzeit2 { get; set; }
    public string? Infusion_Rasttemperatur3 { get; set; }
    public string? Infusion_Rastzeit3 { get; set; }
    public string? Abmaischtemperatur { get; set; }
    public int? Nachguss { get; set; }
    public string? Kochzeit_Wuerze { get; set; }
    public string? Hopfen_VWH_1_Sorte { get; set; }
    public int? Hopfen_VWH_1_Menge { get; set; }
    public int? Hopfen_VWH_1_alpha { get; set; }
    public string? Hopfen_1_Sorte { get; set; }
    public int? Hopfen_1_Menge { get; set; }
    public int? Hopfen_1_alpha { get; set; }
    public string? Hopfen_1_Kochzeit { get; set; }
    public string? Hopfen_2_Sorte { get; set; }
    public int? Hopfen_2_Menge { get; set; }
    public int? Hopfen_2_alpha { get; set; }
    public string? Hopfen_2_Kochzeit { get; set; }
    public string? Hefe { get; set; }
    public string? Gaertemperatur { get; set; }
    public string? Endvergaerungsgrad { get; set; }
    public string? Karbonisierung { get; set; }
    public string? Anmerkung_Autor { get; set; }
}
namespace BlazorExpress.UI.Configuration;

public sealed class LibraryVersionsOptions
{
    public const string SectionName = "LibraryVersions";

    public string ChartJs { get; set; } = string.Empty;

    public string Bulma { get; set; } = string.Empty;
}
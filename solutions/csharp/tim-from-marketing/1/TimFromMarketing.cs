using System.Data.Common;

static class Badge
{
    public static string Print(int? id, string name, string? department)        => $"{(id is null ? "" : $"[{id}] - ")}{name} - {(department ?? "OWNER").ToUpper()}" ;
}
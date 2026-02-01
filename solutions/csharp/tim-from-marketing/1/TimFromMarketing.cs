static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        department = department?.ToUpper();
        string badge = $"[{id}] - {name} - {department}";

        return id switch
        {
            null when department != null => $"{id}{name} - {department}",
            null when department == null => $"{id}{name} - OWNER",
            _ => department == null ? $"[{id}] - {name} - OWNER" 
                : badge
        };
    }
}

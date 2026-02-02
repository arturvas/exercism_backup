public static class ResistorColorDuo
{
    private static readonly string[] ColorsStrings = 
        ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
    
    public static int Value(string[] colors) => 
        Array.IndexOf(ColorsStrings, colors[0]) * 10 + Array.IndexOf(ColorsStrings, colors[1]);
}
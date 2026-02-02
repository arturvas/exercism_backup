namespace ResistorColorDuo;

public static class ResistorColorDuo
{
    private static readonly string[] Colors = 
        ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
    
    public static int Value(string[] colors)
    {
        string color1 = (Array.IndexOf(Colors, colors[0]).ToString());
        string color2 = (Array.IndexOf(Colors, colors[1]).ToString());
        
        return int.Parse(color1+color2);
    }
}
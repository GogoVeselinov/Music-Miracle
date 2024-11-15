namespace MusicTask{
    public class Pop : Song
{
    private string _genre;
    private bool _isInTop100;

    public Pop(string title, string artist, string album ,double duration, string releaseDate, string genre, bool isInTop100): base(title, artist, album, duration, releaseDate)
    {
        _genre = genre;
        _isInTop100 = isInTop100;
    }

    public string Genre
    {
        get { return _genre; }
        set { _genre = value; }
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Genre: Pop, Title: {Title}, Duration: {Duration}, Artist: {Artist}, In Top 100: {_isInTop100}, Release Date: {RealiseDate}");
    }
}
}
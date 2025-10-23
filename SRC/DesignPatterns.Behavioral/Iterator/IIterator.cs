namespace DesignPatterns.Behavioral.Iterator;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}


public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}

public class Song
{
    public string Title { get; }

    public Song(string title)
    {
        Title = title;
    }

    public override string ToString() => Title;
}


public class Playlist : IAggregate<Song>
{
    private readonly List<Song> _songs = new();

    public void AddSong(Song song) => _songs.Add(song);

    public IIterator<Song> CreateIterator() => new PlaylistIterator(this);

    public Song Get(int index) => _songs[index];
    public int Count => _songs.Count;
}
public class PlaylistIterator : IIterator<Song>
{
    private readonly Playlist _playlist;
    private int _position = 0;

    public PlaylistIterator(Playlist playlist)
    {
        _playlist = playlist;
    }

    public bool HasNext() => _position < _playlist.Count;

    public Song Next()
    {
        return _playlist.Get(_position++);
    }
}
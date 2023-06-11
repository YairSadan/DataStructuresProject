namespace DataStructuresProject;
public class Box
{
    private int _count;
    private double _height;
    private double _width;
    private static int _counter = 0;
    public int Id { get; private set; }
    public double Height { get => _height; set { _height = value; _height = _height < 0 ? 0 : _height; } }
    public double Width { get => _width; set { _width = value; _width = _width < 0 ? 0 : _width; } }
    public bool IsDeleted { get; private set; }
    public DateTime LastTimePurchased { get; set; }
    public int Count
    {
        get => _count;
        set
        {
            _count = value;
            IsDeleted = _count <= 0;
            _count = IsDeleted ? 0 : _count;
        }
    }

    public Box()
    {
        Id = _counter++;
        IsDeleted = false;
        Count = 1;
        LastTimePurchased = DateTime.Now;
    }
    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;
        return (Height == ((Box)obj).Height && Width == ((Box)obj).Width);
    }
}
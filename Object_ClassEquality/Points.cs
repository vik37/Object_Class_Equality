namespace Object_ClassEquality;

public class PointC : IEquatable<PointC>
{
    public int X { get; init; }
    public int Y { get; init; }

    public bool Equals(PointC other)
    {
        Console.WriteLine("Calling Equals");
        return other != null && this.GetType() == other.GetType() && X == other.X && Y == other.Y;
    }

    public override bool Equals(object obj)
    {
        Console.WriteLine("Calling Ovverride Equals");
        return Equals(obj as PointC);
    }

    //public override int GetHashCode()
    //{
    //    var a = X ^ Y; 
    //    return X ^ Y;
    //}

    //public override int GetHashCode()
    //{
    //    return HashCode.Combine(X, Y);
    //}

    public override int GetHashCode()
    {
        Console.WriteLine("Calling Get Hash Code");

        HashCode hash = new();
        hash.Add(X);
        hash.Add(Y);
        return hash.ToHashCode();
    }
}

public struct PointS
{
    public int X { get; init; }
    public int Y { get; init; }

    public static bool operator ==(PointS psl, PointS psr) => psl.Equals(psr);

    public static bool operator !=(PointS psl, PointS psr) => !(psr == psl);
}

public record PointR
{
    public int X { get; init; }
    public int Y { get; init; }
}

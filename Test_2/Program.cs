public interface IShape
{
}

public class Circle : IShape
{
}

public class Rectangle : IShape
{
}

public class RoundedRectangle : IShape
{
}

public class IntersectionFinder
{
    public IShape FindIntersection(IShape shape, IShape shape2)
    {
        if (shape is Circle && shape2 is Rectangle)
            return FindIntersection(shape as Circle, shape2 as Rectangle);

        if (shape is Circle && shape2 is RoundedRectangle)
            return FindIntersection(shape as Circle, shape2 as RoundedRectangle);

        if (shape is RoundedRectangle && shape2 is Rectangle)
            return FindIntersection(shape as RoundedRectangle, shape2 as Rectangle);

        return FindIntersection(shape2, shape);
    }

    private IShape FindIntersection(Circle circle, Rectangle rectangle)
    {
        return new RoundedRectangle(); //также код мог бы вернуть Rectangle или Circle, в зависимости от их размеров. Но для простоты будем считать что метод всегда возвращает RoundedRectangle
    }

    private IShape FindIntersection(Circle circle, RoundedRectangle rounedeRectangle)
    {
        return new Circle();
    }

    private IShape FindIntersection(RoundedRectangle roundedRectanglerectangle, Rectangle rectangle)
    {
        return new Rectangle();
    }
}


Rectangle rect = new Square();
TestRectangleArea(rect);


Console.ReadLine();

static void TestRectangleArea(Rectangle rect)
{
    rect.Height = 5;
    rect.Width = 10;
    if (rect.GetArea() != 50)
        throw new Exception("Некорректная площадь!");
}

class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}


class Square : Rectangle
{
    public override int Width
    {
        get
        {
            return base.Width;
        }

        set
        {
            base.Width = value;
            base.Height = value;
        }
    }

    public override int Height
    {
        get
        {
            return base.Height;
        }

        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
}




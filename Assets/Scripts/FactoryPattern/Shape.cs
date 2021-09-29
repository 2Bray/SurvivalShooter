using UnityEngine;


public interface Shape
{
    void Draw();
}

public class Rectangle : Shape
{
    public void Draw()
    {

        Debug.Log("Inside Rectangle Draw() method");

    }

}

public class Square : Shape
{
    public void Draw()
    {

        Debug.Log("Inside Square Draw() method");

    }

}

public class Circle : Shape
{
    public void Draw()
    {

        Debug.Log("Inside Circle Draw() method");

    }

}

public class ShapeFactory
{

    //use getShape method to get object of type shape 
    public Shape getShape(string shapeType)
    {
        if (shapeType == null)
        {
            return null;
        }

        shapeType = shapeType.ToLower();
        if (shapeType=="circle")
        {
            return new Circle();

        }
        else if (shapeType=="rectangle")
        {
            return new Rectangle();

        }
        else if (shapeType=="square")
        {
            return new Square();
        }

        return null;
    }
}
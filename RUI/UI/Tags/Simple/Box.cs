using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace RUI.UI.Tags.Simple;

public class Box : Tag
{
    public Canvas Canvas { get; set; }
    public Vector2 Origin { get; set; }
    public float PercentWidth { get; set; }
    public float PercentHeight { get; set; }

    public Color backgroundColor { get; set; }
    public Color borderColor { get; set; }
    public float borderWidth { get; set; }
    public float borderRadius { get; set; }
    public int edgeRoundness { get; set; }

    public Box()
    {
        PercentHeight = 1;
        PercentWidth = 1;
        Origin = new Vector2(0, 0);
    }
    
    public void TestDraw()
    {
        //Transform that the object in the canvas space
        var width = (Canvas.ScreenPercentW * GetScreenWidth()) * PercentWidth;
        var height = (Canvas.ScreenPercentH * GetScreenHeight()) * PercentHeight;
        
        //So that when the origin is 0,0 it is on the canvas origin
        var x = Canvas.Origin.X * GetScreenWidth();
        var y = Canvas.Origin.Y * GetScreenHeight();
        
        // Move the x,y to the origin (wich is the percentage of the width and height of the canvas)
        x += Origin.X * (Canvas.ScreenPercentW * GetScreenWidth());
        y += Origin.Y * (Canvas.ScreenPercentH * GetScreenHeight());

        //Draw the box
        DrawRectangle((int)x, (int)y, (int)width, (int)height, backgroundColor);
        
        //Draw the origin
        DrawCircle((int)x, (int)y, 5, Color.GREEN);
    }

    public void Draw()
    {
        //Transform that the object in the canvas space
        var width = (Canvas.ScreenPercentW * GetScreenWidth()) * PercentWidth;
        var height = (Canvas.ScreenPercentH * GetScreenHeight()) * PercentHeight;
        
        //So that when the origin is 0,0 it is on the canvas origin
        var x = Canvas.Origin.X * GetScreenWidth();
        var y = Canvas.Origin.Y * GetScreenHeight();
        
        // Move the x,y to the origin (wich is the percentage of the width and height of the canvas)
        x += Origin.X * (Canvas.ScreenPercentW * GetScreenWidth());
        y += Origin.Y * (Canvas.ScreenPercentH * GetScreenHeight());

        //Draw the box with the border
        DrawRectangleRounded(new Rectangle(x, y, width, height), borderRadius, edgeRoundness, backgroundColor);
    }
}
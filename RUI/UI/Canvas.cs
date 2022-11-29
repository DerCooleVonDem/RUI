using System.Numerics;
using Raylib_cs;
using RUI.UI.Tags;
using static Raylib_cs.Raylib;

namespace RUI.UI;

public class Canvas
{
    
    public Vector2 Origin { get; set; }
    public float ScreenPercentW { get; set; }
    public float ScreenPercentH { get; set; }
    
    public bool TestMode { get; set; }
    
    public List<Tag> Tags { get; set; }

    public Canvas(float screenPercentW = 1.0f, float screenPercentH = 1.0f, Vector2 origin = default)
    {
        Origin = origin;
        ScreenPercentW = screenPercentW;
        ScreenPercentH = screenPercentH;
        Tags = new List<Tag>();
    }

    public void InitTag(Tag tag)
    {
        tag.Canvas = this;
        Tags.Add(tag);
    }
    
    public void Update()
    {
        
    }
    
    public void Draw()
    {
        foreach (var tag in Tags)
        {
            if (TestMode)
            {
                tag.TestDraw();
            }
            else
            {
                tag.Draw();
            }
        }
    }

    public void Test()
    {
        int screenWidth = GetScreenWidth();
        int screenHeight = GetScreenHeight();
        
        int width = (int)(screenWidth * ScreenPercentW);
        int height = (int)(screenHeight * ScreenPercentH);

        int x = (int)(screenWidth * Origin.X);
        int y = (int)(screenHeight * Origin.Y);
        
        DrawRectangle(x, y, width, height, Color.RED);
        
        //Draw a Line Rectangle in green
        DrawRectangleLines(x, y, width, height, Color.GREEN);
        
        //Draw a dot for the origin
        DrawCircle(x, y, 5, Color.BLUE);
    }

}
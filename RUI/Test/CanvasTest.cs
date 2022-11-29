using System.Numerics;
using Raylib_cs;
using RUI.UI;
using RUI.UI.Tags.Simple;
using static Raylib_cs.Raylib;

namespace RUI.Test;

public class CanvasTest
{

    public static void Run()
    {
        
        SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE);
        InitWindow(1080, 720, "Canvas Test - RUI");

        Canvas canvas = new Canvas(.9f, 0.1f);
        canvas.Origin = new Vector2(0.05f, .9f);
        canvas.TestMode = false;
        
        var box = new Box();
        box.backgroundColor = Color.WHITE;
        box.PercentWidth = .1f;
        box.PercentHeight = 1f;
        box.Origin = new Vector2(0.05f, 0f);
        box.borderRadius = .1f;
        box.edgeRoundness = 3;
        canvas.InitTag(box);
        
        var box2 = new Box();
        box2.backgroundColor = Color.WHITE;
        box2.PercentWidth = .1f;
        box2.PercentHeight = 1f;
        box2.Origin = new Vector2(0.2f, 0f);
        box2.borderRadius = .1f;
        box2.edgeRoundness = 3;
        canvas.InitTag(box2);
        
        var box3 = new Box();
        box3.backgroundColor = Color.WHITE;
        box3.PercentWidth = .1f;
        box3.PercentHeight = 1f;
        box3.Origin = new Vector2(0.35f, 0f);
        box3.borderRadius = .1f;
        box3.edgeRoundness = 3;
        canvas.InitTag(box3);

        while (!WindowShouldClose())
        {
            
            canvas.Update();
            
            ClearBackground(Color.BLACK);
            BeginDrawing();
            
            canvas.Draw();
            
            EndDrawing();
        }
    }
    
}
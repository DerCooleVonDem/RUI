using System.Drawing;
using System.Numerics;

namespace RUI.UI.Tags;

public interface Tag
{
    public Canvas Canvas { get; set; }
    public Vector2 Origin { get; set; }
    public float PercentWidth { get; set; }
    public float PercentHeight { get; set; }

    public void TestDraw();
    public void Draw();
}
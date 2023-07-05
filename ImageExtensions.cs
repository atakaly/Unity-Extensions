using UnityEngine;
using UnityEngine.UI;

public static class ImageExtensions
{
    public static void Fade(this Image img, float value)
    {
        Color col = img.color;
        col.a = value;
        img.color = col;
    }
}

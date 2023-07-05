using UnityEngine;

public static class FloatExtensions
{
    public static float Remap(this float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    public static float RotationNormalizedDeg(this float rotation)
    {
        rotation = rotation % 360f;
        if (rotation < 0)
            rotation += 360f;
        return rotation;
    }

    public static float RotationNormalizedRad(this float rotation)
    {
        rotation = rotation % Mathf.PI;
        if (rotation < 0)
            rotation += Mathf.PI;
        return rotation;
    }
}

using UnityEngine;

public static class RigidbodyExtensions
{
    public static void Freeze(this Rigidbody2D rigidbody2D)
    {
        rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.angularVelocity = 0;
        rigidbody2D.isKinematic = true;
    }

    public static void Freeze(this Rigidbody rigidbody)
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.angularVelocity = Vector2.zero;
        rigidbody.isKinematic = true;
    }
}

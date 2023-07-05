using UnityEngine;

public static class GameObjectExtensions
{
    public static T GetOrAddComponent<T>(this GameObject gameObject) where T : MonoBehaviour
    {
        var component = gameObject.GetComponent<T>();
        if (component == null) gameObject.AddComponent<T>();
        return component;
    }

    public static bool HasComponent<T>(this GameObject gameObject) where T : MonoBehaviour
    {
        return gameObject.GetComponent<T>() != null;
    }

    public static void DestroyChildren(this GameObject parent)
    {
        Transform[] children = new Transform[parent.transform.childCount];
        for (int i = 0; i < parent.transform.childCount; i++)
            children[i] = parent.transform.GetChild(i);
        for (int i = 0; i < children.Length; i++)
            GameObject.Destroy(children[i].gameObject);
    }
}

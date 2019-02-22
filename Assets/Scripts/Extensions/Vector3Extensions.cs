using UnityEngine;

public static class Vector3Extensions
{
    public static Vector3 With(this Vector3 original, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? original.x, y ?? original.y, z ?? original.z);
    }

    public static Vector3 Add(this Vector3 original, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(original.x + x ?? original.x, original.y + y ?? original.y, original.z + z ?? original.z);
    }
}
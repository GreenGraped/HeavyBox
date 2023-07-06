using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public static Functions f = new Functions();
    public Vector2 V3toV2(Vector3 vector)
    {
        return new Vector2(vector.x, vector.y);
    }
    public Vector2 V2toV3(Vector2 vector, float z)
    {
        return new Vector3(vector.x, vector.y, z);
    }
}

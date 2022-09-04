using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float zBound = -10f;

    void Update()
    {
        if (transform.position.z < zBound)
        {
            Destroy(gameObject);
        }
    }
}

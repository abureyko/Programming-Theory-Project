using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatGround : MonoBehaviour
{
    public float RepeatLength { get; private set; } // ENCAPSULATION
    private Vector3 startPos;
    
    void Start()
    {
        startPos = transform.position;
        RepeatLength = startPos.z / 2;
    }

    void Update()
    {
        if (!GameManager.Instance.gameOver)
        {
            ResetPosition(); 
        }
    }

    void ResetPosition()
    {
        if (transform.position.z < RepeatLength)
        {
            transform.position = startPos;
        }
    }
}

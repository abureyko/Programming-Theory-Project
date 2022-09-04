using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enviroment : Movement
{
    private float speed;
    protected override void MoveBack() 
    {
        speed = 20;

        if (!GameManager.Instance.gameOver)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.back);
        }
    }

    private void Update()
    {
        MoveBack();
    }
}

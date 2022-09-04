using UnityEngine;

public class Animal : Movement //INHERITANCE
{
    private float speed;
    protected override void MoveBack() //POLYMORPHISM
    {
        speed = 15;

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

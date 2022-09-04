using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator playerAnim;
    private Rigidbody playerRb;
    private bool isOnTheGround = true;
    private float speed = 15;
    private float jumpForce = 10;
    private float yBound = -1;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        //ABSTRACTION
        CheckBounds();
        SideMovement();     
        Jump();
    }

    void SideMovement()
    {
        if (!GameManager.Instance.gameOver)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround  && !GameManager.Instance.gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            playerAnim.SetTrigger("Jump_trig");
            isOnTheGround = false;
        }
    }

    void CheckBounds()
    {
        if (transform.position.y < yBound)
        {
            GameManager.Instance.gameOver = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnTheGround = true;
        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            GameManager.Instance.gameOver = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Animal"))
        {
            ScoreManager.Instance.AddPoint();
            Destroy(other.gameObject);
        }
    }
}

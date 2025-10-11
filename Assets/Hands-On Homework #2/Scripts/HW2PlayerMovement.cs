using UnityEngine;

public class HW2PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private float xSpeed;
    private float ySpeed;

    public float Speed = 3;  

    private string InputX = "Horizontal";
    private string InputY = "Vertical";
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        xSpeed = Input.GetAxis(InputX);
        ySpeed = Input.GetAxis(InputY);

        _rigidbody2D.velocity = new Vector2(xSpeed, ySpeed);
    }
}

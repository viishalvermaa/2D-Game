using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce =1;

    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            _rigidbody.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }
}

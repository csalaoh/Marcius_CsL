using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;

    void Start()
    {
        Vector3 p = transform.position;
        p.y = 0;
        transform.position = p;
    }
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(hInput, 0, vInput);

        Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime;
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float angularVelocity = 100;
    [SerializeField] Transform cameaTransform;

    void Start()
    {
        Vector3 p = transform.position;
        p.y = 0;
        transform.position = p;
    }
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal"); // V�zszintes bemenet
        float vInput = Input.GetAxisRaw("Vertical"); // F�gg�leges bemenet

        Vector3 cameraRight = cameaTransform.right * vInput;
        Vector3 cameraForward = cameaTransform.forward * hInput;

        cameraForward.y = 0;
        cameraForward.Normalize();
        Vector3 direction = cameraRight + cameraForward;


        direction.Normalize(); // Ir�ny normaiz�l�sa

        Vector3 velocity = direction * speed; // Sebess�g vektor
        transform.position += velocity * Time.deltaTime;  //Poz�ci� friss�t�se

        if (direction != Vector3.zero)
   
        {
            Quaternion targetRotaion = Quaternion.LookRotation(direction);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotaion, angularVelocity * Time.deltaTime);
        }
    }
}

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
        float hInput = Input.GetAxisRaw("Horizontal"); // Vízszintes bemenet
        float vInput = Input.GetAxisRaw("Vertical"); // Függõleges bemenet

        Vector3 cameraRight = cameaTransform.right * vInput;
        Vector3 cameraForward = cameaTransform.forward * hInput;

        cameraForward.y = 0;
        cameraForward.Normalize();
        Vector3 direction = cameraRight + cameraForward;


        direction.Normalize(); // Irány normaizálása

        Vector3 velocity = direction * speed; // Sebesség vektor
        transform.position += velocity * Time.deltaTime;  //Pozíció frissítése

        if (direction != Vector3.zero)
   
        {
            Quaternion targetRotaion = Quaternion.LookRotation(direction);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotaion, angularVelocity * Time.deltaTime);
        }
    }
}

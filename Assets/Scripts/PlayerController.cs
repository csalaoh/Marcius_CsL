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
        float hInput = Input.GetAxisRaw("Horizontal"); // nyers adat
        float vInput = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(hInput, 0, vInput);

        Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime;
    }

    public int CountOfDividers(int n)
    {
        int darab = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                darab++;
                Debug.Log(i);
            }
        }
        return darab;
    }
}

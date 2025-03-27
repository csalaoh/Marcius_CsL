using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField] Vector3 axis = Vector3.up;
    [SerializeField] float angularSpeed;

    void Update()
    {
        transform.Rotate(axis, angularSpeed * Time.deltaTime);  
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position + axis, transform.position - axis);
    }
}

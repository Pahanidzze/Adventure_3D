using UnityEngine;

public class RotateTo : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private Vector3 Target;

    public void Update()
    {
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(Target), Speed * Time.deltaTime);
        if (transform.localRotation == Quaternion.Euler(Target)) enabled = false;
    }
}

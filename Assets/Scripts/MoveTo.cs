using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] Transform Target;

    private void Update()
    {
        if (Target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
            if (transform.position == Target.position) enabled = false;
        }
    }
}

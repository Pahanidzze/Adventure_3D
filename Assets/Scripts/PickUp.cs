using UnityEngine;
using SimpleFPS;

public class PickUp : MonoBehaviour
{
    protected virtual bool OnTriggerEnter(Collider other)
    {
        bool result = false;
        FirstPersonController FPC = other.GetComponent<FirstPersonController>();
        if (FPC != null)
        {
            Destroy(gameObject);
            result = true;
        }
        return result;
    }
}

using UnityEngine;
using UnityEngine.Events;
using SimpleFPS;

public class Trigger : MonoBehaviour
{
    [SerializeField] protected UnityEvent Enter;
    [SerializeField] protected UnityEvent Exit;

    protected virtual GameObject OnTriggerEnter(Collider other)
    {
        FirstPersonController FPC = other.gameObject.GetComponent<FirstPersonController>();

        if (FPC != null)
        {
            Enter.Invoke();
        }

        return FPC.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController FPC = other.gameObject.GetComponent<FirstPersonController>();

        if (FPC != null)
        {
            Exit.Invoke();
        }
    }
}

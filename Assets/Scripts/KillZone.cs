using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destructible destructible = other.gameObject.GetComponent<Destructible>();

        if (destructible != null)
        {
            destructible.Kill();
        }
    }
}

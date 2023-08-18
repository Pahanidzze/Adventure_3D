using UnityEngine;
using SimpleFPS;

public class Acceleration : MonoBehaviour
{
    [SerializeField] private float Multiplier = 1.75f;

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController FPC = other.GetComponent<FirstPersonController>();

        if (FPC != null)
        {
            FPC.m_WalkSpeed *= Multiplier;
            FPC.m_RunSpeed *= Multiplier;
            FPC.m_JumpSpeed *= Multiplier;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController FPC = other.GetComponent<FirstPersonController>();

        if (FPC != null)
        {
            FPC.m_WalkSpeed /= Multiplier;
            FPC.m_RunSpeed /= Multiplier;
            FPC.m_JumpSpeed /= Multiplier;
        }
    }
}

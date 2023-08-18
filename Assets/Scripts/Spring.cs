using UnityEngine;
using SimpleFPS;

[RequireComponent(typeof(AudioSource))]
public class Spring : MonoBehaviour
{
    [SerializeField] private float Multiplier = 2f;
    private AudioSource Audio;

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (enabled == false) return;
        FirstPersonController FPC = other.GetComponent<FirstPersonController>();

        if (FPC != null)
        {
            FPC.m_Jump = true;
            FPC.m_JumpSpeed *= Multiplier;
            Audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (enabled == false) return;
        FirstPersonController FPC = other.GetComponent<FirstPersonController>();

        if (FPC != null)
        {
            FPC.m_JumpSpeed /= Multiplier;
        }
    }
}

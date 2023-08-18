using UnityEngine;
using SimpleFPS;

[RequireComponent(typeof(AudioSource))]
public class Teleporter : MonoBehaviour
{
    [SerializeField] private Teleporter TargetTeleporter;
    [HideInInspector] public bool TeleportedRecently = false;
    private AudioSource Audio;

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController FPC = other.GetComponent<FirstPersonController>();

        if (FPC != null && TargetTeleporter != null && TeleportedRecently == false)
        {
            TargetTeleporter.TeleportedRecently = true;
            FPC.transform.position = TargetTeleporter.transform.position;
            Audio.Play();
            TargetTeleporter.Audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TeleportedRecently = false;
    }
}

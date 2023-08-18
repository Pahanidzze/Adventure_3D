using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BackgroundMusic : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<AudioSource>().ignoreListenerPause = true;
    }
}

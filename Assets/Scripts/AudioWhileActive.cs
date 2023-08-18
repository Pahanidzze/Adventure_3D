using UnityEngine;
using System.Collections.Generic;

public class AudioWhileActive : MonoBehaviour
{
    [SerializeField] private AudioSource Audio;
    [SerializeField] private List<MonoBehaviour> Components;
    private bool IsActive = false;

    private void Update()
    {
        if (Audio == null) return;
        uint activeCount = 0;
        for (int i = 0; i < Components.Count; i++)
        {
            if (Components[i].enabled == true) activeCount++;
        }
        if (IsActive == false && activeCount > 0)
        {
            Audio.enabled = true;
            IsActive = true;
        }
        else if (IsActive == true && activeCount == 0)
        {
            Audio.enabled = false;
            IsActive = false;
        } 
    }
}

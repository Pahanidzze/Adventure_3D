using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ImpactEffect : MonoBehaviour
{
    [SerializeField] [Min(0)] private float Time;

    private void Start()
    {
        Destroy(gameObject, Time);
    }
}

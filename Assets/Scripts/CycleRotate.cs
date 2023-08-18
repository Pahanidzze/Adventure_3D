using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleRotate : MonoBehaviour
{
    [SerializeField] private Vector3 Speed;

    private void Update()
    {
        transform.Rotate(Speed * Time.deltaTime);
    }
}

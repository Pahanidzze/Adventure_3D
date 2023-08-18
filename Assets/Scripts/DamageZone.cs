using UnityEngine;
using System.Collections.Generic;

public class DamageZone : MonoBehaviour
{
    [SerializeField] private int DirectDamage;
    [SerializeField] private int DamageOverTime;
    [SerializeField] [Min(0)] private float DamageRate = 1;
    private List<Destructible> Destructibles = new();
    private float Timer;

    private void OnTriggerEnter(Collider other)
    {
        Destructible destructible = other.gameObject.GetComponent<Destructible>();

        if (destructible != null)
        {
            Destructibles.Add(destructible);
            destructible.DoDamage(DirectDamage);
            Timer = 0;
        }
    }

    private void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= DamageRate)
        {
            for (int i = 0; i < Destructibles.Count; i++)
            {
                Destructibles[i].DoDamage(DamageOverTime);
            }
            Timer = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destructible destructible = other.gameObject.GetComponent<Destructible>();

        if (destructible != null)
        {
            Destructibles.Remove(destructible);
        }
    }
}

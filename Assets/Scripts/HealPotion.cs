using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPotion : PickUp
{
    [SerializeField] [Min(0)] private int Heal = 30;
    [SerializeField] private GameObject ImpactEffect;

    protected override bool OnTriggerEnter(Collider other)
    {
        bool result = false;
        Destructible destructible = other.gameObject.GetComponent<Destructible>();
        if (destructible != null)
        {
            if (destructible.GetHP() >= destructible.GetMaxHP()) result = false;
            else if (base.OnTriggerEnter(other) == true)
            {
                destructible.DoDamage(-Heal);
                result = true;
                if (ImpactEffect != null) Instantiate(ImpactEffect);
            }
        }
        return result;
    }
}

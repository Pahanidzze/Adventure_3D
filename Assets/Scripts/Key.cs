using UnityEngine;

public class Key : PickUp
{
    [SerializeField] [Min(0)] private int Amount = 1;
    [SerializeField] private GameObject ImpactEffect;

    protected override bool OnTriggerEnter(Collider other)
    {
        bool result = false;
        Bag bag = other.gameObject.GetComponent<Bag>();
        if (bag != null)
        {
            if (base.OnTriggerEnter(other) == true)
            {
                bag.AddKey(Amount);
                result = true;
                if (ImpactEffect != null) Instantiate(ImpactEffect);
            }
        }
        return result;
    }
}

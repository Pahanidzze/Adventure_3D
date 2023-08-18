using UnityEngine;
using UnityEngine.Events;

public class KeyTrigger : Trigger
{
    [SerializeField] [Min(0)] private int NeededKeys;
    [SerializeField] private UnityEvent ConditionMet;
    [SerializeField] private UnityEvent ConditionNotMet;
    private bool Triggered = false;

    protected override GameObject OnTriggerEnter(Collider other)
    {
        GameObject gameObject = base.OnTriggerEnter(other);

        if (Triggered == false) ConditionCheck(gameObject);

        return gameObject;
    }

    private void ConditionCheck(GameObject gameObject)
    {
        if (gameObject == null) return;
        Bag bag = gameObject.GetComponent<Bag>();

        if (bag != null)
        {
            if (bag.AddKey(-NeededKeys) == true)
            {
                ConditionMet.Invoke();
                Triggered = true;
            }
            else
            {
                ConditionNotMet.Invoke();
            }
        }
    }
}

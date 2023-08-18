using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    [SerializeField] private int MaxCount;
    [SerializeField] private int Count = 0;
    [SerializeField] private UnityEvent CompleteEvent;

    public virtual void IncreaseCount(int amount = 1)
    {
        Count += amount;
        if (Count >= MaxCount)
        {
            Count = MaxCount;
            CompleteEvent.Invoke();
        }
    }

    public int GetMaxCount()
    {
        return MaxCount;
    }

    public int GetCount()
    {
        return Count;
    }
}

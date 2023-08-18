using UnityEngine;
using UnityEngine.Events;

public class Bag : MonoBehaviour
{
    [SerializeField] private int Key = 0;
    [HideInInspector] public UnityEvent ChangeKeyAmount;

    private void Start()
    {
        ChangeKeyAmount.Invoke();
    }

    public bool AddKey(int amount = 1)
    {
        if (Key + amount < 0) return false;

        Key += amount;
        ChangeKeyAmount.Invoke();
        return true;
    }

    public int GetKeyAmount()
    {
        return Key;
    }
}

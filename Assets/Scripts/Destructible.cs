using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    [SerializeField] private int MaxHP;
    private int HP;
    [SerializeField] private UnityEvent Die;
    [HideInInspector] public UnityEvent ChangeHP;

    private void Start()
    {
        HP = MaxHP;
        ChangeHP.Invoke();
    }

    public void DoDamage(int damage)
    {
        HP -= damage;
        ChangeHP.Invoke();
        if (HP <= 0)
        {
            Kill();
        }
        else if (HP > MaxHP) HP = MaxHP;
    }

    public void Kill()
    {
        Die.Invoke();
    }

    public int GetMaxHP()
    {
        return MaxHP;
    }

    public int GetHP()
    {
        if (HP < 0) return 0;
        return HP;
    }
}

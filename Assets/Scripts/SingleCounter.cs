using UnityEngine;

public class SingleCounter : Counter
{
    private bool Complete = false;

    public override void IncreaseCount(int amount = 1)
    {
        if (Complete == false) base.IncreaseCount(amount);
        Complete = true;
    }
}

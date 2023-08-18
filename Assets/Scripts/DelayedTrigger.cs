using UnityEngine;
using UnityEngine.Events;

public class DelayedTrigger : MonoBehaviour
{
    [SerializeField] [Min(0)] private float Delay;
    [SerializeField] protected UnityEvent DelayedEnter;
    [SerializeField] protected UnityEvent DelayedExit;
    private float EnterTimer;
    private float ExitTimer;
    private bool Enter = false;
    private bool Exit = false;

    private void OnTriggerEnter(Collider other)
    {
        Exit = false;
        EnterTimer = 0;
        Enter = true;
    }

    private void Update()
    {
        EnterTimer += Time.deltaTime;
        ExitTimer += Time.deltaTime;
        if (EnterTimer >= Delay)
        {
            if (Enter == true)
            {
                DelayedEnter.Invoke();
                Enter = false;
            }
            EnterTimer = 0;
        }
        if (ExitTimer >= Delay)
        {
            if (Exit == true)
            {
                DelayedExit.Invoke();
                Exit = false;
            }
            ExitTimer = 0;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        Enter = false;
        ExitTimer = 0;
        Exit = true;
    }
}

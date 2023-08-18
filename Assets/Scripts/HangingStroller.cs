using UnityEngine;
using UnityEngine.UI;
using SimpleFPS;

public class HangingStroller : Counter
{
    [SerializeField] private Text Text;
    [SerializeField] private GameObject Canvas;

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController FPC = other.GetComponent<FirstPersonController>();
        if (FPC == null) return;
        if (GetCount() < GetMaxCount())
        {
            Text.text = $"Активировано {GetCount()}/{GetMaxCount()}";
            Canvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController FPC = other.GetComponent<FirstPersonController>();
        if (FPC == null) return;
        Canvas.SetActive(false);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class UIKeys : MonoBehaviour
{
    [SerializeField] private Bag Bag;
    [SerializeField] private Text Text;

    private void Start()
    {
        if (Bag == null || Text == null) return;
        Bag.ChangeKeyAmount.AddListener(Synchronize);
    }

    private void OnDestroy()
    {
        Bag.ChangeKeyAmount.RemoveListener(Synchronize);
    }

    public void Synchronize()
    {
        Text.text = Bag.GetKeyAmount().ToString();
    }
}

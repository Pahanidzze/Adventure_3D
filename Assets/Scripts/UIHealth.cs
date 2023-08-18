using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour
{
    [SerializeField] private Destructible Destructible;
    [SerializeField] private Image Image;

    private void Start()
    {
        if (Image == null || Destructible == null) return;
        Destructible.ChangeHP.AddListener(Synchronize);
    }

    private void OnDestroy()
    {
        Destructible.ChangeHP.RemoveListener(Synchronize);
    }

    public void Synchronize()
    {
        Image.fillAmount = (float)Destructible.GetHP() / Destructible.GetMaxHP();
    }
}

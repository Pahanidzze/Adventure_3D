using UnityEngine;
using SimpleFPS;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseCanvas;
    [SerializeField] private FirstPersonController FPC;
    private bool IsPause = false;

    private void Update()
    {
        if (PauseCanvas == null) return;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPause = !IsPause;
            if (IsPause == false)
            {
                Resume();
            }
            else if (IsPause == true)
            {
                Pause();
            }
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
        PauseCanvas.SetActive(true);
        FPC.enabled = false;
        AudioListener.pause = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        PauseCanvas.SetActive(false);
        FPC.enabled = true;
        AudioListener.pause = false;
    }
}

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
            if (IsPause == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    private void Pause()
    {
        IsPause = !IsPause;
        Time.timeScale = 0;
        PauseCanvas.SetActive(true);
        FPC.enabled = false;
        AudioListener.pause = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Resume()
    {
        IsPause = !IsPause;
        Time.timeScale = 1;
        PauseCanvas.SetActive(false);
        FPC.enabled = true;
        AudioListener.pause = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void CursorSwitch()
    {
        Cursor.visible = !Cursor.visible;
    }

    private void OnGUI()
    {
        if (IsPause == false)
        {
            Cursor.visible = false;
        }
    }
}

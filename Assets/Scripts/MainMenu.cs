using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

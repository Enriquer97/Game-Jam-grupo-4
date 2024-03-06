using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    public static bool GamePaused = false;
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GamePaused)
            {
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                pauseMenu.SetActive(true);
                GamePaused = true;
                Debug.Log(GamePaused);
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                pauseMenu.SetActive(false);
                GamePaused = false;
                Time.timeScale = 1f;
                Debug.Log(GamePaused);
            }
        }
    }
    public void OnMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void OnOneExit()
    {
#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

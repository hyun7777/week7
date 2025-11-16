using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menuUI;

    private void Start()
    {
        var newGameObject = new GameObject().AddComponent<SingletonComponent>();

        menuUI.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bool isActive = menuUI.activeSelf;
            menuUI.SetActive(!isActive);
        }
    }

    public void Resume()
    {
        menuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

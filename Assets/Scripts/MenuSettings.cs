using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuSettings : MonoBehaviour
{

    public void OpenLink(string link)
    {
        Application.OpenURL(link);
    }
    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {

        Application.Quit();
    }
}

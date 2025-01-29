using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void FirstLevel()
    {
        Application.OpenURL("https://github.com/xanorade/DGD303-EyupCanErkal-215040044-FrequencyFrenzy");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
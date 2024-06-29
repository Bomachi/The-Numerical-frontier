using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {



    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

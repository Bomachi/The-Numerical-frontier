using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeNPCController : MonoBehaviour, Interactable
{
    public int sceneBuildIndex;
    public void Interact()
    {
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeNPCController : MonoBehaviour, Interactable
{
    public int sceneBuildIndex;

    Fadeinout fade;

    void Start(){
        fade = FindObjectOfType<Fadeinout>();
    }

    public IEnumerator ChangeScene(){
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }

    public void Interact()
    {
        StartCoroutine(ChangeScene());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMove_Ref : MonoBehaviour
{

    Fadeinout fade;

    void Start(){
        fade = FindObjectOfType<Fadeinout>();
    }

    public IEnumerator ChangeScene(){
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }

    public int sceneBuildIndex;
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Player") {
            StartCoroutine(ChangeScene());
        }
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class CountdownTimer : MonoBehaviour
{
    public int countdownTime;
    public Text countdownText;

    Fadeinout fade;
    SceneChangeNPCController NPCquiz;
    private void Start()
    {
        NPCquiz = GetComponent<SceneChangeNPCController>();
        fade = FindObjectOfType<Fadeinout>();
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        int currentTime = countdownTime;
        while (currentTime > 0)
        {
            countdownText.text = currentTime.ToString();

            countdownText.text = $"Time left: {currentTime.ToString()} s";

            yield return new WaitForSeconds(1f);
            currentTime--;
        }

        countdownText.text = "Time out";
        OnCountdownEnd();
    }
    private IEnumerator ChangeScene(){
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneChangeNPCController.PreviousSceneName, LoadSceneMode.Single);
    }

    private void OnCountdownEnd()
    {
            StartCoroutine(ChangeScene());
    }
}

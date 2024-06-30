using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadeinout : MonoBehaviour
{
    public CanvasGroup canvasgroup;
    public bool fadein = false;
    public bool fadeout = false;

    public float TimeToFade;

    void Update()
    {
        if (fadein == true)
        {
            if (canvasgroup.alpha < 1)
            {
                canvasgroup.alpha += Time.deltaTime / TimeToFade;
                if (canvasgroup.alpha >= 1)
                {
                    canvasgroup.alpha = 1;
                    fadein = false;
                }
            }
        }
        if (fadeout == true)
        {
            if (canvasgroup.alpha > 0)
            {
                canvasgroup.alpha -= Time.deltaTime / TimeToFade;
                if (canvasgroup.alpha <= 0)
                {
                    canvasgroup.alpha = 0;
                    fadeout = false;
                }
            }
        }
    }

    public void FadeIn()
    {
        fadein = true;
    }

    public void FadeOut()
    {
        fadeout = true;
    }
}

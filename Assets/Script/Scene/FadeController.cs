using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour
{
    Fadeinout fade;
    void Start()
    {
        fade = FindObjectOfType<Fadeinout>();
        
        fade.FadeOut();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NPCcontroller : MonoBehaviour, Interactable
{
    [SerializeField] Dialog dialog;
    public void Interact(){
        StartCoroutine(DialogManger.Instance.ShowDialog(dialog));
    }
}
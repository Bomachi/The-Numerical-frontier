using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcontroller : MonoBehaviour, Interactable
{
    [SerializeField] Dialog dialog;
    
    public void Interact(){
        StartCoroutine(DialogManger.Instance.ShowDialog(dialog));
    }
}

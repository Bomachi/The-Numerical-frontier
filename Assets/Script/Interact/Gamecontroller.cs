using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{ Freeroam, Dialog, Battle}
public class Gamecontroller : MonoBehaviour
{
    [SerializeField] PlayerController playerController;

    GameState state;

    private void Start(){
        DialogManger.Instance.OnShowDialog += () => {
            state = GameState.Dialog;
        };
        DialogManger.Instance.OnHideDialog += () => {
            if (state == GameState.Dialog)
            state = GameState.Freeroam;
        };
    }

    private void Update(){
        if (state == GameState.Freeroam){
            playerController.HandleUpdate();
        }
        else if  (state ==  GameState.Dialog){
            DialogManger.Instance.HandleUpdate();
        }
        else if  (state ==  GameState.Battle){
            
        }
    }
}

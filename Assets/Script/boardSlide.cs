using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardSlide : MonoBehaviour
{
    public void slideIn(){
        this.transform.LeanMoveLocal(new Vector2(-79, -11), 1).setEaseOutQuart();
    }

     public void slideOut(){
        this.transform.LeanMoveLocal(new Vector2(-2500, -11), 1).setEaseOutQuart();
    }
}

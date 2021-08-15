using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shape : MonoBehaviour
{
   public new string name{get; set;}
   public string color{get; set;}
   public int id{get; private set;}


   private void Update() {
       id=Random.Range(1, 10);
   }

    private void OnMouseDown() {
        DisplayText();
    }

    public virtual void  DisplayText(){
        Debug.Log(name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceEnemytank : MonoBehaviour
{
   EdgeCollider2D EC;
   public static bool IsInETank = false;
   private void Awake() {
      EC = GetComponent<EdgeCollider2D>();
      EC.isTrigger = true;
   }
   private void OnTriggerEnter2D(Collider2D other) {
      if(other.tag == "Player"){
         if(IsInETank == false){
         other.transform.position = new Vector3(-35.48f,48.31f,-4f);
         IsInETank = true;
         Entrance.IsInTank = false;
      }else
      {
         other.transform.position= new Vector3(16.19f,1f,-4f);
         IsInETank= false;
         Entrance.IsInTank = false;
      }
   }
      
   }
}

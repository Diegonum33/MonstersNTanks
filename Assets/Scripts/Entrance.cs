using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entrance : MonoBehaviour
{
   EdgeCollider2D EC;
   public static bool IsInTank = false;
   private void Awake() {
      EC = GetComponent<EdgeCollider2D>();
      EC.isTrigger = true;
   }
   private void OnTriggerEnter2D(Collider2D other) {
      Debug.Log("HOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
      if(other.tag == "Player"){
         if(IsInTank == false){
         other.transform.position = new Vector3(58,44,-9);
         IsInTank = true;
      }else
      {
         other.transform.position= new Vector3(-13,1,-4);
         IsInTank= false;
      }
   }
      
   }
}
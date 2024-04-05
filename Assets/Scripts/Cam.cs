using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{

    [SerializeField] float leftlimit;
    [SerializeField] float rightlimit;
    [SerializeField] float toplimit;
    [SerializeField] float bottomlimit;
    // Start is called before the first frame update
    private void Update() {
        if(Entrance.IsInTank == false){
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x,-11.35f,7.03f),
                Mathf.Clamp(transform.position.y, -1f, 6.96f),
                transform.position.z
            );
        }
        if(Entrance.IsInTank == true){
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x,47f,55.7f),
                Mathf.Clamp(transform.position.y, 41f,59.9f),
                transform.position.z
            );
        }
    }
    
    //Pruebas
    private void OnDrawGizmos(){
        Gizmos.color= Color.red;
        Gizmos.DrawLine(new Vector2(leftlimit,toplimit), new Vector2(rightlimit,toplimit));
        Gizmos.DrawLine(new Vector2(rightlimit,toplimit), new Vector2(rightlimit,bottomlimit));
        Gizmos.DrawLine(new Vector2(rightlimit,bottomlimit), new Vector2(leftlimit,bottomlimit));
        Gizmos.DrawLine(new Vector2(leftlimit,bottomlimit), new Vector2(leftlimit,toplimit));     
    }
}

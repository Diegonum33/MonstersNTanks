using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Camera cam;
   public float moveSpeed =5f;
   public Rigidbody2D player;
   UnityEngine.Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        //Inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y= Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate() 
    {
        //Movments
        player.MovePosition(player.position + movement * moveSpeed * Time.fixedDeltaTime);
        cam.transform.position = new UnityEngine.Vector3(player.position.x,player.position.y,-10);
    }
}
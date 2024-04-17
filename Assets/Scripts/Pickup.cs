using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{ 
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player")&&Input.GetKey(KeyCode.E))
        {
            Debug.Log("COllect");
            Collect();
        }
    }

    // Recolectar el objeto
    public void Collect()
    {

        // Desactivar el collider para evitar más colisiones
        Collider2D collider = GetComponent<Collider2D>();
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (collider != null)
        {
            collider.enabled = false;
        }
        if(rb != null){
            rb.simulated = false;
        }
        

        // Agregar el objeto al inventario del jugador
        PlayerInventory.Instance.AddToInventory(gameObject);
    }

}


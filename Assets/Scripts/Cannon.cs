using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{   
    public Transform firePoint;
    public float projectileForce = 10f;
    public void Fire(GameObject projectilePrefab)
    {
        firePoint.position = new Vector3(firePoint.position.x, firePoint.position.y,1);
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        CapsuleCollider2D capsuleCollider = projectile.GetComponent<CapsuleCollider2D>();
        if (rb != null)
        {   
            rb.simulated = true;
            PlayerInventory.Instance.inventory[PlayerInventory.Instance.inventory.Count - 1].transform.position = firePoint.position;
            Destroy(projectilePrefab);
            PlayerInventory.Instance.inventory.RemoveAt(PlayerInventory.Instance.inventory.Count-1);
            rb.AddForce(firePoint.right * projectileForce, ForceMode2D.Impulse);
            capsuleCollider.enabled=true;
        }
     }
    private void FireCannon()
    {
        // Disparar el cañón si el jugador presiona la tecla "Q"
        // Aquí se puede agregar alguna lógica adicional si se necesita
        Debug.Log(PlayerInventory.Instance.inventory.Count);
        // Obtener el último ítem del inventario
        GameObject projectileToFire = null;
        if (PlayerInventory.Instance.inventory.Count > 0)
        {
            Debug.Log(PlayerInventory.Instance.inventory.Count);
            projectileToFire = PlayerInventory.Instance.inventory[PlayerInventory.Instance.inventory.Count - 1];
        }

        // Si se encontró un ítem en el inventario, dispararlo
        if (projectileToFire != null)
        {
            Fire(projectileToFire);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.Q))
            {  
                FireCannon();
            }
        }
    }
}


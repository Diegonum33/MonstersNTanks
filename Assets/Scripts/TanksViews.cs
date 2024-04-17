using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TanksViews : MonoBehaviour
{
    public Slider vidaSlider;
    private int vida; 
    void Start()
    {
        // Inicializar la vida del sprite en 100
        vida = 100;
        if (vidaSlider != null)
        {
            vidaSlider.value = vida;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el collider que entra en contacto es el del proyectil
        if (other.CompareTag("Proyectil"))
        {
            // Destruir el proyectil
            Destroy(other.gameObject);
            vida -= 10;
            Debug.Log("" + vida);
            if (vida <= 0)
            {
                 SceneManager.LoadScene("Main Menu");
            }
            if (vidaSlider != null)
            {
                vidaSlider.value = vida;
            }
        }
    }
}

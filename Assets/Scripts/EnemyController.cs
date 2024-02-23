using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        // Mover el enemigo hacia abajo
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBullet")) // Verificar si el enemigo es golpeado por una bala del jugador
        {
            Destroy(other.gameObject); // Destruir la bala
            Destroy(gameObject); // Destruir el enemigo
        }
    }
}

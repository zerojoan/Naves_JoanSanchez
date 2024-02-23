using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTime); // Destruir la bala después de un cierto tiempo
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Mover la bala hacia adelante
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) // Verificar si la bala colisiona con un enemigo
        {
            Destroy(other.gameObject); // Destruir el enemigo
            Destroy(gameObject); // Destruir la bala
        }
    }
}
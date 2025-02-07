using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteLadyMovement : MonoBehaviour
{
    public Transform player; 
    public float speed = 3f;

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            transform.position += direction * speed * Time.deltaTime;

            // Opcjonalnie: Obróć przeciwnika w kierunku gracza
            transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
        }
    }
}

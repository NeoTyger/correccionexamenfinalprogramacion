using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 target = new Vector3(10,3,5);
    private float speed;
    private Vector3 direccion;
    private float distancia;

    // Update is called once per frame
    void Update()
    {
        distancia = (target.x - transform.position.x) + (target.y - transform.position.y) + (target.z - transform.position.z);
        direccion = target - transform.position;

        // while (distancia > 1)
        // {
        //     speed = 2;
        //     transform.Translate(direccion * speed * Time.deltaTime);
        // }
        //
        // speed = 0;
        
        transform.Translate(direccion * speed * Time.deltaTime);
    }
}

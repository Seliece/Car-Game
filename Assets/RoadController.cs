using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    void FixedUpdate()
    {
        PlusOne();
        if (transform.position.x < -30) {
            transform.position = new Vector3(19, transform.position.y);
        }
    }

    void PlusOne() {
        transform.position = new Vector3(transform.position.x - Spawner.speed/150, transform.position.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public GameObject me;
    public GameObject spawner;
    public static bool destroy = false;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(12, gameObject.transform.position.y);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - (speed/100), transform.position.y, 0);

        if (gameObject.transform.position.x < -12) {
            Destroy(gameObject);
        }
        if (destroy == true) {
            Destroy(me);
        }
        speed = Spawner.speed;
        
    }
}

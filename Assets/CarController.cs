using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject Car;
    public float velocity = 0;
    public float speedMulti;
    public float angleValue;
    public static bool alive = true;

    // Start is called before the first frame update
    void Start()
    {
        Car.transform.position = new Vector3(-7, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (alive == false) {
        }
        if (Input.GetKey(KeyCode.W)) {
            velocity++;
        }

        if (Input.GetKey(KeyCode.S)) {
            velocity--;
        }

        Car.transform.localEulerAngles = new Vector3(0, 0, velocity * angleValue);
            
        Car.transform.position = new Vector3(Car.transform.position.x, Car.transform.position.y + (velocity * (speedMulti / 100)));
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Obstacle") || collision.CompareTag("Wall")) {
            alive = false;
            RespawnHandler.done = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}

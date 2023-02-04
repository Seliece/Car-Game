using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Obstacle;

    private float respawnTime = 1.0f;
    public static float speed = 5;

    void Start() {
        StartCoroutine(Spawn());
    }
    void FixedUpdate() {

        CheckIfAlive();

        respawnTime = 10 / ((ScoreCount.score * (0.99f / (ScoreCount.score + 1))) + speed);

        SpeedController();

    }


    public void StartStuff() {
        StartCoroutine(Spawn());
    }
    public IEnumerator Spawn() {
        while (CarController.alive == true) {
            yield return new WaitForSeconds(respawnTime);
            SpawnObstacle();

        }
    }
    void CheckIfAlive() {
        if (CarController.alive == false) {
            StopCoroutine(Spawn());
            GetComponent<Spawner>().enabled = false;
        }
    }
    void SpeedController() {
        if (Input.GetKey(KeyCode.A) && speed > 5) {
            speed--;
        }


        if (Input.GetKey(KeyCode.D) && speed < 50) {
            speed++;
        }
    }
    private void SpawnObstacle() {
        GameObject Obst = Instantiate(Obstacle) as GameObject;
        Obst.transform.position = new Vector3(-12, Random.Range(4.23f, -4.38f));
        Obst.GetComponent<ObstacleController>().speed = speed;
        Obst.GetComponent<ObstacleController>().spawner = gameObject;

    }


}


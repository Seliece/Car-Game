using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RespawnHandler : MonoBehaviour
{
    public GameObject MenuThing;
    public GameObject car;
    public GameObject obstacleSpawner;
    public GameObject scoreinc;

    public static bool done = true; 
    int highscore = 0;
    // Update is called once per frame
    void FixedUpdate() {
        if (CarController.alive == false && done == false) {
            LoadMenu();
            done = true;
        }
    }

    public void Respawn() {
        CarController.alive = true;
        ObstacleController.destroy = true;
        car.GetComponent<CarController>().velocity = 0;
        car.transform.position = new Vector3(-7, 0, 0);
        car.GetComponent<SpriteRenderer>().enabled = true;

        ScoreCount.score = 0;
        scoreinc.SetActive(true);

        obstacleSpawner.GetComponent<Spawner>().enabled = true;
        obstacleSpawner.GetComponent<Spawner>().StartStuff();
        Spawner.speed = 5;
        MenuThing.SetActive(false);
        ObstacleController.destroy = false;
        GameObject[] cars = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject car in cars) {
            Destroy(car);
        }
    }

    public void Exit() {
        Application.Quit();
    }

    void LoadMenu() {
        MenuThing.SetActive(true);
        int score = ScoreCount.score;
        if (score > highscore) { //fix dit aaaaaaaaaaaaaa 
            highscore = score;
        }
        MenuThing.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = score.ToString();
        MenuThing.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = $"HighScore: {highscore}";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public static int score = 0;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Obstacle")) {
            score++;
        }
    }

    private void FixedUpdate() {
        if (CarController.alive == false) {
            gameObject.SetActive(false);
        }
    }
}

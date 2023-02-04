using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    void FixedUpdate()  
    {
        SetScore(ScoreCount.score);
    }

    void SetScore(int scoreCount) {
        GetComponent<TextMeshProUGUI>().text = $"Score: {scoreCount}";
    }
}

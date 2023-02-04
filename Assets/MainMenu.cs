using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject game;
    public Camera mainMenu;
    public void Play() {
        game.SetActive(true);
        mainMenu.enabled = false;
    }

    public void Exit() {
        Application.Quit();
    }
}

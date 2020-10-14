/*
 * Anthony Wessel
 * Assignment 5 - 3D prototype
 * Ends the game when the player reaches the exit
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinOnTrigger : MonoBehaviour
{
    public Text winText;

    bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover)
        {
            winText.text = "You win!\nPress R to play again!";
            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameover = true;
        }
    }
}

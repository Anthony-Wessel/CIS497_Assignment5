/*
 * Anthony Wessel
 * Assignment 5 - PennyPixel
 * Ends the game when player reaches the door (this object)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            ScoreManager.gameover = true;
    }
}

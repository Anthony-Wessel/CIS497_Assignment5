/*
 * Anthony Wessel
 * Assignment 5 - PennyPixel
 * Increments the score every time the player touches a gem
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemIncrementScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            ScoreManager.score++;

    }
}

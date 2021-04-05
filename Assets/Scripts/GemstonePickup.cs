// Joshua Wisdom
// 2313991
// CPSC 236-03
// jowisdom@chapman.edu
// Project 05: 2D Platformer
// This is my own work, and I did not cheat on this assignment.

// No known errors.

// Completed alongside provided videos with provided materials.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemstonePickup : MonoBehaviour
{
    public AudioClip pickupClip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Player")
        {
            AudioSource.PlayClipAtPoint(pickupClip, transform.position);
            Destroy(this.gameObject);
        }
    }
}

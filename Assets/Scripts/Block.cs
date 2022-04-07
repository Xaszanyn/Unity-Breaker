using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public AudioClip sound;

// Cached reference
    Level level;
    private void OnCollisionEnter2D(Collision2D collided) {
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
    }

    void Start() {
        level = FindObjectOfType<Level>();
        level.CountB();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deadline : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collided) {
        SceneManager.LoadScene(1);
    }
}

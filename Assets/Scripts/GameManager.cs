using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GoNext() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Menu() {
        SceneManager.LoadScene(0);
    }

    public void Play() {
        SceneManager.LoadScene(2);
    }
}

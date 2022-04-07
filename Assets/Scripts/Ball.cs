using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // config params
    public Pad paddle;

    bool hasStarted;
    public int vel;
    AudioSource AS;

    public AudioClip[] sounds;


    //state
    Vector2 paddleToBall;
    void Start()
    {
        hasStarted = false;
        paddleToBall = transform.position - paddle.transform.position;
        AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!hasStarted) {
            Lock();
            Launch();
        }
    }


    void Lock() {
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBall;
    }

    void Launch() {
        if(Input.GetMouseButtonDown(0)) {
            hasStarted = true;
            float angle = Random.Range(20, 160);
            Debug.Log(Mathf.Cos(Mathf.PI/180 * angle) * vel + " | " + Mathf.Sin(Mathf.PI/180 * angle) * vel);
            GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Cos(Mathf.PI/180 * angle) * vel, Mathf.Sin(Mathf.PI/180 * angle) * vel);
        }
    }

    private void OnCollisionEnter2D(Collision2D collided) {
        AudioClip clip = sounds[Random.Range(0, sounds.Length)];

        // you can take that thing into variable and classify as cached component reference!!
        // GetComponent<AudioSource>().PlayOneShot(clip);
        AS.PlayOneShot(clip);
    }
}

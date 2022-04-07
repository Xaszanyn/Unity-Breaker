using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouse = Input.mousePosition.x / Screen.width * 8;
        Vector2 pos = new Vector2(Mathf.Clamp(mouse, 1, 7), transform.position.y);
        transform.position = pos;
    }
}

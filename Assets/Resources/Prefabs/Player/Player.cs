using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 20f;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }

    void move(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}

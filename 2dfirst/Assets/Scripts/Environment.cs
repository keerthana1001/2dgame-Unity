using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public float speed;
    public float Xend;
    public float Xstart;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < Xend)
        {
            Vector2 pos = new Vector2(Xstart, transform.position.y);
            transform.position = pos;
        }
    }
}
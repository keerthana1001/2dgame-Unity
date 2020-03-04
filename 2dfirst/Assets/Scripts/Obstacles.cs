using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacles : MonoBehaviour
{
    public float speed;
    
    public int damage = 1;
   
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            collision.GetComponent<PlayerController>().health -= damage;
            Debug.Log(collision.GetComponent<PlayerController>().health);

            Destroy(gameObject);
        }
    }
}

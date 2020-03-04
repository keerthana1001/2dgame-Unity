using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Vector2 targetPosition;
    private float incY = 2.4f;
    public float MaxHeight;
    public float MinHeight;
    public float Speed;
    public float health = 3;
    public Text HealthText;
    public GameObject panel;
    private void Update()
    {
        if(health<=0)
        {
            panel.SetActive(true);
            Debug.Log("gameOver");
            gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y<MaxHeight)
        {
            //Debug.Log("UpArrow Pressed");
            targetPosition = new Vector2(transform.position.x, transform.position.y + incY);
            //Debug.Log(transform.position);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y>MinHeight)
        {
            //Debug.Log("DownArrow Pressed");
            targetPosition = new Vector2(transform.position.x, transform.position.y - incY);
           
            //Debug.Log(transform.position);
        }

        HealthText.text = health.ToString();
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
       
        
    }
    public void goUp()
    {
        if (transform.position.y < MaxHeight)
        {
            targetPosition = new Vector2(transform.position.x, transform.position.y + incY);
        }
    }
    public void goDown()
    { 
        if (transform.position.y > MinHeight)
        {
            targetPosition = new Vector2(transform.position.x, transform.position.y - incY);
        }
    }
    public void restart()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
        SceneManager.LoadScene("SampleScene");
    }
}

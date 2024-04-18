using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    float size = 1.0f;
    int score = 1;
    SpriteRenderer renderer;


    void Start()
    {
        float x = Random.Range(-2.4f,2.4f);
        float y = Random.Range(3.5f,5.0f);

        transform.position = new Vector3(x,y,0);

        int type = Random.Range(1, 5);

        if (type == 1 )
        {
            size = 0.8f;
            score = 1;
            GetComponent<SpriteRenderer>().color = new Color(100 / 255f, 100 / 255f, 255 / 255f, 255 / 255f);
        }
        else if (type == 2)
        {
            size = 1.0f;
            score = 2;
            GetComponent<SpriteRenderer>().color = new Color(130 / 255f, 130 / 255f, 255 / 255f, 255 / 255f);

        }
        else if(type == 3)
        {
            size = 1.2f;
            score = 3;
            GetComponent<SpriteRenderer>().color = new Color(150 / 255f, 150 / 255f, 255 / 255f, 255 / 255f);
        }
        else if (type ==4)
        {
            size = 0.8f;
            score =-5;
            GetComponent<SpriteRenderer>().color = new Color(255 / 255.0f, 100.0f / 255.0f, 100.0f / 255.0f, 255.0f / 255.0f);
        }

        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision .gameObject.CompareTag("Ground"))
        {
          Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance. AddScore(score);
            Destroy(this.gameObject);
        }
    }
}

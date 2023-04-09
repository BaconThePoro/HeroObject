using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    int currLife = 0;
    SpriteRenderer ourSpriteRenderer; 
    void Start()
    {
        currLife = 4; 
        ourSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currLife == 0)
            Destroy(gameObject);
    }

    public void reduceLife()
    {
        currLife--;
        Color newColor = new Color(ourSpriteRenderer.color.r, ourSpriteRenderer.color.g, ourSpriteRenderer.color.b, GetComponent<SpriteRenderer>().color.a * 0.8f);
        ourSpriteRenderer.color = newColor;
    }

}

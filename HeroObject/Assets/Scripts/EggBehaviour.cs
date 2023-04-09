using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggBehaviour : MonoBehaviour
{
    public const float kEggSpeed = 40f;
    CameraSupport s = null; 

    private int mLifeCount = 0; 
    // Start is called before the first frame update
    void Start()
    {
        s = Camera.main.GetComponent<CameraSupport>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * (kEggSpeed * Time.smoothDeltaTime);
        if (!s.isInside(transform.GetComponent<Collider2D>().bounds))
        {
            Debug.Log("Egg has hit world boundary"); 
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Enemy(Clone)")
        {

        }
    }
}

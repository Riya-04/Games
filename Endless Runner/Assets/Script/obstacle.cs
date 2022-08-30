using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public float lifetime;
    
    public GameObject collision_sound;
    public GameObject collision_effect;


    
    void Start()
    {
        Destroy(gameObject, lifetime);     //destroy obstacles after some time
    }

    
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);       //moving left
       
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(collision_sound, transform.position, Quaternion.identity);   //collision sound
            Instantiate(collision_effect, transform.position, Quaternion.identity);   //collision particle effect

            //Life decreases when collided
            other.GetComponent<player>().health -= damage;
            Debug.Log(other.GetComponent<player>().health);
            Destroy(gameObject);   
        }
        
    }
}

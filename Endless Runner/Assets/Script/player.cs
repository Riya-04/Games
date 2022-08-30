using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private Vector2 targetPos;
    public float speed;
    public float ydiff;
    public float maxHeight;

    public float health = 3;

    public GameObject score_manager;
    public GameObject gameover;
    public GameObject game;
    public GameObject obstacle;
    public GameObject pop_sound;
    public GameObject gameover_sound;
    public GameObject bg_sound;
    public GameObject player_particles;
    public Text life;
   

    
    void Start()
    {
        targetPos = transform.position;     //otherwise player reposition at targetPos=(0,0) at start of game
        obstacle.SetActive(true);
        Instantiate(bg_sound, transform.position, Quaternion.identity);  //game sound
    }

    
    void Update() 
    {
        life.text = "x " + health.ToString();


        if (health <= 0)
        {
            game.SetActive(false);        //prevents from creating obstacles patterns on GameOver.
            gameover.SetActive(true);   //activate gameover gameobject
            Instantiate(gameover_sound, transform.position, Quaternion.identity);  //gameover sound
           
            //to keep Environment and Score in the scene when GameOver appears
            Destroy(gameObject);     //destroy player
            Destroy(score_manager);  //destroy leftmost collider, to stop score from increasing
            obstacle.SetActive(false);

        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);  //smooth movement

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(pop_sound, transform.position, Quaternion.identity);  //pop sound
            Instantiate(player_particles, transform.position, Quaternion.identity);  //player particle effect 
            targetPos = new Vector2(transform.position.x, transform.position.y + ydiff);   //move up
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -maxHeight)
        {
            Instantiate(pop_sound, transform.position, Quaternion.identity);  //pop sound
            Instantiate(player_particles, transform.position, Quaternion.identity);  //player particle effect 
            targetPos = new Vector2(transform.position.x, transform.position.y - ydiff);    //move down
        }
    }
}

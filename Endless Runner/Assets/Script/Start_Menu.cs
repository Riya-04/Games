using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Menu : MonoBehaviour
{
    public GameObject game;
    public GameObject gameover;
    public Button start;

    // Start is called before the first frame update
    void Start()
    {
        //game.SetActive(false);
        //gameover.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        /*
         * if (Input.GetKey(KeyCode.R))
        {
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        */
        
    }

    public void Play_game()
    {
        game.SetActive(true);
        gameObject.SetActive(false);

    }

    public void Restart()
    {
        game.SetActive(true);

        gameover.SetActive(false);
    }
}

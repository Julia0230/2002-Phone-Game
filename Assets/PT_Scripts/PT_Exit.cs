using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Exit : MonoBehaviour {
   
   
    public IS_NextCanvas canvas;
    private PT_Basic_GameManager gameManager;
    private int i=0;
    //public AudioClip song;
    //public AudioSource source;
   
    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<PT_Basic_GameManager>();
        canvas = GameObject.Find("ReferenceManager").GetComponent<IS_NextCanvas>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.score += 20;
            gameManager.LoadNextLevel();
            gameObject.SetActive(false);
            other.gameObject.transform.position = new Vector3(-10, -10, 0);
            if(i==0)
            {   canvas.source.clip=canvas.song;
                canvas.source.Play();
                canvas.MyRef1.SetActive(true);
                i++;
            }

        }
    }

}

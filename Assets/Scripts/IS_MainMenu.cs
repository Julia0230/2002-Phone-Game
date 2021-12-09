using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_MainMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject beggining;
    public GameObject nr2canvas;
    public AudioSource music;
    public AudioClip song;
    public AudioClip song2;
   

public void PlayGame()
{
 menu.SetActive(false);
music.clip=song2;
music.Play();

}
public void Backstory1()
{
 beggining.SetActive(false);
music.clip=song;
music.Play();
}
public void Backstory2()
{
 nr2canvas.SetActive(false);
music.clip=song;
music.Play();
}
}

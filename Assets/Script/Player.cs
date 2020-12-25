using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject fooText;
    //handle when letter comes into contack with center
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        GetComponent<SpriteRenderer>().color = Color.red;
        Time.timeScale = 0;

        GameObject thePlayer = GameObject.Find("center");
        Spawn script = thePlayer.GetComponent<Spawn>();
        script.playing = false;
        GameObject.FindGameObjectWithTag("Ui").GetComponent<Canvas>().enabled = true;
        fooText.GetComponent<Text>().text="Score = " + Spawn.score + "\nMisses = " + Spawn.miss;
    }

}

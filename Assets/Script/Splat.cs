using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splat : MonoBehaviour
{

    public Sprite[] sprites = new Sprite[6];
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(0, sprites.Length);
        sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = sprites[num];
        sr.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

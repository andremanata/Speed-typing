using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public float radius;
    public GameObject[] letters = new GameObject[4];
    public bool playing = true;
    public static int score = 0;
    public static int miss = 0;

    private float spawnTime = 2f;
    private float spawnIncrement = .02f;
    private float speed = 1f;

    private List<GameObject> spawnList = new List<GameObject>();
    private List<GameObject> letterList = new List<GameObject>();
    private List<GameObject> inuse = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < letters.Length; i++)
        {
            letterList.Add(letters[i]);
        }
        Invoke("createLetter", 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                inputHandler(KeyCode.A, "A");
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                inputHandler(KeyCode.B, "B");
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                inputHandler(KeyCode.B, "C");
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                inputHandler(KeyCode.B, "D");
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                inputHandler(KeyCode.B, "E");
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                inputHandler(KeyCode.B, "F");
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                inputHandler(KeyCode.B, "G");
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                inputHandler(KeyCode.B, "H");
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                inputHandler(KeyCode.B, "I");
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                inputHandler(KeyCode.B, "J");
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                inputHandler(KeyCode.B, "K");
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                inputHandler(KeyCode.B, "L");
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                inputHandler(KeyCode.B, "M");
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                inputHandler(KeyCode.B, "N");
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                inputHandler(KeyCode.B, "O");
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                inputHandler(KeyCode.B, "P");
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                inputHandler(KeyCode.B, "Q");
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                inputHandler(KeyCode.B, "R");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                inputHandler(KeyCode.B, "S");
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                inputHandler(KeyCode.B, "T");
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                inputHandler(KeyCode.B, "U");
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                inputHandler(KeyCode.B, "V");
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                inputHandler(KeyCode.B, "W");
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                inputHandler(KeyCode.B, "X");
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                inputHandler(KeyCode.B, "Y");
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                inputHandler(KeyCode.B, "Z");
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    //check if corresponding letter is a hit or a miss
    void inputHandler(KeyCode input, string letter)
    {
        for (int i = 0; i < spawnList.Count; i++)
        {
            
            if (spawnList[i].tag == letter)
            {

                Destroy(spawnList[i]);
                letterList.Add(inuse[i]);
                spawnList.RemoveAt(i);
                inuse.RemoveAt(i);

                score++;
                return;
            }
        }
        miss++;
    }

    //Spawn a random letter at a random position 
    void createLetter()
    {
        if (letterList.Count > 0)
        {

            int num = Random.Range(0, letterList.Count);
            GameObject obj = letterList[num];
            letterList.RemoveAt(num);
            GameObject spawn = (GameObject)Instantiate(obj, RandomCircle(), Quaternion.identity);
            spawn.GetComponent<Letter>().speed = speed;
            spawnList.Add(spawn);
            inuse.Add(obj);
            spawnTime -= spawnIncrement;
            speed += 0.01f; 
        }

        Invoke("createLetter", spawnTime);

    }

    //return a random possition with a distance of radias from center
    Vector3 RandomCircle()
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = 0;
        return pos;
    }

}
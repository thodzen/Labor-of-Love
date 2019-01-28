using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayCount : MonoBehaviour {
    public float time;
    public Sprite tree1;
    public Sprite tree2;
    public Sprite tree3;
    public bool isCuttable;
    public Collider2D treeCollider;
    public Collider2D playerCollider;
    public Collider2D homeCollider;
    public bool playerInRange;
    public int numberWood;
    SpriteRenderer sr;
    private Animator anim;
    GameObject[] trees;
    GameObject player;
    GameObject home1;
    //GameObject home2;
    public bool upgrade;
    public bool winGame;

    public string sceneName;

    // Use this for initialization
    void Start()
    {
        numberWood = 0;
        time = 5;
        sr = GetComponent<SpriteRenderer>();
        player = GameObject.Find("Player");
        home1 = GameObject.Find("Home");
       // home2 = GameObject.Find("FinishedHome");

        upgrade = false;
        isCuttable = false;
        playerInRange = false;
        winGame = false;
        treeCollider = GameObject.FindGameObjectWithTag("Tree").GetComponent<Collider2D>();
        playerCollider = GameObject.Find("Player").GetComponent<Collider2D>();
        homeCollider = GameObject.Find("Home").GetComponent<Collider2D>();
        trees = GameObject.FindGameObjectsWithTag("Tree");


    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        //Debug.Log(time);
        if (time <= 0)
        {
            mature();
            //Debug.Log("Next Day");
            time = 5;
        }

        if (playerInRange == true && isCuttable == true)
        {
            if (Input.GetKeyDown("space"))
            {
                this.sr.sprite = tree1;
                isCuttable = false;
                this.transform.localScale -= new Vector3(3F, 3f, 0);
                numberWood++;
                Debug.Log(numberWood);
            }
        }
        if (numberWood >= 1)
        {
            upgrade = true;
        }
        if (homeCollider.IsTouching(playerCollider) && upgrade == true)
        {
            {
                winGame = true;
               // home1.SetActive(false);
               // home2.SetActive(true);
                SceneManager.LoadScene("Home is where the heart is", LoadSceneMode.Single);
                StartCoroutine(LoadCurrentScene());
                Debug.Log("yeet");
            }
        }

    }

    void mature()
    {
        if(sr.sprite == tree1)
        {
            sr.sprite = tree2;
            transform.localScale += new Vector3(1F, 1f, 0);
        }
        else if(sr.sprite == tree2)
        {
            sr.sprite = tree3;
            transform.localScale += new Vector3(2f, 2f, 0);
            isCuttable = true;
        }
    }
    void OnCollisionEnter2D(Collision2D col)

    {
        if (col.gameObject.tag == "Player")
        {
            playerInRange = true;

            //Debug.Log("test");
        }


    }
    void OnCollisionExit2D(Collision2D col)

    {
        if (col.gameObject.tag == "Player")
        {
            playerInRange = false;

            //Debug.Log("test");
        }


    }

    IEnumerator LoadCurrentScene()
    {
        //Debug.Log("PRESSED BUTTON");
        //transitionAnim.SetTrigger("end long");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}


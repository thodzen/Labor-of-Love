using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCount : MonoBehaviour {
    public float time;
    public Sprite tree1;
    public Sprite tree2;
    public Sprite tree3;
    public bool isCuttable;
    public Collider2D treeCollider;
    public Collider2D playerCollider;
    public bool playerInRange;
    public int numberWood;
    SpriteRenderer sr;
    GameObject player;
    GameObject tree;
	// Use this for initialization
	void Start () {
        numberWood = 0;
		time = 5;
        sr = GetComponent<SpriteRenderer>();
        player = GameObject.Find("Player");
        isCuttable = false;
        playerInRange = false;
        treeCollider = GameObject.Find("treeFirst").GetComponent<Collider2D>();
        playerCollider = GameObject.Find("Player").GetComponent<Collider2D>();
        tree = GameObject.Find("treeFirst");
        tree.layer = LayerMask.NameToLayer("Player");
    }
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        //Debug.Log(time);
        if(time <= 0)
        {
            mature();
            //Debug.Log("Next Day");
            time = 5;
        }

        if (treeCollider.IsTouching(playerCollider))
        {
            playerInRange = true;
            tree.layer = LayerMask.NameToLayer("Tree");
            //Debug.Log("test");
        }else
        {
            playerInRange = false;
            tree.layer = LayerMask.NameToLayer("Player");
        }

        if(playerInRange == true && isCuttable == true)
        {
            if (Input.GetKeyDown("space"))
            {
                sr.sprite = tree1;
                isCuttable = false;
                transform.localScale -= new Vector3(3F, 3f, 0);
                numberWood++;
                Debug.Log(numberWood);
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

}

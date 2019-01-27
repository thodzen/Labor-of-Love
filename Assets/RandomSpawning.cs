using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawning : MonoBehaviour {
    GameObject spawnPoint1;
    GameObject spawnPoint2;
    GameObject spawnPoint3;
    GameObject tree;
    public float spawnPoint1MinX;
    public float spawnPoint2MinX;
    public float spawnPoint3MinX;
    public float spawnPoint1MaxX;
    public float spawnPoint2MaxX;
    public float spawnPoint3MaxX;
    public float spawnPoint1MinY;
    public float spawnPoint2MinY;
    public float spawnPoint3MinY;
    public float spawnPoint1MaxY;
    public float spawnPoint2MaxY;
    public float spawnPoint3MaxY;

    public float spawnPoint1Width;
    public float spawnPoint1W;
    public float spawnPoint2Width;
    public float spawnPoint3Width;

    public Vector3 spawnPos1;
    public Vector3 spawnPos2;
    public Vector3 spawnPos3;
    // Use this for initialization
    void Start () {
		tree = GameObject.Find("treeFirst") as GameObject;
        spawnPoint1 = GameObject.Find("SpawnArea1");
        spawnPoint2 = GameObject.Find("SpawnArea2");
        spawnPoint3 = GameObject.Find("SpawnArea3");
        spawnPoint1Width = spawnPoint1.GetComponent<SpriteRenderer>().bounds.size.x;
        spawnPoint1W = spawnPoint1.GetComponent<SpriteRenderer>().bounds.min.x;
        spawnPoint2Width = spawnPoint2.GetComponent<SpriteRenderer>().bounds.size.x;
        spawnPoint3Width = spawnPoint3.GetComponent<SpriteRenderer>().bounds.size.x;

        



        spawnPoint1MinX = spawnPoint1.GetComponent<SpriteRenderer>().bounds.min.x;
        spawnPoint2MinX = spawnPoint2.GetComponent<SpriteRenderer>().bounds.min.x;
        spawnPoint3MinX = spawnPoint3.GetComponent<SpriteRenderer>().bounds.min.x;
        spawnPoint1MaxX = spawnPoint1.GetComponent<SpriteRenderer>().bounds.max.x;
        spawnPoint2MaxX = spawnPoint2.GetComponent<SpriteRenderer>().bounds.max.x;
        spawnPoint3MaxX = spawnPoint3.GetComponent<SpriteRenderer>().bounds.max.x;
        spawnPoint1MinY = spawnPoint1.GetComponent<SpriteRenderer>().bounds.min.y;
        spawnPoint2MinY = spawnPoint2.GetComponent<SpriteRenderer>().bounds.min.y;
        spawnPoint3MinY = spawnPoint3.GetComponent<SpriteRenderer>().bounds.min.y;
        spawnPoint1MaxY = spawnPoint1.GetComponent<SpriteRenderer>().bounds.max.y;
        spawnPoint2MaxY = spawnPoint2.GetComponent<SpriteRenderer>().bounds.max.y;
        spawnPoint3MaxY = spawnPoint3.GetComponent<SpriteRenderer>().bounds.max.y;
        
        for (int i = 0; i < 10; i++)
        { getSpawnArea();spawnTrees();  }
    }
	
	// Update is called once per frame
	void Update () {
        
        //spawnTrees();
        
        Debug.Log(spawnPoint1W);
	}

    private void getSpawnArea()
    {
        spawnPos1 = new Vector3(UnityEngine.Random.Range(spawnPoint1MinX, spawnPoint1MaxX), UnityEngine.Random.Range(spawnPoint1MinY, spawnPoint1MaxY), 0);
        spawnPos2 = new Vector3(UnityEngine.Random.Range(spawnPoint2MinX, spawnPoint2MaxX), UnityEngine.Random.Range(spawnPoint2MinY, spawnPoint2MaxY), 0);
        spawnPos3 = new Vector3(UnityEngine.Random.Range(spawnPoint3MinX, spawnPoint3MaxX), UnityEngine.Random.Range(spawnPoint3MinY, spawnPoint3MaxY), 0);
    }

    void spawnTrees()
    {
        
        
            Instantiate(tree, spawnPos1, Quaternion.identity);
            Instantiate(tree, spawnPos2, Quaternion.identity);
            Instantiate(tree, spawnPos3, Quaternion.identity);
        

    }
}

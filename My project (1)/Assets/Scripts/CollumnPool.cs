using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollumnPool : MonoBehaviour
{
    public int columnPoolSize = 5;
    public GameObject columnPrefab;
    public float spawnRate = 4f;
    public float columnMin = -1f;

    private GameObject[] columns;
    private readonly Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timesincelastSpawned;
    private int currentColumn = 0;
    private readonly float spawnXPosition = 10f;

    void Start()
    {
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timesincelastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timesincelastSpawned >= spawnRate)
        {
            timesincelastSpawned = 0;
            float spawnYPosition = Random.Range(columnMin, -1f);
            columns[currentColumn].transform.position = new Vector2(10f, spawnYPosition);
            currentColumn++;
            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }

        }
    }

    }
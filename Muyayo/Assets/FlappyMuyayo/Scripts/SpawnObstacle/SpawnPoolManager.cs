
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoolManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int poolSize;
    [SerializeField] private float spawnTime = 2.5f;
    [SerializeField] private float XspawnPosition = 6f;
    [SerializeField] private float yMinPosition = -3.4f;
    [SerializeField] private float yMaxPosition = 4f;


    private GameObject[] obstacle;
    private float timeElapsed;
    private int obstacleCount;

    bool GO;

    private void Awake()
    {
        FindObjectOfType<DeadPlayer>().DiePlayer += SpawnInit;
        //FindObjectOfType<CollisionToPlayer>().playerCollision += ActiveObject;
    }
    void Start()
    {
        obstacle = new GameObject[poolSize];
        for(int i = 0; i < poolSize; i++)
        {
            obstacle[i] = Instantiate(prefab);
            obstacle[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
       if(timeElapsed > spawnTime && !GO)
        {
            SpawnObstacles();
        }
    }
    void SpawnInit()
    {
        GO = true;
    }
    void ActiveObject()
    {
        gameObject.SetActive(false);
    }
    private void SpawnObstacles()
    {
        timeElapsed = 0f;

        float ySpawnPosition = Random.Range(yMinPosition, yMaxPosition);
        Vector2 spawnPosition = new Vector2(XspawnPosition, ySpawnPosition);
        obstacle[obstacleCount].transform.position = spawnPosition;

        if(!obstacle[obstacleCount].activeSelf) obstacle[obstacleCount].SetActive(true);

        obstacleCount++;

        if(obstacleCount == poolSize)
        {
            obstacleCount = 0;
        }
    }
}

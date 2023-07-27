using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(30, 0, 0);
    private PlayerController playerControllerScript;
    private float targetTime;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0)
        {
            SpawnObstacle();
        }
    }

    void SpawnObstacle ()
    {
        if (!playerControllerScript.isGameOver)
        {
            Vector3 spawnPos = new Vector3(Random.Range(30, 40), 0, 0);
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            targetTime = Random.Range(2, 5);
        }
    }
}

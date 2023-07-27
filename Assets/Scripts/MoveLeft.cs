using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20;
    private float leftBound = -15;
    private PlayerController playerControllerScript;
    private GameManager gameManager;
    bool isScoreAdded = false;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.x);
        if (!playerControllerScript.isGameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        

        if (gameObject.CompareTag("Obstacle"))
        {
            

            if (transform.position.x < -1)
            {
                if(isScoreAdded == false)
                {
                    gameManager.UpdateScore(1);
                    isScoreAdded = true;
                }
            }
            if (transform.position.x < leftBound)
            {
                Destroy(gameObject);
            }

        }
    }
}

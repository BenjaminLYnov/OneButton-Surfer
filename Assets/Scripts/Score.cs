using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    public GameObject player;

    private float score = 0;

    GameObject[] walls;


    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = (int)60;

        scoreText.text = "Score : " + score.ToString();
    }

    void Start()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        walls = GameObject.FindGameObjectsWithTag("Wall");

        foreach (GameObject wall in walls)
        {
            if (wall.transform.position.z < player.transform.position.z - 2)
            {
                Destroy(wall);
                score++;
                difficultyGestion();
                scoreText.text = "Score : " + score.ToString();
            }
        }

    }

    void difficultyGestion()
    {
        switch (score)
        {
            case 10:
                GetComponent<GenerateWall>().cdInstanciateWall = 0.8f;
                player.GetComponent<PlayerMove>().speed = 6.0f;
                break;
            case 30:
                GetComponent<GenerateWall>().cdInstanciateWall = 0.6f;
                GetComponent<GenerateWall>().distanceApparition = 15;
                break;
            case 50:
                GetComponent<GenerateWall>().cdInstanciateWall = 0.4f;
                player.GetComponent<PlayerMove>().speed = 7.0f;
                GetComponent<GenerateWall>().distanceApparition = 20;
                break;
            case 100:
                GetComponent<GenerateWall>().cdInstanciateWall = 0.2f;
                player.GetComponent<PlayerMove>().speed = 8.0f;
                GetComponent<GenerateWall>().distanceApparition = 30;
                break;

        }
    }


}

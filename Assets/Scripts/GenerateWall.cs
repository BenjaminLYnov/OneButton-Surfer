using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWall : MonoBehaviour
{

    public GameObject[] walls;

    public GameObject Player;

    public float distanceApparition = 10;

    private float timer = 0;

    public float cdInstanciateWall = 3;

    // Start is called before the first frame update
    void Start()
    {
        InstaniateWall();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > cdInstanciateWall)
        {
            timer = 0;
            InstaniateWall();
        }
    }

    void InstaniateWall()
    {
        GameObject go = Instantiate(walls[Random.Range(0, walls.Length)]);
        go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, Player.transform.position.z + distanceApparition);
    }


}

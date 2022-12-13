using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayer : MonoBehaviour
{
    public PlayerMove playerMove;
    public bool changeDir = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (changeDir) {
                playerMove.dirLateral *= (-1);
            }

            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.transform.position = new Vector3(transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z);
        }

    }
}

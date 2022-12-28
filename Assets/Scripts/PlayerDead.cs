using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{

    public GameObject[] toDisabled;
    public GameObject[] toEnabled;

    public AudioSource[] cri;


    public GameObject player;

    //Private
    PlayerMove playerMove;

    public GameObject prefabHeart;
    public Transform canvas;

    private void Start()
    {
        showHeart();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {

            player.GetComponent<PlayerMove>().hp--;

            if (player.GetComponent<PlayerMove>().hp <= 0)
            {
                foreach (GameObject item in toDisabled)
                {
                    item.SetActive(false);
                }

                foreach (GameObject item in toEnabled)
                {
                    item.SetActive(true);
                }

                playerMove = player.GetComponent<PlayerMove>();
                playerMove.enabled = false;
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            }

            cri[Random.Range(0, cri.Length)].Play();

            showHeart();
        }
    }

    void showHeart()
    {
        // Destroy hearts

        GameObject[] hearts;
        hearts = GameObject.FindGameObjectsWithTag("Heart");

        foreach (GameObject heart in hearts)
        {
            Destroy(heart);
        }

        // instanciate hearts

        for (int i = 0; i < player.GetComponent<PlayerMove>().hp; i++)
        {
            GameObject go = Instantiate(prefabHeart);
            go.transform.SetParent(canvas);
            go.GetComponent<RectTransform>().position = new Vector3(100 + 120 * i, 500, 0);
        }

    }
}

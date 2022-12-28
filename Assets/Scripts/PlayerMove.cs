using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5.0f;
    public float m_Thrust = 20f;
    public int dirLateral = 1;
    public int hp = 3;
    public GameObject pika;
    public GameObject sphere;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddForceLateral();
        }
    }

    private void FixedUpdate()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        pika.transform.position = new Vector3(sphere.transform.position.x + 0.008f, sphere.transform.position.y - 0.244f, sphere.transform.position.z - 0.519f);
    }

    private void AddForceLateral()
    {
        rb.AddForce(dirLateral * transform.right * m_Thrust, ForceMode.Impulse);
    }













}

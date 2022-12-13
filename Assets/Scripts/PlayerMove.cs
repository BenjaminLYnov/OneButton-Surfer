using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5.0f;
    public float m_Thrust = 20f;
    public int dirLateral = 1;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddForceLateral();
        }

        // if (Input.GetKeyUp(KeyCode.Z))
        // {
        //     test++;
        //     print(test);
        // }

    }

    private void FixedUpdate()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void AddForceLateral()
    {
        rb.AddForce(dirLateral * transform.right * m_Thrust, ForceMode.Impulse);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            // Game Over
            print("Game Over");
        }
    }








}

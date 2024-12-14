using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public AudioSource coinFX;
    // Start is called before the first frame update
    public float speed = 7.0f;
    public float jumpForce = 2.5f;
    void Start()
    {
        speed = 5.0f;
    }

    // Update is called once per frame
    void Update()   
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -3, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 3, 0);
        }
        if(Input.GetKey(KeyCode.Space)) 
        {
            transform.Translate(Vector3.up*Time.deltaTime * jumpForce);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
    }

}
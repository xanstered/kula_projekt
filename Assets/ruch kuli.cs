using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruchkuli : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();

        if(Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddTorque(-Vector3.left);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddTorque(Vector3.left);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddTorque(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddTorque(-Vector3.forward);
        }
    }
}

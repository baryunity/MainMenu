using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    private Rigidbody m_Rigidbody;
    [SerializeField]
    private float m_Speed = 100f;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        if (m_Rigidbody == null)
        {
            print("NULL rigidbody");
        }
        print("tag = " + gameObject.tag + " <<<<<<<<<<<<<<<<<<<<<<\n");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            print("YYY key");
        }

        if (gameObject.tag == "Cube1")
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_Speed, Space.World);
            transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * m_Speed / 5, Space.World);
        } else
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * m_Speed, Space.World);
            transform.Rotate(new Vector3(-1, 0, 0) * Time.deltaTime * m_Speed / 5, Space.World);
        }
    }

}

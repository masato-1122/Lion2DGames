using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //private Rigidbody2D rigidBody;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}

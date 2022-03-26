using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject canvas;
    GameObject[] balls;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        balls = GameObject.FindGameObjectsWithTag("ball");
        Debug.Log(balls.Length);
        if (balls.Length <= 0)
        {
            Debug.Log("ゲームオーバー");
            canvas.SetActive(true);
        }
    }
}
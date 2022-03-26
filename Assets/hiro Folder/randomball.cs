using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomball : MonoBehaviour
{
<<<<<<< Updated upstream
  public GameObject ballPrefab;

  public float mintime = 4f;

  public float maxtime = 8f;

  public float xMinPosition = -5f;

  public float xMaxPosition = 5f;

  public float yMinPosition = -3f;

  public float yMaxPosition = 4f;

  private float interval;

  private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        interval = GetRandomTime();
=======
    // Start is called before the first frame update
    void Start()
    {
        
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
      time += Time.deltaTime;
      if(time > interval)
      {
        GameObject ball = Instantiate(ballPrefab);
        ball.transform.position = GetRandomPosition();
        time = 0f;
        interval = GetRandomTime();
      }
    }

    private float GetRandomTime()
    {
      return Random.Range(mintime, maxtime);
    }
    private Vector3 GetRandomPosition()
    {
      float x = Random.Range(xMinPosition, xMaxPosition);
      float y = Random.Range(yMinPosition, yMaxPosition);

      return new Vector3(x,y);
    }
  }
=======
        
    }
}
>>>>>>> Stashed changes

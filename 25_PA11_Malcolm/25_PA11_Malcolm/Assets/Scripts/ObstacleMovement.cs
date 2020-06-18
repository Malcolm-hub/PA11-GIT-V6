using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float Bypass = 1;
    private float xSpeed = -4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 0 && Bypass == 1)
        {
            Bypass = 0;
            GameManager.thisManager.UpdateScore();
        }

        transform.Translate(new Vector3(xSpeed*Time.deltaTime, 0, 0f));
        if (transform.position.x < -12)
        {
            Destroy(this.gameObject);
        }
    }
}

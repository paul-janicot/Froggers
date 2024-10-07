using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    private CameraFollow cameraFollow;
    void Start()
    {
        cameraFollow = GetComponent<CameraFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0,speed,0);
            cameraFollow.isUp = true;
            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0, 0);
            cameraFollow.isUp = false;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -speed, 0);
            cameraFollow.isUp = true;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(speed,0, 0);
            cameraFollow.isUp = false;
        }
    }
}

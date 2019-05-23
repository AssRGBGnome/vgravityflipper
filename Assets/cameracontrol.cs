using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameracontrol : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cam;

    private void Update()
    {
        Vector2 Play = Player.transform.position;
        Vector2 cam = Cam.transform.position;
        if (Player.transform.position.y >= -5f && Player.transform.position.y <= 5f && Player.transform.position.x > -8.95f && Player.transform.position.x < 8.95f)
        {
            Cam.transform.position = new Vector3(0f, 0, -10);
        }
        if (Player.transform.position.y >= -5f && Player.transform.position.y <= 5f && Player.transform.position.x > 8.95f && Player.transform.position.x < 26.717f)
        {
            Cam.transform.position = new Vector3(17.8082f, 0, -10);
        }
        if (Player.transform.position.y >= -5f && Player.transform.position.y <= 5f && Player.transform.position.x > 26.717f && Player.transform.position.x < 35.618f)
        {
            Cam.transform.position = new Vector3(35.6164f, 0, -10);
        }
    }
}
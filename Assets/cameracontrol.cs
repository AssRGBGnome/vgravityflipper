using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameracontrol : MonoBehaviour
{
    public GameObject Player;
    public Animator CamMovement;

    private void Update()
    {
        Vector2 Play = Player.transform.position;
        if (Player.transform.position.y >= -5f && Player.transform.position.y <= 5f && Player.transform.position.x > -8.95f && Player.transform.position.x < 8.95f)
        {
            CamMovement.SetInteger("Screen", 1);
        }
        if (Player.transform.position.y >= -5f && Player.transform.position.y <= 5f && Player.transform.position.x > 8.95f && Player.transform.position.x < 26.717f)
        {
            CamMovement.SetInteger("Screen", 2);
        }
        if (Player.transform.position.y >= -5f && Player.transform.position.y <= 5f && Player.transform.position.x > 26.717f && Player.transform.position.x < 35.618f)
        {
            CamMovement.SetInteger("Screen", 3);
        }
    }
}
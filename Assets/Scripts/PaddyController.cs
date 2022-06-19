using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddyController : MonoBehaviour
{
    public float speed;
    private float speedreset;

    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;

    public GameObject PKiri;
    public GameObject PKanan;
    private Vector2 scaleChange;
    private Vector2 scaleDefault;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        scaleChange = new Vector2(0.5f, 4);
        scaleDefault = new Vector2(0.5f, 2);
    }

    private void Update()
    {
        //move object & //get input
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {

        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        //Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }

    public void ActivatePUPaddySpeedUp(float magnitude)
    {
        speedreset = speed;
        speed *= magnitude;
        Invoke("DeactivatePUPaddySpeedUp", 5.0f);
    }

    public void DeactivatePUPaddySpeedUp()
    {
        speed = speedreset;
        Debug.Log("Paddle Speed Up Deactivated");
    }

    public void ActivatePUPaddyLoong()
    {
        PKiri.transform.localScale = scaleChange;
        PKanan.transform.localScale = scaleChange;
        Invoke("DeactivatePUPaddyLoong", 5.0f);
    }

    public void DeactivatePUPaddyLoong()
    {
        PKiri.transform.localScale = scaleDefault;
        PKanan.transform.localScale = scaleDefault;
        Debug.Log("Paddle Length Increase Deactivated");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;

    private Rigidbody2D rig;
    private Vector2 container;
    public float mag;

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        //container = rig.velocity;
        rig.velocity *= magnitude;
        Invoke("DeactivatePUSpeedUp", 5.0f);
    }

    public void DeactivatePUSpeedUp()
    {
        //rig.velocity = rig.velocity.normalized;
        rig.velocity /= mag;
        Debug.Log("Speed Up Deactivated");
    }
}
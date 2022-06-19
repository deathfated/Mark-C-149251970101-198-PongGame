using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddySpeedController : MonoBehaviour
{
    public Collider2D bol;
    public Collider2D PKiri;
    public Collider2D PKanan;
    public float magnitude;
    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == bol)
        {
            PKiri.GetComponent<PaddyController>().ActivatePUPaddySpeedUp(magnitude);
            PKanan.GetComponent<PaddyController>().ActivatePUPaddySpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}

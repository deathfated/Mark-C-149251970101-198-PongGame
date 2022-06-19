using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddyLoongController : MonoBehaviour
{
    public Collider2D bol;
    public Collider2D PKiri;
    public Collider2D PKanan;
    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == bol)
        {
            PKiri.GetComponent<PaddyController>().ActivatePUPaddyLoong();
            PKanan.GetComponent<PaddyController>().ActivatePUPaddyLoong();
            manager.RemovePowerUp(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULongPaddel : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float scale;
    public GameObject padelKanan;
    public GameObject padelKiri;
    public BallController bola;
    public GameObject Effect;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (bola.isRight)
            {
                padelKanan.GetComponent<PadelController>().ActivePULongPaddel(scale);
                Instantiate(Effect, transform.position, transform.rotation);
                manager.RemovePowerUp(gameObject);
            }
            else
            {
                padelKiri.GetComponent<PadelController>().ActivePULongPaddel(scale);
                Instantiate(Effect, transform.position, transform.rotation);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}

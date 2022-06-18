using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;
    public GameObject Effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallController>().ActivePUSpeedUp(magnitude);
            Instantiate(Effect, transform.position, transform.rotation);
            manager.RemovePowerUp(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rig;
    public bool isRight = true;
    public GameObject HitSFX;

  
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
    }

    public void ActivePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
        StartCoroutine("DeActivePUSpeedUP", magnitude);
    }

    private IEnumerator DeActivePUSpeedUP(float magnitude)
    {
        yield return new WaitForSeconds(5f);
        rig.velocity /= magnitude;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.name == "Paddel Kanan")
        {
            isRight = true;
        }
        else
        {
            isRight = false;
        }

        Instantiate(HitSFX);
    }
}

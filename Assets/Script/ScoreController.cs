using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
   public Text skorKanan;
   public Text skorKiri;

   public ScoreManager manager;

    private void Update()
    {
        skorKanan.text = manager.RightScore.ToString();
        skorKiri.text = manager.LeftScore.ToString();
    }
}

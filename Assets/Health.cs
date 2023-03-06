using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int health = 3;
    public TextMeshProUGUI endText;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
           End();
        }
        
    }

    void End()
    {
        if (gameObject.tag == "Enemy")
        {
            endText.text = "You win!";
        }
        else
        {
            endText.text = "You lose";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int score = 0;
    public int increment = 1;
    public Text text;
    public Text text2;
    public Text text3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void increasScore()
    {
        score += increment;
        text.text = score.ToString();
    }
    public void store()
    {
        if (score > 5)
        {
            text3.text = "";
            increment++;
            score -= 5;
            text.text = score.ToString();
            text2.text = "INC =" + increment;

        }
        else
        {
            text3.text = ("you dont have enough score");
        }
    }
}
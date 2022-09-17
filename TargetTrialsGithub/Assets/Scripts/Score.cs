using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int scoreCounter = 0;
    Text points;
    Text GameOver;
    public GameObject Over;
    // Start is called before the first frame update
    void Start()
    {
        points = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        points.text = "Score: " + scoreCounter;
        if(scoreCounter == 10)
        {
            Over.SetActive(true);
        }
    }
}

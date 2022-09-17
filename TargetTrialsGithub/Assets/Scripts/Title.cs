using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject titleScreen;

    void Start()
    {
        titleScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void OnButtonPress()
    {
        //titleScreen.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}

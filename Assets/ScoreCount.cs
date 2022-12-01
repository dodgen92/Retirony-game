using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Text counterText;
    int kills;
    // I should've used TMPtext but creature of habit and all...
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowKills();
    }

    private void ShowKills()
    {
        counterText.text = "Lurches Dusted: " + kills.ToString();
    }

    public void AddKill()
    {
        kills++;
    }
}

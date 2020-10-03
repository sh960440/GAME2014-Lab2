using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButtonBehavior : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestButtonPressed()
    {
        Debug.Log("TestButton Pressed");
        LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
    }
}

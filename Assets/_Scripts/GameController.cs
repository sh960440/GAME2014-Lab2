using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;
    private float livesLabelHalfWidth;
    private float livesLabelHalfHeight;
    private float scoreLabelHalfWidth;
    private float scoreLabelHalfHeight;
    public CanvasScaler scaler;
    public Vector2 scale;

    // Start is called before the first frame update
    void Start()
    {
        var currentResolution = new Vector2(Screen.currentResolution.width, Screen.currentResolution.height);
        scale = currentResolution / scaler.referenceResolution;

        livesLabelHalfWidth = LivesLabel.rectTransform.rect.width * 0.5f * scale.x;
        livesLabelHalfHeight = LivesLabel.rectTransform.rect.height * 0.5f * scale.y;
        scoreLabelHalfWidth = ScoreLabel.rectTransform.rect.width * 0.5f * scale.x;
        scoreLabelHalfHeight = ScoreLabel.rectTransform.rect.height * 0.5f * scale.y;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        switch(Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                //SceneLabel.text = "Portrait";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                break;
            case DeviceOrientation.LandscapeLeft:
                //SceneLabel.text = "LandscapeLeft";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                break;
            case DeviceOrientation.LandscapeRight:
                //SceneLabel.text = "LandscapeRight";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                break;
            case DeviceOrientation.Unknown:
                //SceneLabel.text = "Unknown";
                break;
        }
        */


        
        /*
        switch(Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                if (hasSafeArea)
                {
                LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                }
                else
                {
                LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                }
                break;
            case ScreenOrientation.LandscapeLeft:
                if (hasSafeArea)
                {
                LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                }
                else
                {
                LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                }
                break;
            case ScreenOrientation.LandscapeRight:
                if (hasSafeArea)
                {
                LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                }
                else
                {
                LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                }
                break;
            case ScreenOrientation.Unknown:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                break;
        }
        */

        LivesLabel.rectTransform.position = new Vector2(Screen.safeArea.xMin + livesLabelHalfWidth, Screen.safeArea.yMax - livesLabelHalfHeight);
        ScoreLabel.rectTransform.position = new Vector2(Screen.safeArea.xMax - scoreLabelHalfWidth, Screen.safeArea.yMax - livesLabelHalfHeight);
    }
}

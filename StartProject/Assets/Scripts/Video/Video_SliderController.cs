using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_SliderController : MonoBehaviour
{
    VideoPlayer video;

    int sliderWidth;
    Vector2 slider_startPos;

    private void Awake()
    {
        GameObject vidGo = GameObject.Find("VideoPlayer");
        video = vidGo.GetComponent<VideoPlayer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //slider_startPos = this.transform.position;
        slider_startPos = this.transform.localPosition;
        //Vector2 test2 = this.GetComponent<RectTransform>().localPosition;
        //Vector2 test3 = this.GetComponent<RectTransform>().rect.position;

        //get the with of the slider on which the marker is moving on
        GameObject reachGo = GameObject.Find("SliderReach");
        sliderWidth = (int)reachGo.GetComponent<RectTransform>().rect.width;
    }

    // Update is called once per frame
    void Update()
    {
        float vidRatio= (video.frame/(float)video.frameCount);
        //Debug.Log(vidRatio);

        UpdateSliderPos(vidRatio);

    }

    void UpdateSliderPos(float vidRatio)
    {
        //add the ratio of the sliderwith to the x component of the slider
        int xOffset = (int)(sliderWidth * vidRatio);
        

        this.transform.localPosition = slider_startPos + new Vector2(xOffset, 0);
    }
}

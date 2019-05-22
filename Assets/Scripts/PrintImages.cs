using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
public class PrintImages : MonoBehaviour
{

    public int frameRate = 24;
    public float startTime = 500.0f;
    public float endTime = 501.0f;
    public float timeScale = 5f;
   // public string printName = "screenshot";

    int updateTime = 0;
    int doTimes;
    int frame = 0;
    float currentTime;
    float usingScale = 1.0f;
    public double time;
    public VideoPlayer video;
    void Start()
    {
        Directory.CreateDirectory("PrintImages/");
        usingScale = Mathf.Min(1.0f, timeScale);
    }

    void Update()
    {
        //// Debug.Log(video.time); 
        //currentTime += Time.deltaTime;
        //if (currentTime > startTime && currentTime <= endTime)
        //{
        //    SetTimeScale(usingScale);
        //    doTimes = (int)(currentTime * frameRate);
        //    int diffTimes = doTimes - updateTime;
        //    if (diffTimes > 0)
        //    {
        //        frame += 1;
        //        PrintImage();

        //        updateTime = doTimes;
        //    }
        //}
        //else
        //{
        //    SetTimeScale(1);
        //}
    }

    void SetTimeScale(float scale)
    {
        if (Time.timeScale != scale)
            Time.timeScale = scale;
    }

    public void PrintImage()
    {
        string outputName = "PrintImages/"  + frame + ".jpg";
        Application.CaptureScreenshot(outputName);

        print("print:" + outputName);
    }
}
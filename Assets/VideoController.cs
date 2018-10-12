using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoController : MonoBehaviour
{
    public string videoFile;
    public GameObject text;

    private VideoPlayer videoPlayer;

	// Use this for initialization
	void Start () {
        var textComponent = text.GetComponent<Text>();

        string url = Path.Combine(Application.streamingAssetsPath, videoFile);
        textComponent.text = url;

        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.url = url;
        videoPlayer.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

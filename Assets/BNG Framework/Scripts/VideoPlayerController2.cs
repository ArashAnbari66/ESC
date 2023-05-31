using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController2 : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer videoPlayer;

    public void PlayVideo()
    {
        videoPlayer.Play();
    }
}

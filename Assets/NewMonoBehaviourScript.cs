using UnityEngine;
using UnityEngine.Video;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private bool rotate;

    private void Awake()
    {
        if (rotate)
        {
            canvas.GetComponent<RectTransform>().rotation = Quaternion.Euler(90f, -90f, 0);
        }
    }

    public void OnImageTrack()
    {
        canvas.SetActive(true);
        videoPlayer.Play();
    }

    public void OnImageUnTrack()
    {
        canvas.SetActive(true);
        videoPlayer.Pause();
    }
}

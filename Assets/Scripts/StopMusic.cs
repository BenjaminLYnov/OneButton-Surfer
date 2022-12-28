using UnityEngine;

public class StopMusic : MonoBehaviour
{
    public AudioSource music;

    void Start()
    {
        music.enabled = false;
    }
}

using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlaySong("Believer");

        StopSong();

        SetVolume(15f);

        GetCurrentSong();

        IsPlaying();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaySong(string songName)
    {
        Debug.Log(songName = "Believer");
    }

    void StopSong()
    {
        Debug.Log("Believer");
    }

    void SetVolume(float volume)
    {
        Debug.Log(volume);
        SetVolume(15f);
    }

    string GetCurrentSong()
    {
        return "Believer";
    }

    bool IsPlaying()
    {
        return true;
    }
}

using UnityEngine;

public class SesYonetici : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip click1;
    public AudioClip click2;
    public AudioClip click3;
    void Start()
{
    audioSource = GetComponent<AudioSource>();
}


    public void SesCal(int index)
    {
        audioSource.Stop(); // Diğer sesi durdur

        switch (index)
        {
            case 1:
                audioSource.clip = click1;
                break;
            case 2:
                audioSource.clip = click2;
                break;
            case 3:
                audioSource.clip = click3;
                break;
        }

        audioSource.Play();
    }
}

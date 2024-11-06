using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reproduceMusica : MonoBehaviour
{
    public static reproduceMusica Instance;
    private AudioSource audioSource;
    [SerializeField] public AudioClip audio1;
    [SerializeField] public AudioClip audio2;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = audio1;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void musicaJuego()
    {
        audioSource.clip = audio1;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void musicaVictoria()
    {
        audioSource.clip = audio2;
        audioSource.loop = false;
        audioSource.Play();
    }


}

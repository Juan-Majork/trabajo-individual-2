using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusic : MonoBehaviour
{
    public static playMusic instance;
    //[SerializeField] public AudioClip musicClip;
    private AudioSource musicSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
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
        musicSource = GetComponent<AudioSource>();

        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

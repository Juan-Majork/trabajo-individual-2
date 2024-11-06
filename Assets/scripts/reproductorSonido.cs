using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reproductorSonido : MonoBehaviour
{
    public static reproductorSonido Instance;
    private AudioSource soundSource;
    [SerializeField] public AudioClip sonido1;

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
       soundSource = GetComponent<AudioSource>(); 
    }

    public void playSound()
    {
        soundSource.PlayOneShot(sonido1);
    }
}

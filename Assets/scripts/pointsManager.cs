using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class pointsManager : MonoBehaviour
{
    public static pointsManager instance;

    public int playerPoints = 0;
    public float pointsValue = 0;

    public int mayorPuntuacion = 0;
    public int ultimaPuntuacion = 0;

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

    public void sumarPuntos()
    {
        if(pointsValue <= 20)
        {
            playerPoints += 3;
        }
        else if(pointsValue > 20 && pointsValue <= 40)
        {
            playerPoints += 2;
        }
        else if (pointsValue > 40 && pointsValue <= 60)
        {
            playerPoints += 1;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

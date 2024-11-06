using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aliveManager : MonoBehaviour
{
    private Controles lifePlayer;
    [SerializeField] private GameObject deathPanel;

    private bool alive;


    // Start is called before the first frame update
    void Start()
    {
        lifePlayer = GameObject.FindGameObjectWithTag("player").GetComponent<Controles>();
    }

    // Update is called once per frame
    void Update()
    {
        alive = lifePlayer.isAlive;

        if (alive == false)
        {
            deathPanel.SetActive(true);
        }
    }

    public void reintentar()
    {
        reproduceMusica.Instance.musicaJuego();
        SceneManager.LoadScene("level 1");
        pointsManager.instance.playerPoints = 0;
        pointsManager.instance.pointsValue = 0;
    }

    public void irMenu()
    {
        SceneManager.LoadScene("menu");
        pointsManager.instance.playerPoints = 0;
        pointsManager.instance.pointsValue = 0;
    }
}

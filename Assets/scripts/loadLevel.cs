using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    private Controles player;
    [SerializeField] public GameObject pausaPanel;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").GetComponent<Controles>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {

            Time.timeScale = 0f;
            pausaPanel.SetActive(true);
        }
    }

    public void despausar()
    {
        Time.timeScale = 1f;
        pausaPanel.SetActive(false); ;
    }

    public void irMenu()
    {
        Time.timeScale = 1f;
        pointsManager.instance.playerPoints = 0;
        pointsManager.instance.pointsValue = 0;
        SceneManager.LoadScene("menu");
    }

    public void iniciarJuego()
    {
        if (SceneManager.GetActiveScene().name == "menu")
        {
            pointsManager.instance.playerPoints = 0;
            pointsManager.instance.pointsValue = 0;
            SceneManager.LoadScene("level 1");
        }
    }

    public void volverMenu()
    {
        reproduceMusica.Instance.musicaJuego();
        pointsManager.instance.playerPoints = 0;
        pointsManager.instance.pointsValue = 0;
        SceneManager.LoadScene("menu");
    }

    public void salir()
    {
        Application.Quit();
    }
}

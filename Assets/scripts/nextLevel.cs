using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    private Animator animator;
    private Controles player;

    public int toExit;
    private bool openDoor;

    // Start is called before the first frame update
    void Start()
    {
        toExit = 0;
        openDoor = false;
        player = GameObject.FindGameObjectWithTag("player").GetComponent<Controles>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //player.checkCristals(toExit);
        toExit = player.cristalsExit;
        Debug.Log(toExit);

        if(SceneManager.GetActiveScene().name == "level 1")
        {
            if(toExit >= 3)
            {
                openDoor = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "level 2")
        {
            if (toExit >= 10)
            {
                openDoor = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "level 3")
        {
            if (toExit >= 20)
            {
                openDoor = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "level 4")
        {
            if (toExit >= 18)
            {
                openDoor = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "level 5")
        {
            if (toExit >= 10)
            {
                openDoor = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "level 6")
        {
            if (toExit >= 15)
            {
                openDoor = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "level 7")
        {
            if (toExit >= 9)
            {
                openDoor = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "level 8")
        {
            if (toExit >= 0)
            {
                openDoor = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "level 9")
        {
            if (toExit >= 5)
            {
                openDoor = true;
            }
        }

        if (openDoor)
        {
            animator.SetBool("opening", true);
            animator.SetBool("open", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            if (openDoor == true)
            {
                if (SceneManager.GetActiveScene().name == "level 1")
                {
                    SceneManager.LoadScene("level 2");
                    pointsManager.instance.pointsValue = 0;
                }
                if (SceneManager.GetActiveScene().name == "level 2")
                {
                    SceneManager.LoadScene("level 3");
                    pointsManager.instance.pointsValue = 0;
                }
                if (SceneManager.GetActiveScene().name == "level 3")
                {
                    SceneManager.LoadScene("level 4");
                    pointsManager.instance.pointsValue = 0;
                }
                if (SceneManager.GetActiveScene().name == "level 4")
                {
                    SceneManager.LoadScene("level 5");
                    pointsManager.instance.pointsValue = 0;
                }
                if (SceneManager.GetActiveScene().name == "level 5")
                {
                    SceneManager.LoadScene("level 6");
                    pointsManager.instance.pointsValue = 0;
                }
                if (SceneManager.GetActiveScene().name == "level 6")
                {
                    SceneManager.LoadScene("level 7");
                    pointsManager.instance.pointsValue = 0;
                }
                if (SceneManager.GetActiveScene().name == "level 7")
                {
                    SceneManager.LoadScene("level 8");
                    pointsManager.instance.pointsValue = 0;
                }
                if (SceneManager.GetActiveScene().name == "level 8")
                {
                    SceneManager.LoadScene("level 9");
                    pointsManager.instance.pointsValue = 0;
                }
                if (SceneManager.GetActiveScene().name == "level 9")
                {
                    reproduceMusica.Instance.musicaVictoria();
                    SceneManager.LoadScene("victory");
                    pointsManager.instance.pointsValue = 0;

                    if (pointsManager.instance.playerPoints > pointsManager.instance.mayorPuntuacion)
                    {
                        pointsManager.instance.ultimaPuntuacion = pointsManager.instance.mayorPuntuacion;
                        pointsManager.instance.mayorPuntuacion = pointsManager.instance.playerPoints;
                    }
                    else
                    {
                        pointsManager.instance.ultimaPuntuacion = pointsManager.instance.playerPoints;
                    }
                }
            }
        }
    }

}

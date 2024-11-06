using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    private float time = 0;

    private void Update()
    {
        time += Time.deltaTime;
        pointsManager.instance.pointsValue = time;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player")){

            reproductorSonido.Instance.playSound();
            pointsManager.instance.sumarPuntos();
            gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showUltimaPuntuacion : MonoBehaviour
{
    private TextMeshProUGUI texto;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "Ultima puntuacion: " + pointsManager.instance.ultimaPuntuacion.ToString();
    }
}

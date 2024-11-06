using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showFinalScore : MonoBehaviour
{
    private TextMeshProUGUI showScore;

    // Start is called before the first frame update
    void Start()
    {
        showScore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        showScore.text = "Puntuacion Final: " + pointsManager.instance.playerPoints;
    }
}

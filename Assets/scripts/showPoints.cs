using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showPoints : MonoBehaviour
{
    private TextMeshProUGUI points;

    // Start is called before the first frame update
    void Start()
    {
        points = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        points.text = "Points = " + pointsManager.instance.playerPoints.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showTime : MonoBehaviour
{
    private TextMeshProUGUI times;

    // Start is called before the first frame update
    void Start()
    {
        times = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        times.text = "Time = " + pointsManager.instance.pointsValue.ToString("F0") + "s";
    }
}

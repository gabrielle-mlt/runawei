using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float fTimer = 300f;
    [SerializeField] private TextMeshProUGUI timeTexte;

    Text tTimerTexte;

    void Start()
    {
        tTimerTexte=gameObject.GetComponent<Text>();
        fTimer = 300f;
    }

    void Update()
    {
        fTimer -= Time.deltaTime;
        timeTexte.text = ""+Mathf.Round(fTimer);
    }
}
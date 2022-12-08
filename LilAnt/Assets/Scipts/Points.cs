using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics.Contracts;

public class Points : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int point = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bread")
        {
            point++;
            score.text = point.ToString();
        }
    }
}

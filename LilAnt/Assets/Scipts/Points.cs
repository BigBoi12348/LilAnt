using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics.Contracts;
using UnityEngine.SceneManagement;

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
        //score.text = point.ToString();
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    point += 1;
        //    score.text = point.ToString();
        //    Debug.Log("bam");
        //}
        //score.text = point.ToString();
        //Debug.Log("bam");
        if(point >= 10)
        {
            //SceneManager.LoadScene("Win");
            Debug.Log("End");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("bread"))
        {
            point += 1;
            score.text = point.ToString();
            Destroy(other.gameObject);
        }
        
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    point += 1;
        //    score.text = point.ToString();
        //    Debug.Log("bam");
        //}
        score.text = point.ToString();
        Debug.Log("bam");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject whiteLight;
    public GameObject waitingLight;
    public GameObject finishedLight;
    public int seconds = 1;   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Timer()
    {
        int counter = seconds;
        while (counter > 0)
        {
            yield return new WaitForSeconds(1);
            counter--;
        }
        waitingLight.SetActive(true);
        whiteLight.SetActive(false);
    }
}

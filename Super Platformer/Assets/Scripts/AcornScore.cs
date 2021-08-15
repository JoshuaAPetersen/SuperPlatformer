using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AcornScore : MonoBehaviour
{
    public static AcornScore instance;
    [SerializeField] TextMeshProUGUI text;
    float score = 0;
    float currentScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null){
            instance = this;
        }
        score = currentScore;
        currentScore = score;
    }

    public void ChangeScore(float acornValue){
        score += acornValue;
        text.text = "ACORNS: " + score.ToString();
    }

    void Update()
    {
        
    }
}

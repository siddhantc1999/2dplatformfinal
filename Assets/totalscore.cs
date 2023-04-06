using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class totalscore : MonoBehaviour
{
    public int coins = 0;
    public int lives = 3;
    [SerializeField] TextMeshProUGUI mytext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void publishscore()
    {
        mytext.text = "SCORE: " + coins.ToString();
    }
}

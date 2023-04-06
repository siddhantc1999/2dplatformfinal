using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coinscore : MonoBehaviour
{
   
    public int coins=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="player")
        {
            GetComponentInParent<totalscore>().coins+=1;
            GetComponentInParent<totalscore>().publishscore();

            Destroy(gameObject);
        }
        
    }
}

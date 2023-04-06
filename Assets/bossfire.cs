using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossfire : MonoBehaviour
{
    public int bosshelath=10;
    [SerializeField] GameObject firstfire;
    [SerializeField] GameObject finalfire;
    bool keepfire=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(bosshelath>=0 && !keepfire)
        {
            GameObject firstfiregameobject = Instantiate(firstfire,transform.position,Quaternion.identity);
            keepfire = true;
        }
        else
        {
            GameObject firstfiregameobject = Instantiate(finalfire, transform.position, Quaternion.identity);
        }
            
    }
}

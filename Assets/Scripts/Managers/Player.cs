using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Managers mg = Managers.Instance;

        //GameObject go = GameObject.Find("@Managers"); //부하가 심하다.
        //Managers mg = go.GetComponent<Managers>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

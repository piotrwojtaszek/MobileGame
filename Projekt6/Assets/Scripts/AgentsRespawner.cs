using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentsRespawner : MonoBehaviour
{
    public GameObject agent;

    // Start is called before the first frame update
    void Awake()
    {
        int count = 0;
        for(int j = 3; j > -7; j--)
        {
            
            for (int i = -16; i < 62; i++)
            {
                count++;
                Vector3 rand = new Vector3(i, 0, j);
                GameObject temp = Instantiate(agent, transform.position + rand, transform.rotation);
            }

        }
        Debug.Log(count);
    }
    


    void Update()
    {
        
    }
}

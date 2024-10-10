using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameObject prefab;
    public int howMany;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tmpAstroid;
        AstroidMove am;
        for (int i = 0; i < howMany; i++)
        {

            tmpAstroid = Instantiate(prefab, new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0), Quaternion.identity);


            am = tmpAstroid.GetComponent<AstroidMove>();

            am.mx = Random.Range(-8, 8);
            am.my = Random.Range(-8, 8);
            am.rotz = Random.Range(-3, 3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

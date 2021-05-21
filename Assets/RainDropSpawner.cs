using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDropSpawner : MonoBehaviour
{
    [SerializeField] GameObject rainDrop;
    [SerializeField] Vector3 minScaleValue;
    [SerializeField] Vector3 maxScaleValue;
    [SerializeField] Vector3 minPosValue;
    [SerializeField] Vector3 maxPosValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LetItRain()
    {
        GameObject g = Instantiate(rainDrop, Vector3.zero, Quaternion.identity);

        g.transform.localScale = new Vector3(Random.Range(minScaleValue.x, maxScaleValue.x), Random.Range(minScaleValue.y, maxScaleValue.y), Random.Range(minScaleValue.z, maxScaleValue.z));


    }
}

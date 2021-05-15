using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    #region Attributes

    [Header("Attributes")]
    public float speed;
    public bool isDrenched;


    [Header("Component References")]
    public Transform target;
    public NavMeshAgent agent;
    #endregion

    #region Monobehaviour Functions
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Water")
        {
            isDrenched = true;
            //Change mesh color
        }

        if(collision.gameObject.tag == "Bomb")
        {

        }
    }
    #endregion

}

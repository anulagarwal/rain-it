using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Character : MonoBehaviour
{
    #region Attributes
    [Header("Attributes")]
    [SerializeField] float speed;

    [Header ("Component References")]
    [SerializeField] Transform bombPos;
    [SerializeField] Transform escapePos;
    [SerializeField] NavMeshAgent agent;



    #endregion

    #region Monobehaviour Functions
    // Start is called before the first frame update
    void Start()
    {
        bombPos = GameObject.FindGameObjectWithTag("BombPos").transform;
        escapePos = GameObject.FindGameObjectWithTag("EscapePos").transform;

        Move(bombPos.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Move(Vector3 pos)
    {
        agent.SetDestination(pos);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            Move(escapePos.position);
        }
    }

    #endregion


    #region Core Functions

    public void Escape()
    {
        Move(escapePos.position);
        print("escape");
    }
    #endregion
}

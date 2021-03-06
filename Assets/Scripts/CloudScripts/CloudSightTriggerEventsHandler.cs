using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSightTriggerEventsHandler : MonoBehaviour
{
    #region Properties
    private CloudVFXHandler cloudVFXHandler = null;
    #endregion

    #region MonoBehaviour Functions
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Target")
        {
            CloudCustomComponentsHandler.Instance.GetCloudDataHandler.CharacterObjects.Add(other.gameObject);
        }
        if(other.gameObject.tag == "Character")
        {
            CloudCustomComponentsHandler.Instance.GetCloudDataHandler.CharacterObjects.Add(other.gameObject);
            other.gameObject.GetComponent<Character>().Escape();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Target")
        {
            CloudCustomComponentsHandler.Instance.GetCloudDataHandler.CharacterObjects.Remove(other.gameObject);
        }
        if (other.gameObject.tag == "Character")
        {
            CloudCustomComponentsHandler.Instance.GetCloudDataHandler.CharacterObjects.Remove(other.gameObject);

        }
    }
    #endregion
}

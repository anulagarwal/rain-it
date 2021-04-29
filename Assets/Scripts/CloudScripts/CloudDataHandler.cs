using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDataHandler : MonoBehaviour
{
    #region Properties
    private List<GameObject> characterObjects = new List<GameObject>();
    #endregion

    #region MonoBehaviour Functions
    #endregion

    #region Getter And Setter
    public List<GameObject> CharacterObjects { get => characterObjects; set { characterObjects = value; } }
    #endregion
}

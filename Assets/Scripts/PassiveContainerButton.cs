using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveContainerButton : MonoBehaviour
{
    public GameObject skillTree;

    public void SetActive()
    {
        skillTree.SetActive(!skillTree.activeSelf);
    }
}

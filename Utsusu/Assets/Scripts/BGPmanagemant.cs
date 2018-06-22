using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BGPmanagemant : MonoBehaviour
{
    public GameObject[] BGP;
    private void Start()
    {
        BGP[0].SetActive(false);
    }
}

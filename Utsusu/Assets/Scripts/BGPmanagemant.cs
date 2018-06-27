using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BGPmanagemant : MonoBehaviour
{
    public SceneChange MyNum;
    public GameObject[] BGP;

    private void Start()
    {
        BGP[0].SetActive(false);
        BGP[1].SetActive(false);
        BGP[2].SetActive(false);
    }
    private void Update()
    {
        if (MyNum.GetOrigin() < 9)
        {
            BGP[0].SetActive(true);
        }
        else if (MyNum.GetOrigin() > 8&&MyNum.GetOrigin()<17)
        {
            BGP[1].SetActive(true);
        }
        else if (MyNum.GetOrigin() > 16 && MyNum.GetOrigin() < 25)
        {
            BGP[2].SetActive(true);
        }
    }
}

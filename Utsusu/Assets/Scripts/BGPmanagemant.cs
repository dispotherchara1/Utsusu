using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BGPmanagemant : MonoBehaviour
{

    public GameObject[] BGP;
    public mynumber MyNum;

    private void Start()
    {
        BGP[0].SetActive(false);
        BGP[1].SetActive(false);
        BGP[2].SetActive(false);
    }
    private void Update()
    {
        if (MyNum.GetstageNum() < 9)
        {
            BGP[0].SetActive(true);
        }
        else if (MyNum.GetstageNum() > 8&&MyNum.GetstageNum()<17)
        {
            BGP[1].SetActive(true);
        }
        else if (MyNum.GetstageNum() > 16 && MyNum.GetstageNum() < 25)
        {
            BGP[2].SetActive(true);
        }

    }
}

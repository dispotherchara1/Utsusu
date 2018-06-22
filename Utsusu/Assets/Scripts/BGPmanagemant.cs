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
    }
    private void Update()
    {
        if (MyNum.GetstageNum() >= 8)
        {
            BGP[1].SetActive(false);
            BGP[0].SetActive(true);
        }
        if (MyNum.GetstageNum() <= 9&&MyNum.GetstageNum()>=16)
        {
            BGP[0].SetActive(false);
            BGP[1].SetActive(true);
        }
    }
}

using Photon.Pun;
using Photon.VR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfflinePlayer : MonoBehaviour
{
     [Header("Script made by Danix, please give credits if used!!")]
    public GameObject offlineRig;

    public void Update()
    {
        if(PhotonNetwork.InRoom == false)
        {
            offlineRig.SetActive(true);
        }

        if (PhotonNetwork.InRoom)
        {
            offlineRig.SetActive(false);
        }
    }
}

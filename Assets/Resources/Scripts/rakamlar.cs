using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class rakamlar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bir, iki, uc, dort, bes, altı, yedi, sekiz, dokuz;

    [Obsolete]
    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i=0; i<vrb.Length; i++){
            vrb[i].RegisterOnButtonPressed(OnButtonPressed);
            vrb[i].RegisterOnButtonReleased(OnButtonReleased);
            bir.SetActive(false);
            iki.SetActive(false);
            uc.SetActive(false);
            dort.SetActive(false);
            bes.SetActive(false);
            altı.SetActive(false);
            yedi.SetActive(false);
            sekiz.SetActive(false);
            dokuz.SetActive(false);
        }
    }

    [Obsolete]
    private void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "bir"){
            bir.SetActive(true);
            iki.SetActive(false);
            uc.SetActive(false);
            dort.SetActive(false);
            bes.SetActive(false);
            altı.SetActive(false);
            yedi.SetActive(false);
            sekiz.SetActive(false);
            dokuz.SetActive(false);
        }

        else if(vb.VirtualButtonName == "iki"){
            bir.SetActive(false);
            iki.SetActive(true);
            uc.SetActive(false);
            dort.SetActive(false);
            bes.SetActive(false);
            altı.SetActive(false);
            yedi.SetActive(false);
            sekiz.SetActive(false);
            dokuz.SetActive(false);
        }

        else if(vb.VirtualButtonName == "uc"){
            bir.SetActive(false);
            iki.SetActive(false);
            uc.SetActive(true);
            dort.SetActive(false);
            bes.SetActive(false);
            altı.SetActive(false);
            yedi.SetActive(false);
            sekiz.SetActive(false);
            dokuz.SetActive(false);
        }

        else if(vb.VirtualButtonName == "dort"){
            bir.SetActive(false);
            iki.SetActive(false);
            uc.SetActive(false);
            dort.SetActive(true);
            bes.SetActive(false);
            altı.SetActive(false);
            yedi.SetActive(false);
            sekiz.SetActive(false);
            dokuz.SetActive(false);
        }

        else if(vb.VirtualButtonName == "bes"){
            bir.SetActive(false);
            iki.SetActive(false);
            uc.SetActive(false);
            dort.SetActive(false);
            bes.SetActive(true);
            altı.SetActive(false);
            yedi.SetActive(false);
            sekiz.SetActive(false);
            dokuz.SetActive(false);
        }

        else if(vb.VirtualButtonName == "altı"){
            bir.SetActive(false);
            iki.SetActive(false);
            uc.SetActive(false);
            dort.SetActive(false);
            bes.SetActive(false);
            altı.SetActive(true);
            yedi.SetActive(false);
            sekiz.SetActive(false);
            dokuz.SetActive(false);
        }

        else if(vb.VirtualButtonName == "yedi"){
            bir.SetActive(false);
            iki.SetActive(false);
            uc.SetActive(false);
            dort.SetActive(false);
            bes.SetActive(false);
            altı.SetActive(false);
            yedi.SetActive(true);
            sekiz.SetActive(false);
            dokuz.SetActive(false);
        }

        else if(vb.VirtualButtonName == "sekiz"){
            bir.SetActive(false);
            iki.SetActive(false);
            uc.SetActive(false);
            dort.SetActive(false);
            bes.SetActive(false);
            altı.SetActive(false);
            yedi.SetActive(false);
            sekiz.SetActive(true);
            dokuz.SetActive(false);
        }

        else if(vb.VirtualButtonName == "dokuz"){
            bir.SetActive(false);
            iki.SetActive(false);
            uc.SetActive(false);
            dort.SetActive(false);
            bes.SetActive(false);
            altı.SetActive(false);
            yedi.SetActive(false);
            sekiz.SetActive(false);
            dokuz.SetActive(true);
        }

        else{
            throw new UnityException(vb.VirtualButtonName + " butonu bulunamadı.");
        }
    }

    [Obsolete]
    private void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        UnityEngine.Debug.Log(vb.VirtualButtonName + " butonu serbest bırakıldı.");
    }
}

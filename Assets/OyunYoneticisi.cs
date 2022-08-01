using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OyunYoneticisi : MonoBehaviour
{[SerializeField]Text deneme;
[SerializeField]durum baslangic;
durum GuncelDurum;
    // Start is called before the first frame update
    void Start()
    { GuncelDurum=baslangic;
        deneme.text=baslangic.durumhikayesial();
    }

    // Update is called once per frame
    void Update()
  
    { 
          var sonrakidurum= GuncelDurum.sonrakidurumlaral();
          if(Input.GetKeyDown(KeyCode.Alpha1)){
              GuncelDurum=sonrakidurum[0];
          }else if (Input.GetKeyDown(KeyCode.Alpha2)){
              GuncelDurum=sonrakidurum[1];
          }else if(Input.GetKeyDown(KeyCode.Alpha3)){GuncelDurum=sonrakidurum[2];}

        deneme.text = GuncelDurum.durumhikayesial();
    }
}

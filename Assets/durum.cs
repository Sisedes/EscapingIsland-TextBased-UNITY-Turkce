using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName="Durum")]
public class durum : ScriptableObject
{
    [TextArea(12,12)][SerializeField] public string hikaye;
    [SerializeField] durum[] secimler;
    public string durumhikayesial()
    {
          return hikaye;
    }
    public durum[] sonrakidurumlaral()
    {
      return secimler;  
    }
}

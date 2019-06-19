using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ControleAds : MonoBehaviour
{

    public Text textoMoedas, textoGemas;

    private int moedas = 0, gemas = 0;
    string myidPlacement;

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Show();
    }

    public void ShowRewardedAd(string idPlacement)
    {
        myidPlacement = idPlacement;

        if(Advertisement.IsReady(idPlacement))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show(idPlacement, options);
        }
    }

    private void HandleShowResult( ShowResult resultCallback )
    {
        switch(resultCallback)
        {
            case ShowResult.Finished:
                Debug.Log("Propaganda Ok!");

                if(myidPlacement == "moedas")
                {
                    GanhaMoedas();    
                }
                else if(myidPlacement == "gemas")
                {
                    GanhaGemas();
                }

            break;
            case ShowResult.Skipped:
                Debug.Log("Você pulou a propaganda!");
            break;
            case ShowResult.Failed:
                Debug.Log("Houve um erro ou falha!");
            break;
        }
    }

    void GanhaMoedas()
    {
        moedas += 10;
        textoMoedas.text = moedas.ToString();
        Debug.Log(moedas);
    }

    void GanhaGemas()
    {
        gemas += 5;
        textoGemas.text = gemas.ToString();
        Debug.Log(moedas);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FungsiTombol : MonoBehaviour {
    public GameObject panelmainMenu;
    public GameObject panelCara;
    public GameObject panelLogo;

    public void PindahScene(string namascene)
    {
        SceneManager.LoadScene(namascene);
    }

    public void BukaMainMenu()
    {
        panelmainMenu.SetActive(true);
        panelCara.SetActive(false);
        panelLogo.SetActive(false);
    }
    public void BukaCara()
    {
        panelmainMenu.SetActive(false);
        panelCara.SetActive(true);
        panelLogo.SetActive(false);
    }
    public void BukaLogo()
    {
        panelmainMenu.SetActive(false);
        panelCara.SetActive(false);
        panelLogo.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string NomeFase;
    public GameObject PainelMenuPrincipal;
    public GameObject PainelOp�ao;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AbrirMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Play()
    {
        SceneManager.LoadScene("NewFirstBoss");
    }
    public void AbrirOp�ao()
    {
        PainelMenuPrincipal.SetActive(false);

        PainelOp�ao.SetActive(true);
    }
    public void FecharOp�ao()
    {
        PainelMenuPrincipal.SetActive(true);

        PainelOp�ao.SetActive(false);
    }
    public void Sair()
    {

        Application.Quit();
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Oi()
    {
        SceneManager.LoadScene("Controles");
    }
}
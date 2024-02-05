using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void escena1()
    {
        SceneManager.LoadScene(1);
    }
    public void escena2()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        Debug.Log("cerrando");
        Application.Quit();

    }

}

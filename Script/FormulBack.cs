using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FormulBack : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Play");
    }
}


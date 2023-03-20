using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playvideo : MonoBehaviour
{
    public void Playvideo()
    {
        SceneManager.LoadScene("video");
    }
    public void Scenes()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

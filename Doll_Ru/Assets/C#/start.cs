using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        SceneManager.LoadScene("Main");
    }
    /*
    public void Scenes()
    {
        SceneManager.LoadScene("SampleScene");
    }*/
}

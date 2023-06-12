using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChanger(int Index)
    {
        SceneManager.LoadScene(Index);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileLister : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string cwd = Directory.GetCurrentDirectory();
        foreach (string path in Directory.GetFiles(cwd + "\\Assets\\cc1bin\\")) {
            if (path.EndsWith(".bin")) {
                Debug.Log(path);
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

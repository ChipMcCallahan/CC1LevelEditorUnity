using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using p = Cc1LevelsetUtils;

public class FileLister : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, p.Levelset> sets = new Dictionary<string, p.Levelset>();
        string cwd = Directory.GetCurrentDirectory();
        foreach (string path in Directory.GetFiles(cwd + "\\Assets\\cc1bin\\")) {
            if (path.EndsWith(".bin")) {
                using (var input = File.OpenRead(path))
                {
                    sets.Add(path, p.Levelset.Parser.ParseFrom(input));
                }
            } 
        }

        foreach(KeyValuePair<string, p.Levelset> entry in sets)
        {
            Debug.Log(entry.Key);
            Debug.Log(entry.Value.Levels.Count);
            // do something with entry.Value or entry.Key
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

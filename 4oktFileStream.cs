using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class NameService
{
    private List<string> names;
    private string filePath = "names.json";
    public NameService()
    {
        if (File.Exists(filePath))
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                var json = reader.ReadToEnd();
                names = JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string>();
            }
        }
        else
        {
            names = new List<string>();
        }
    }
    private void SaveToFile()
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (StreamWriter writer = new StreamWriter(fs))
        {
            var json = JsonConvert.SerializeObject(names, Newtonsoft.Json.Formatting.Indented);
            writer.Write(json);
        }
    }
    public void Add(string name)
    {
        names.Add(name);
        SaveToFile();
    }
    public bool Exist(string name)
    {
        return names.Contains(name);
    }
    public void Update(int index, string name)
    {
        if (index >= 0 && index < names.Count)
        {
            names[index] = name;
            SaveToFile();
        }
        else
        {
            throw new IndexOutOfRangeException("Invalid index");
        }
    }
    public void Delete(int index)
    {
        if (index >= 0 && index < names.Count)
        {
            names.RemoveAt(index);
            SaveToFile();
        }
        else
        {
            throw new IndexOutOfRangeException("Invalid index");
        }
    }
    public List<string> GetAllNames()
    {
        return names;
    }
}

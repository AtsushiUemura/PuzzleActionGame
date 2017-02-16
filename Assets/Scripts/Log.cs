using UnityEngine;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class Log {

    private static string path = "./";
    private static string fileName = "Log";
    private static bool addWritable = true;
    private static string encoding = "shift_jis";

    private static List<string> LogList = new List<string>();

    /// <summary>
    /// Listクリア
    /// </summary>
    private static void Clear() {
        LogList.Clear();
    }
    /// <summary>
    /// List表示
    /// </summary>
    private static void Display() {
        foreach (var item in LogList) {
            Debug.Log(item);
        }
    }
    /// <summary>
    /// 書き込み
    /// </summary>
    /// <param name="log"></param>
    public static void Write(string log) {
        StreamWriter sw = new StreamWriter(path + fileName, addWritable, Encoding.GetEncoding(encoding));
        sw.Write("CALLED: " + log + "\n");
        sw.Close();
    }
    /// <summary>
    /// 読み込み
    /// </summary>
    public static void Read() {
        Clear();
        StreamReader sr = new StreamReader(path + fileName, Encoding.GetEncoding(encoding));
        Debug.Log(sr.Peek());
        while (sr.Peek() >= 0) {
            string tmp = sr.ReadLine();
            LogList.Add(tmp);
        }
        sr.Close();
        Display();
    }

}

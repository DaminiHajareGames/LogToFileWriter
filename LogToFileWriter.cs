using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace CommonOfDamini.Logs {
    public class LogToFileWriter
    {
        public static string _indentifier = "Default";

        public static void CreateLog(string log) {

            CreateLog(_indentifier, log);

        }

        public static void CreateLog(string indentifier, string log)
        {
            string path = Application.persistentDataPath + "/" + "log_" + indentifier + ".txt";
            UnityEngine.Debug.LogWarning($"CreateLog : {path}");
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine($"{DateTime.Now.ToString() } : : : {log}");
                }
            }
            else
            {
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{DateTime.Now.ToString() } : : : {log}");
                }
            }
        }
    }
}

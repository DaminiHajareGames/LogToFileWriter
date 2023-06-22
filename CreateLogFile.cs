using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommonOfDamini.Logs
{
    public class CreateLogFile : MonoBehaviour
    {
        private void Awake()
        {
            LogToFileWriter._indentifier = System.DateTime.Now.Ticks.ToString();
            LogToFileWriter.CreateLog($"Init Logs for : {LogToFileWriter._indentifier}");
        }
    }

    public class Debug
    {
        public static void Log(string log)
        {
            UnityEngine.Debug.Log(log);
            LogToFileWriter.CreateLog(log);
        }

        public static void LogError(string log)
        {
            UnityEngine.Debug.LogError(log);
            LogToFileWriter.CreateLog($"[ERROR]== {log}");
        }
    }

}
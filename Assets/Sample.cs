using UnityEngine;

public class Sample : MonoBehaviour
{
    protected void OnGUI()
    {
        MemoryUsageChecker checker = MemoryUsageChecker.Instance;

        GUILayout.BeginArea(new Rect(50, 50, 300, 300));

        GUILayout.Label("TotalReserved  : " + checker.TotalReserved.ToString("F1")
                                    + " / " + checker.TotalReservedAvg.ToString("F1")
                                    + " / " + checker.TotalReservedMax.ToString("F1"));

        GUILayout.Label("TotalAllocated  : " + checker.TotalAllocated.ToString("F1")
                                     + " / " + checker.TotalAllocatedAvg.ToString("F1")
                                     + " / " + checker.TotalAllocatedMax.ToString("F1"));

        GUILayout.Label("MonoHeap  : " + checker.MonoHeap.ToString("F1")
                               + " / " + checker.MonoHeapAvg.ToString("F1")
                               + " / " + checker.MonoHeapMax.ToString("F1"));
        GUILayout.Label("MonoUsed  : " + checker.MonoUsed.ToString("F1")
                               + " / " + checker.MonoUsedAvg.ToString("F1")
                               + " / " + checker.MonoUsedMax.ToString("F1"));
        GUILayout.EndArea();
    }
}
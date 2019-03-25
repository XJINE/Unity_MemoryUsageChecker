using UnityEngine;
using UnityEngine.Profiling;

public class MemoryUsageChecker : SingletonMonoBehaviour<MemoryUsageChecker>
{
    #region Field

    [SerializeField, DisableInInspector]
    private float totalReserved;
    [SerializeField, DisableInInspector]
    private float totalReservedAvg;
    [SerializeField, DisableInInspector]
    private float totalReservedMax;

    [SerializeField, DisableInInspector]
    private float totalAllocated;
    [SerializeField, DisableInInspector]
    private float totalAllocatedAvg;
    [SerializeField, DisableInInspector]
    private float totalAllocatedMax;

    [SerializeField, DisableInInspector]
    private float monoHeap;
    [SerializeField, DisableInInspector]
    private float monoHeapAvg;
    [SerializeField, DisableInInspector]
    private float monoHeapMax;

    [SerializeField, DisableInInspector]
    private float monoUsed;
    [SerializeField, DisableInInspector]
    private float monoUsedAvg;
    [SerializeField, DisableInInspector]
    private float monoUsedMax;

    #endregion Field

    #region Property

    public float TotalReserved    { get { return this.totalReserved;    } }
    public float TotalReservedAvg { get { return this.totalReservedAvg; } }
    public float TotalReservedMax { get { return this.totalReservedMax; } }

    public float TotalAllocated    { get { return this.totalAllocated;    } }
    public float TotalAllocatedAvg { get { return this.totalAllocatedAvg; } }
    public float TotalAllocatedMax { get { return this.totalAllocatedMax; } }

    public float MonoHeap    { get { return this.monoHeap;    } }
    public float MonoHeapAvg { get { return this.monoHeapAvg; } }
    public float MonoHeapMax { get { return this.monoHeapMax; } }

    public float MonoUsed    { get { return this.monoUsed;    } }
    public float MonoUsedAvg { get { return this.monoUsedAvg; } }
    public float MonoUsedMax { get { return this.monoUsedMax; } }

    #endregion Property

    #region Method

    protected virtual void LateUpdate()
    {
        this.totalReserved  = ByteToMByte(Profiler.GetTotalReservedMemoryLong());
        this.totalAllocated = ByteToMByte(Profiler.GetTotalAllocatedMemoryLong());
        this.monoHeap = ByteToMByte(Profiler.GetMonoHeapSizeLong());
        this.monoUsed = ByteToMByte(Profiler.GetMonoUsedSizeLong());

        this.totalReservedAvg = (this.totalReservedAvg + this.totalReserved) / 2;
        this.totalReservedMax = Mathf.Max(this.totalReservedMax, this.totalReserved);

        this.totalAllocatedAvg = (this.totalAllocatedAvg + this.totalAllocated) / 2;
        this.totalAllocatedMax = Mathf.Max(this.totalAllocatedMax, this.totalAllocated);

        this.monoHeapAvg = (this.monoHeapAvg + this.monoHeap) / 2;
        this.monoHeapMax = Mathf.Max(this.monoHeapMax, this.monoHeap);

        this.monoUsedAvg = (this.monoUsedAvg + this.monoUsed) / 2;
        this.monoUsedMax = Mathf.Max(this.monoUsedMax, this.monoUsed);
    }

    protected static float ByteToMByte(long @byte)
    {
        return @byte / 1048576f;
    }

    #endregion Method
}
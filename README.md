# Unity_MemoryUsageChecker

<img src="https://github.com/XJINE/Unity_MemoryUsageChecker/blob/master/Screenshot.png" width="100%" height="auto" />

MemoryUsageChecker gets memory usage simply.

## Import to Your Project

You can import this asset from UnityPackage.

- [MemoryUsageChecker.unitypackage](https://github.com/XJINE/Unity_MemoryUsageChecker/blob/master/MemoryUsageChecker.unitypackage)

### Dependencies

You have to import following assets to use this asset.

- [Unity_SingletonMonoBehaviour](https://github.com/XJINE/Unity_SingletonMonoBehaviour)
- [Unity_DisableInInspectorAttribute](https://github.com/XJINE/Unity_DisableInInspectorAttribute)

## How to Use

You can access memory usage data like ``MemoryUsageChecker.Instance.TotalReserved``.
Following data are available.

- TotalReserved
- TotalReservedAvg
- TotalReservedMax
- TotalAllocated
- TotalAllocatedAvg
- TotalAllocatedMax
- MonoHeap
- MonoHeapAvg
- MonoHeapMax
- MonoUsed
- MonoUsedAvg
- MonoUsedMax
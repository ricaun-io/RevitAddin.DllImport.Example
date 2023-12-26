#pragma once
class Math {
public:
	int Add(int a, int b);
};

extern "C" __declspec(dllexport) void* MathCreate()
{
	return (void*) new Math();
}

extern "C" __declspec(dllexport) int MathAdd(Math * math, int a, int b)
{
	return math->Add(a, b);
}
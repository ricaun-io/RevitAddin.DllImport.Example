// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"

// This v�deo explains how to create a DLL in C++:
// https://www.youtube.com/watch?v=3efOjwKb9p4

/*
BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}
*/
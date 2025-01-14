using System;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_Set_Platform_GetWindowPos(ImGuiPlatformIO* platform_io, IntPtr funcPtr);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_Set_Platform_GetWindowSize(ImGuiPlatformIO* platform_io, IntPtr funcPtr);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ImplDX11_CreateDeviceObjects();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public unsafe static extern byte ImGui_ImplDX11_Init(void* device, void* device_context);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX11_InvalidateDeviceObjects();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX11_NewFrame();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public unsafe static extern void ImGui_ImplDX11_RenderDrawData(ImDrawData* draw_data);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX11_Shutdown();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ImplDX9_CreateDeviceObjects();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public unsafe static extern byte ImGui_ImplDX9_Init(void* device);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX9_InvalidateDeviceObjects();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX9_NewFrame();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public unsafe static extern void ImGui_ImplDX9_RenderDrawData(ImDrawData* draw_data);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplDX9_Shutdown();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplWin32_EnableDpiAwareness();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public unsafe static extern float ImGui_ImplWin32_GetDpiScaleForHwnd(void* hwnd);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public unsafe static extern float ImGui_ImplWin32_GetDpiScaleForMonitor(void* monitor);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public unsafe static extern byte ImGui_ImplWin32_Init(void* hwnd);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplWin32_NewFrame();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplWin32_Shutdown();

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGui_ImplWin32_WndProcHandler(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndColumns();
    }
}

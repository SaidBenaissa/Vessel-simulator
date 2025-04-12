using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;

class Program
{
    static void Main()
    {
        var nativeSettings = new NativeWindowSettings()
        {
            Size = new Vector2i(800, 600),
            Title = "OpenGL + C# on macOS"
        };

        using (var window = new GameWindow(GameWindowSettings.Default, nativeSettings))
        {
            window.Load += () =>
            {
                // Set clear color to cornflower blue
                GL.ClearColor(0.39f, 0.58f, 0.93f, 1.0f);
            };

            window.RenderFrame += (frameEventArgs) =>
            {
                GL.Clear(ClearBufferMask.ColorBufferBit);
                window.SwapBuffers();
            };

            window.Run();
        }
    }
}

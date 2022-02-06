using System;
using System.IO;
using System.Runtime.Versioning;
using System.Text;
using SConsole = System.Console;
namespace AnsiConsole
{
    /// <summary>Represents the standard input, output, and error streams for console applications with extensions for easier color manipulation. This class cannot be inherited.</summary>
    public static class Console
    {
        /// <summary>Gets or sets the background color of the console.</summary>
        /// <exception cref="T:System.ArgumentException">The color specified in a set operation is not a valid member of <see cref="T:System.ConsoleColor" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <returns>A value that specifies the background color of the console; that is, the color that appears behind each character. The default is black.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static ConsoleColor BackgroundColor
        {
            get => SConsole.BackgroundColor;
            set => SConsole.BackgroundColor = value;
        }

        /// <summary>Gets or sets the height of the buffer area.</summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.
        ///
        ///  -or-
        ///
        ///  The value in a set operation is greater than or equal to <see cref="F:System.Int16.MaxValue" />.
        ///
        ///  -or-
        ///
        ///  The value in a set operation is less than <see cref="P:System.Console.WindowTop" /> + <see cref="P:System.Console.WindowHeight" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
        /// <returns>The current height, in rows, of the buffer area.</returns>
        public static int BufferHeight
        {
            [UnsupportedOSPlatform("android")]
            [UnsupportedOSPlatform("browser")]
            [UnsupportedOSPlatform("ios")]
            [UnsupportedOSPlatform("tvos")]
            get => SConsole.BufferHeight;
            [SupportedOSPlatform("windows")]
            set => SConsole.BufferHeight = value;
        }

        /// <summary>Gets or sets the width of the buffer area.</summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.
        ///
        ///  -or-
        ///
        ///  The value in a set operation is greater than or equal to <see cref="F:System.Int16.MaxValue" />.
        ///
        ///  -or-
        ///
        ///  The value in a set operation is less than <see cref="P:System.Console.WindowLeft" /> + <see cref="P:System.Console.WindowWidth" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
        /// <returns>The current width, in columns, of the buffer area.</returns>
        public static int BufferWidth
        {
            [UnsupportedOSPlatform("android")]
            [UnsupportedOSPlatform("browser")]
            [UnsupportedOSPlatform("ios")]
            [UnsupportedOSPlatform("tvos")]
            get => SConsole.BufferWidth;
            [SupportedOSPlatform("windows")]
            set => SConsole.BufferWidth = value;
        }

        /// <summary>Gets a value indicating whether the CAPS LOCK keyboard toggle is turned on or turned off.</summary>
        /// <exception cref="T:System.PlatformNotSupportedException">The get operation is invoked on an operating system other than Windows.</exception>
        /// <returns>
        ///   <see langword="true" /> if CAPS LOCK is turned on; <see langword="false" /> if CAPS LOCK is turned off.</returns>
        [SupportedOSPlatform("windows")]
        public static bool CapsLock
        {
            get => SConsole.CapsLock;
        }

        /// <summary>Gets or sets the column position of the cursor within the buffer area.</summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than zero.
        ///
        ///  -or-
        ///
        ///  The value in a set operation is greater than or equal to <see cref="P:System.Console.BufferWidth" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <returns>The current position, in columns, of the cursor.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static int CursorLeft
        {
            get => SConsole.CursorLeft;
            set => SConsole.CursorLeft = value;
        }

        /// <summary>Gets or sets the height of the cursor within a character cell.</summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is less than 1 or greater than 100.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
        /// <returns>The size of the cursor expressed as a percentage of the height of a character cell. The property value ranges from 1 to 100.</returns>
        public static int CursorSize
        {
            [UnsupportedOSPlatform("android")]
            [UnsupportedOSPlatform("browser")]
            [UnsupportedOSPlatform("ios")]
            [UnsupportedOSPlatform("tvos")]
            get => SConsole.CursorSize;
            [SupportedOSPlatform("windows")]
            set => SConsole.CursorSize = value;
        }

        /// <summary>Gets or sets the row position of the cursor within the buffer area.</summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than zero.
        ///
        ///  -or-
        ///
        ///  The value in a set operation is greater than or equal to <see cref="P:System.Console.BufferHeight" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <returns>The current position, in rows, of the cursor.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static int CursorTop
        {
            get => SConsole.CursorTop;
            set => SConsole.CursorTop = value;
        }

        /// <summary>Gets or sets a value indicating whether the cursor is visible.</summary>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The get operation is invoked on an operating system other than Windows.</exception>
        /// <returns>
        ///   <see langword="true" /> if the cursor is visible; otherwise, <see langword="false" />.</returns>
        public static bool CursorVisible
        {
            [SupportedOSPlatform("windows")]
            get => SConsole.CursorVisible;
            [UnsupportedOSPlatform("android")]
            [UnsupportedOSPlatform("browser")]
            [UnsupportedOSPlatform("ios")]
            [UnsupportedOSPlatform("tvos")]
            set => SConsole.CursorVisible = value;
        }

        /// <summary>Gets the standard error output stream.</summary>
        /// <returns>A <see cref="T:System.IO.TextWriter" /> that represents the standard error output stream.</returns>
        public static TextWriter Error => SConsole.Error;

        /// <summary>Gets or sets the foreground color of the console.</summary>
        /// <exception cref="T:System.ArgumentException">The color specified in a set operation is not a valid member of <see cref="T:System.ConsoleColor" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <returns>A <see cref="T:System.ConsoleColor" /> that specifies the foreground color of the console; that is, the color of each character that is displayed. The default is gray.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static ConsoleColor ForegroundColor
        {
            get => SConsole.ForegroundColor;
            set => SConsole.ForegroundColor = value;
        }

        /// <summary>Gets the standard input stream.</summary>
        /// <returns>A <see cref="T:System.IO.TextReader" /> that represents the standard input stream.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static TextReader In => SConsole.In;

        /// <summary>Gets or sets the encoding the console uses to read input.</summary>
        /// <exception cref="T:System.ArgumentNullException">The property value in a set operation is <see langword="null" />.</exception>
        /// <exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception>
        /// <exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception>
        /// <returns>The encoding used to read console input.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static Encoding InputEncoding
        {
            get => SConsole.InputEncoding;
            set => SConsole.InputEncoding = value;
        }

        /// <summary>Gets a value that indicates whether the error output stream has been redirected from the standard error stream.</summary>
        /// <returns>
        ///   <see langword="true" /> if error output is redirected; otherwise, <see langword="false" />.</returns>
        public static bool IsErrorRedirected => SConsole.IsErrorRedirected;

        /// <summary>Gets a value that indicates whether input has been redirected from the standard input stream.</summary>
        /// <returns>
        ///   <see langword="true" /> if input is redirected; otherwise, <see langword="false" />.</returns>
        public static bool IsInputRedirected => SConsole.IsInputRedirected;

        /// <summary>Gets a value that indicates whether output has been redirected from the standard output stream.</summary>
        /// <returns>
        ///   <see langword="true" /> if output is redirected; otherwise, <see langword="false" />.</returns>
        public static bool IsOutputRedirected => SConsole.IsOutputRedirected;

        /// <summary>Gets a value indicating whether a key press is available in the input stream.</summary>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.InvalidOperationException">Standard input is redirected to a file instead of the keyboard.</exception>
        /// <returns>
        ///   <see langword="true" /> if a key press is available; otherwise, <see langword="false" />.</returns>
        public static bool KeyAvailable => SConsole.KeyAvailable;

        /// <summary>Gets the largest possible number of console window rows, based on the current font and screen resolution.</summary>
        /// <returns>The height of the largest possible console window measured in rows.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static int LargestWindowHeight => SConsole.LargestWindowHeight;

        /// <summary>Gets the largest possible number of console window columns, based on the current font and screen resolution.</summary>
        /// <returns>The width of the largest possible console window measured in columns.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static int LargestWindowWidth => SConsole.LargestWindowWidth;

        /// <summary>Gets a value indicating whether the NUM LOCK keyboard toggle is turned on or turned off.</summary>
        /// <exception cref="T:System.PlatformNotSupportedException">The get operation is invoked on an operating system other than Windows.</exception>
        /// <returns>
        ///   <see langword="true" /> if NUM LOCK is turned on; <see langword="false" /> if NUM LOCK is turned off.</returns>
        [SupportedOSPlatform("windows")]
        public static bool NumberLock => SConsole.NumberLock;

        /// <summary>Gets the standard output stream.</summary>
        /// <returns>A <see cref="T:System.IO.TextWriter" /> that represents the standard output stream.</returns>
        public static TextWriter Out => SConsole.Out;

        /// <summary>Gets or sets the encoding the console uses to write output.</summary>
        /// <exception cref="T:System.ArgumentNullException">The property value in a set operation is <see langword="null" />.</exception>
        /// <exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception>
        /// <exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception>
        /// <returns>The encoding used to write console output.</returns>
        public static Encoding OutputEncoding
        {
            get => SConsole.OutputEncoding;
            [UnsupportedOSPlatform("android")]
            [UnsupportedOSPlatform("ios")]
            [UnsupportedOSPlatform("tvos")]
            set => SConsole.OutputEncoding = value;
        }

        /// <summary>Gets or sets the title to display in the console title bar.</summary>
        /// <exception cref="T:System.InvalidOperationException">In a get operation, the retrieved title is longer than 24500 characters.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the specified title is longer than 24500 characters.</exception>
        /// <exception cref="T:System.ArgumentNullException">In a set operation, the specified title is <see langword="null" />.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The get operation is invoked on an operating system other than Windows.</exception>
        /// <returns>The string to be displayed in the title bar of the console. The maximum length of the title string is 24500 characters.</returns>
        public static string Title
        {
            [SupportedOSPlatform("windows")]
            get => SConsole.Title;
            [UnsupportedOSPlatform("android")]
            [UnsupportedOSPlatform("browser")]
            [UnsupportedOSPlatform("ios")]
            [UnsupportedOSPlatform("tvos")]
            set => SConsole.Title = value;
        }

        /// <summary>Gets or sets a value indicating whether the combination of the <see cref="F:System.ConsoleModifiers.Control" /> modifier key and <see cref="F:System.ConsoleKey.C" /> console key (Ctrl+C) is treated as ordinary input or as an interruption that is handled by the operating system.</summary>
        /// <exception cref="T:System.IO.IOException">Unable to get or set the input mode of the console input buffer.</exception>
        /// <returns>
        ///   <see langword="true" /> if Ctrl+C is treated as ordinary input; otherwise, <see langword="false" />.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static bool TreatControlCAsInput
        {
            get => SConsole.TreatControlCAsInput;
            set => SConsole.TreatControlCAsInput = value;
        }

        /// <summary>Gets or sets the height of the console window area.</summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is less than or equal to 0.
        ///
        ///  -or-
        ///
        ///  The value of the <see cref="P:System.Console.WindowHeight" /> property plus the value of the <see cref="P:System.Console.WindowTop" /> property is greater than or equal to <see cref="F:System.Int16.MaxValue" />.
        ///
        ///  -or-
        ///
        ///  The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is greater than the largest possible window width or height for the current screen resolution and console font.</exception>
        /// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
        /// <returns>The height of the console window measured in rows.</returns>
        public static int WindowHeight
        {
            [UnsupportedOSPlatform("android")]
            [UnsupportedOSPlatform("browser")]
            [UnsupportedOSPlatform("ios")]
            [UnsupportedOSPlatform("tvos")]
            get => SConsole.WindowHeight;
            [SupportedOSPlatform("windows")]
            set => SConsole.WindowHeight = value;
        }

        /// <summary>Gets or sets the leftmost position of the console window area relative to the screen buffer.</summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.
        ///
        ///  -or-
        ///
        ///  As a result of the assignment, <see cref="P:System.Console.WindowLeft" /> plus <see cref="P:System.Console.WindowWidth" /> would exceed <see cref="P:System.Console.BufferWidth" />.</exception>
        /// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
        /// <returns>The leftmost console window position measured in columns.</returns>
        public static int WindowLeft
        {
            get => SConsole.WindowLeft;
            [SupportedOSPlatform("windows")]
            set => SConsole.WindowLeft = value;
        }

        /// <summary>Gets or sets the top position of the console window area relative to the screen buffer.</summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.
        ///
        ///  -or-
        ///
        ///  As a result of the assignment, <see cref="P:System.Console.WindowTop" /> plus <see cref="P:System.Console.WindowHeight" /> would exceed <see cref="P:System.Console.BufferHeight" />.</exception>
        /// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
        /// <returns>The uppermost console window position measured in rows.</returns>
        public static int WindowTop
        {
            get => SConsole.WindowTop;
            [SupportedOSPlatform("windows")]
            set => SConsole.WindowTop = value;
        }

        /// <summary>Gets or sets the width of the console window.</summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is less than or equal to 0.
        ///
        ///  -or-
        ///
        ///  The value of the <see cref="P:System.Console.WindowHeight" /> property plus the value of the <see cref="P:System.Console.WindowTop" /> property is greater than or equal to <see cref="F:System.Int16.MaxValue" />.
        ///
        ///  -or-
        ///
        ///  The value of the <see cref="P:System.Console.WindowWidth" /> property or the value of the <see cref="P:System.Console.WindowHeight" /> property is greater than the largest possible window width or height for the current screen resolution and console font.</exception>
        /// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The set operation is invoked on an operating system other than Windows.</exception>
        /// <returns>The width of the console window measured in columns.</returns>
        public static int WindowWidth
        {
            [UnsupportedOSPlatform("android")]
            [UnsupportedOSPlatform("browser")]
            [UnsupportedOSPlatform("ios")]
            [UnsupportedOSPlatform("tvos")]
            get => SConsole.WindowWidth;
            [SupportedOSPlatform("windows")]
            set => SConsole.WindowWidth = value;
        }

        /// <summary>Occurs when the <see cref="F:System.ConsoleModifiers.Control" /> modifier key (Ctrl) and either the <see cref="F:System.ConsoleKey.C" /> console key (C) or the Break key are pressed simultaneously (Ctrl+C or Ctrl+Break).</summary>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static event ConsoleCancelEventHandler CancelKeyPress
        {
            add => SConsole.CancelKeyPress += value;
            remove => SConsole.CancelKeyPress -= value;
        }

        /// <summary>Plays the sound of a beep through the console speaker.</summary>
        /// <exception cref="T:System.Security.HostProtectionException">This method was executed on a server, such as SQL Server, that does not permit access to a user interface.</exception>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void Beep() => SConsole.Beep();

        /// <summary>Plays the sound of a beep of a specified frequency and duration through the console speaker.</summary>
        /// <param name="frequency">The frequency of the beep, ranging from 37 to 32767 hertz.</param>
        /// <param name="duration">The duration of the beep measured in milliseconds.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="frequency" /> is less than 37 or more than 32767 hertz.
        ///
        ///  -or-
        ///
        ///  <paramref name="duration" /> is less than or equal to zero.</exception>
        /// <exception cref="T:System.Security.HostProtectionException">This method was executed on a server, such as SQL Server, that does not permit access to the console.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows.</exception>
        [SupportedOSPlatform("windows")]
        public static void Beep(int frequency, int duration) => SConsole.Beep(frequency, duration);

        /// <summary>Clears the console buffer and corresponding console window of display information.</summary>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void Clear() => SConsole.Clear();

        /// <summary>Gets the position of the cursor.</summary>
        /// <returns>The column and row position of the cursor.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static (int Left, int Top) GetCursorPosition() => SConsole.GetCursorPosition();

        /// <summary>Copies a specified source area of the screen buffer to a specified destination area.</summary>
        /// <param name="sourceLeft">The leftmost column of the source area.</param>
        /// <param name="sourceTop">The topmost row of the source area.</param>
        /// <param name="sourceWidth">The number of columns in the source area.</param>
        /// <param name="sourceHeight">The number of rows in the source area.</param>
        /// <param name="targetLeft">The leftmost column of the destination area.</param>
        /// <param name="targetTop">The topmost row of the destination area.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">One or more of the parameters is less than zero.
        ///
        ///  -or-
        ///
        ///  <paramref name="sourceLeft" /> or <paramref name="targetLeft" /> is greater than or equal to <see cref="P:System.Console.BufferWidth" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="sourceTop" /> or <paramref name="targetTop" /> is greater than or equal to <see cref="P:System.Console.BufferHeight" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="sourceTop" /> + <paramref name="sourceHeight" /> is greater than or equal to <see cref="P:System.Console.BufferHeight" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="sourceLeft" /> + <paramref name="sourceWidth" /> is greater than or equal to <see cref="P:System.Console.BufferWidth" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows.</exception>
        [SupportedOSPlatform("windows")]
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop) =>
            SConsole.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);

        /// <summary>Copies a specified source area of the screen buffer to a specified destination area.</summary>
        /// <param name="sourceLeft">The leftmost column of the source area.</param>
        /// <param name="sourceTop">The topmost row of the source area.</param>
        /// <param name="sourceWidth">The number of columns in the source area.</param>
        /// <param name="sourceHeight">The number of rows in the source area.</param>
        /// <param name="targetLeft">The leftmost column of the destination area.</param>
        /// <param name="targetTop">The topmost row of the destination area.</param>
        /// <param name="sourceChar">The character used to fill the source area.</param>
        /// <param name="sourceForeColor">The foreground color used to fill the source area.</param>
        /// <param name="sourceBackColor">The background color used to fill the source area.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">One or more of the parameters is less than zero.
        ///
        ///  -or-
        ///
        ///  <paramref name="sourceLeft" /> or <paramref name="targetLeft" /> is greater than or equal to <see cref="P:System.Console.BufferWidth" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="sourceTop" /> or <paramref name="targetTop" /> is greater than or equal to <see cref="P:System.Console.BufferHeight" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="sourceTop" /> + <paramref name="sourceHeight" /> is greater than or equal to <see cref="P:System.Console.BufferHeight" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="sourceLeft" /> + <paramref name="sourceWidth" /> is greater than or equal to <see cref="P:System.Console.BufferWidth" />.</exception>
        /// <exception cref="T:System.ArgumentException">One or both of the color parameters is not a member of the <see cref="T:System.ConsoleColor" /> enumeration.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows.</exception>
        [SupportedOSPlatform("windows")]
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor) =>
            SConsole.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);

        /// <summary>Acquires the standard error stream.</summary>
        /// <returns>The standard error stream.</returns>
        public static Stream OpenStandardError() => SConsole.OpenStandardError();

        /// <summary>Acquires the standard error stream, which is set to a specified buffer size.</summary>
        /// <param name="bufferSize">This parameter has no effect, but its value must be greater than or equal to zero.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="bufferSize" /> is less than or equal to zero.</exception>
        /// <returns>The standard error stream.</returns>
        public static Stream OpenStandardError(int bufferSize) => SConsole.OpenStandardError(bufferSize);

        /// <summary>Acquires the standard input stream.</summary>
        /// <returns>The standard input stream.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static Stream OpenStandardInput() => SConsole.OpenStandardInput();

        /// <summary>Acquires the standard input stream, which is set to a specified buffer size.</summary>
        /// <param name="bufferSize">This parameter has no effect, but its value must be greater than or equal to zero.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="bufferSize" /> is less than or equal to zero.</exception>
        /// <returns>The standard input stream.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        public static Stream OpenStandardInput(int bufferSize) => SConsole.OpenStandardInput(bufferSize);

        /// <summary>Acquires the standard output stream.</summary>
        /// <returns>The standard output stream.</returns>
        public static Stream OpenStandardOutput() => SConsole.OpenStandardOutput();

        /// <summary>Acquires the standard output stream, which is set to a specified buffer size.</summary>
        /// <param name="bufferSize">This parameter has no effect, but its value must be greater than or equal to zero.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="bufferSize" /> is less than or equal to zero.</exception>
        /// <returns>The standard output stream.</returns>
        public static Stream OpenStandardOutput(int bufferSize) => SConsole.OpenStandardOutput(bufferSize);

        /// <summary>Reads the next character from the standard input stream.</summary>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <returns>The next character from the input stream, or negative one (-1) if there are currently no more characters to be read.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        public static int Read() => SConsole.Read();

        /// <summary>Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.</summary>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In" /> property is redirected from some stream other than the console.</exception>
        /// <returns>An object that describes the <see cref="T:System.ConsoleKey" /> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo" /> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers" /> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static ConsoleKeyInfo ReadKey() => SConsole.ReadKey();

        /// <summary>Obtains the next character or function key pressed by the user. The pressed key is optionally displayed in the console window.</summary>
        /// <param name="intercept">Determines whether to display the pressed key in the console window. <see langword="true" /> to not display the pressed key; otherwise, <see langword="false" />.</param>
        /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In" /> property is redirected from some stream other than the console.</exception>
        /// <returns>An object that describes the <see cref="T:System.ConsoleKey" /> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo" /> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers" /> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static ConsoleKeyInfo ReadKey(bool intercept) => SConsole.ReadKey(intercept);

        /// <summary>Reads the next line of characters from the standard input stream.</summary>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line of characters is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
        /// <returns>The next line of characters from the input stream, or <see langword="null" /> if no more lines are available.</returns>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        public static string ReadLine() => SConsole.ReadLine();

        /// <summary>Sets the foreground and background console colors to their defaults.</summary>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void ResetColor() => SConsole.ResetColor();

        /// <summary>Sets the height and width of the screen buffer area to the specified values.</summary>
        /// <param name="width">The width of the buffer area measured in columns.</param>
        /// <param name="height">The height of the buffer area measured in rows.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="height" /> or <paramref name="width" /> is less than or equal to zero.
        ///
        ///  -or-
        ///
        ///  <paramref name="height" /> or <paramref name="width" /> is greater than or equal to <see cref="F:System.Int16.MaxValue" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="width" /> is less than <see cref="P:System.Console.WindowLeft" /> + <see cref="P:System.Console.WindowWidth" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="height" /> is less than <see cref="P:System.Console.WindowTop" /> + <see cref="P:System.Console.WindowHeight" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows.</exception>
        [SupportedOSPlatform("windows")]
        public static void SetBufferSize(int width, int height) => SConsole.SetBufferSize(width, height);

        /// <summary>Sets the position of the cursor.</summary>
        /// <param name="left">The column position of the cursor. Columns are numbered from left to right starting at 0.</param>
        /// <param name="top">The row position of the cursor. Rows are numbered from top to bottom starting at 0.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="left" /> or <paramref name="top" /> is less than zero.
        ///
        ///  -or-
        ///
        ///  <paramref name="left" /> is greater than or equal to <see cref="P:System.Console.BufferWidth" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="top" /> is greater than or equal to <see cref="P:System.Console.BufferHeight" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void SetCursorPosition(int left, int top) => SConsole.SetCursorPosition(left, top);

        /// <summary>Sets the <see cref="P:System.Console.Error" /> property to the specified <see cref="T:System.IO.TextWriter" /> object.</summary>
        /// <param name="newError">A stream that is the new standard error output.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="newError" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public static void SetError(TextWriter newError) => SConsole.SetError(newError);

        /// <summary>Sets the <see cref="P:System.Console.In" /> property to the specified <see cref="T:System.IO.TextReader" /> object.</summary>
        /// <param name="newIn">A stream that is the new standard input.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="newIn" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void SetIn(TextReader newIn) => SConsole.SetIn(newIn);

        /// <summary>Sets the <see cref="P:System.Console.Out" /> property to target the <see cref="T:System.IO.TextWriter" /> object.</summary>
        /// <param name="newOut">A text writer to be used as the new standard output.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="newOut" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public static void SetOut(TextWriter newOut) => SConsole.SetOut(newOut);

        /// <summary>Sets the position of the console window relative to the screen buffer.</summary>
        /// <param name="left">The column position of the upper left  corner of the console window.</param>
        /// <param name="top">The row position of the upper left corner of the console window.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="left" /> or <paramref name="top" /> is less than zero.
        ///
        ///  -or-
        ///
        ///  <paramref name="left" /> + <see cref="P:System.Console.WindowWidth" /> is greater than <see cref="P:System.Console.BufferWidth" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="top" /> + <see cref="P:System.Console.WindowHeight" /> is greater than <see cref="P:System.Console.BufferHeight" />.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows.</exception>
        [SupportedOSPlatform("windows")]
        public static void SetWindowPosition(int left, int top) => SConsole.SetWindowPosition(left, top);

        /// <summary>Sets the height and width of the console window to the specified values.</summary>
        /// <param name="width">The width of the console window measured in columns.</param>
        /// <param name="height">The height of the console window measured in rows.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="width" /> or <paramref name="height" /> is less than or equal to zero.
        ///
        ///  -or-
        ///
        ///  <paramref name="width" /> plus <see cref="P:System.Console.WindowLeft" /> or <paramref name="height" /> plus <see cref="P:System.Console.WindowTop" /> is greater than or equal to <see cref="F:System.Int16.MaxValue" />.
        ///
        ///  -or-
        ///
        ///  <paramref name="width" /> or <paramref name="height" /> is greater than the largest possible window width or height for the current screen resolution and console font.</exception>
        /// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows.</exception>
        [SupportedOSPlatform("windows")]
        public static void SetWindowSize(int width, int height) => SConsole.SetWindowPosition(width, height);

        /// <summary>Writes the text representation of the specified Boolean value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(bool value) => SConsole.Write(value);

        /// <summary>Writes the specified Unicode character value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(char value) => SConsole.Write(value);

        /// <summary>Writes the specified array of Unicode characters to the standard output stream.</summary>
        /// <param name="buffer">A Unicode character array.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(char[] buffer) => SConsole.Write(AnsiUtils.TransformAnsi(buffer));

        /// <summary>Writes the specified subarray of Unicode characters to the standard output stream.</summary>
        /// <param name="buffer">An array of Unicode characters.</param>
        /// <param name="index">The starting position in <paramref name="buffer" />.</param>
        /// <param name="count">The number of characters to write.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="buffer" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="index" /> or <paramref name="count" /> is less than zero.</exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="index" /> plus <paramref name="count" /> specify a position that is not within <paramref name="buffer" />.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(char[] buffer, int index, int count) => SConsole.Write(AnsiUtils.TransformAnsi(buffer, index, count));

        /// <summary>Writes the text representation of the specified <see cref="T:System.Decimal" /> value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(decimal value) => SConsole.Write(value);

        /// <summary>Writes the text representation of the specified double-precision floating-point value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(double value) => SConsole.Write(value);

        /// <summary>Writes the text representation of the specified 32-bit signed integer value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(int value) => SConsole.Write(value);

        /// <summary>Writes the text representation of the specified 64-bit signed integer value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(long value) => SConsole.Write(value);

        /// <summary>Writes the text representation of the specified object to the standard output stream.</summary>
        /// <param name="value">The value to write, or <see langword="null" />.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(object value) => SConsole.Write(AnsiUtils.TransformAnsi(value));

        /// <summary>Writes the text representation of the specified single-precision floating-point value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(float value) => SConsole.Write(value);

        /// <summary>Writes the specified string value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void Write(string value) => SConsole.Write(AnsiUtils.TransformAnsi(value));

        /// <summary>Writes the text representation of the specified object to the standard output stream using the specified format information.</summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">An object to write using <paramref name="format" />.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="format" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
        public static void Write(string format, object arg0) => SConsole.Write(AnsiUtils.TransformAnsi(format, arg0));

        /// <summary>Writes the text representation of the specified objects to the standard output stream using the specified format information.</summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The first object to write using <paramref name="format" />.</param>
        /// <param name="arg1">The second object to write using <paramref name="format" />.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="format" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
        public static void Write(string format, object arg0, object arg1) => SConsole.Write(AnsiUtils.TransformAnsi(format, arg0, arg1));

        /// <summary>Writes the text representation of the specified objects to the standard output stream using the specified format information.</summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The first object to write using <paramref name="format" />.</param>
        /// <param name="arg1">The second object to write using <paramref name="format" />.</param>
        /// <param name="arg2">The third object to write using <paramref name="format" />.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="format" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
        public static void Write(string format, object arg0, object arg1, object arg2) => SConsole.Write(AnsiUtils.TransformAnsi(format, arg0, arg1, arg2));

        /// <summary>Writes the text representation of the specified array of objects to the standard output stream using the specified format information.</summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg">An array of objects to write using <paramref name="format" />.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="format" /> or <paramref name="arg" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
        public static void Write(string format, params object[] arg) => SConsole.Write(AnsiUtils.TransformAnsi(format, arg));

        /// <summary>Writes the text representation of the specified 32-bit unsigned integer value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        [CLSCompliant(false)]
        public static void Write(uint value) => SConsole.Write(value);

        /// <summary>Writes the text representation of the specified 64-bit unsigned integer value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        [CLSCompliant(false)]
        public static void Write(ulong value) => SConsole.Write(value);

        /// <summary>Writes the current line terminator to the standard output stream.</summary>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine() => SConsole.WriteLine();

        /// <summary>Writes the text representation of the specified Boolean value, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(bool value) => SConsole.WriteLine(value);

        /// <summary>Writes the specified Unicode character, followed by the current line terminator, value to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(char value) => SConsole.WriteLine(value);

        /// <summary>Writes the specified array of Unicode characters, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="buffer">A Unicode character array.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(char[] buffer) => SConsole.WriteLine(AnsiUtils.TransformAnsi(buffer));

        /// <summary>Writes the specified subarray of Unicode characters, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="buffer">An array of Unicode characters.</param>
        /// <param name="index">The starting position in <paramref name="buffer" />.</param>
        /// <param name="count">The number of characters to write.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="buffer" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="index" /> or <paramref name="count" /> is less than zero.</exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="index" /> plus <paramref name="count" /> specify a position that is not within <paramref name="buffer" />.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(char[] buffer, int index, int count) => SConsole.WriteLine(AnsiUtils.TransformAnsi(buffer, index, count));

        /// <summary>Writes the text representation of the specified <see cref="T:System.Decimal" /> value, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(decimal value) => SConsole.WriteLine(value);

        /// <summary>Writes the text representation of the specified double-precision floating-point value, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(double value) => SConsole.WriteLine(value);

        /// <summary>Writes the text representation of the specified 32-bit signed integer value, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(int value) => SConsole.WriteLine(value);

        /// <summary>Writes the text representation of the specified 64-bit signed integer value, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(long value) => SConsole.WriteLine(value);

        /// <summary>Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(object value) => SConsole.WriteLine(AnsiUtils.TransformAnsi(value));

        /// <summary>Writes the text representation of the specified single-precision floating-point value, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(float value) => SConsole.WriteLine(value);

        /// <summary>Writes the specified string value, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        public static void WriteLine(string value) => SConsole.WriteLine(AnsiUtils.TransformAnsi(value));

        /// <summary>Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">An object to write using <paramref name="format" />.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="format" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
        public static void WriteLine(string format, object arg0) => SConsole.WriteLine(AnsiUtils.TransformAnsi(format, arg0));

        /// <summary>Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The first object to write using <paramref name="format" />.</param>
        /// <param name="arg1">The second object to write using <paramref name="format" />.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="format" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
        public static void WriteLine(string format, object arg0, object arg1) => SConsole.WriteLine(AnsiUtils.TransformAnsi(format, arg0, arg1));

        /// <summary>Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg0">The first object to write using <paramref name="format" />.</param>
        /// <param name="arg1">The second object to write using <paramref name="format" />.</param>
        /// <param name="arg2">The third object to write using <paramref name="format" />.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="format" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
        public static void WriteLine(string format, object arg0, object arg1, object arg2) => SConsole.WriteLine(AnsiUtils.TransformAnsi(format, arg0, arg1, arg2));

        /// <summary>Writes the text representation of the specified array of objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="arg">An array of objects to write using <paramref name="format" />.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="format" /> or <paramref name="arg" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
        public static void WriteLine(string format, params object[] arg) => SConsole.WriteLine(AnsiUtils.TransformAnsi(format, arg));

        /// <summary>Writes the text representation of the specified 32-bit unsigned integer value, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        [CLSCompliant(false)]
        public static void WriteLine(uint value) => SConsole.WriteLine(value);

        /// <summary>Writes the text representation of the specified 64-bit unsigned integer value, followed by the current line terminator, to the standard output stream.</summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        [CLSCompliant(false)]
        public static void WriteLine(ulong value) => SConsole.WriteLine(value);
    }
}


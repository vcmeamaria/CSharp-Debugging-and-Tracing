# C# Debugging and Tracing

A collection of C# examples exploring debugging, tracing, assertions, conditional diagnostics and logging.

The project uses a console menu so that each example can be run individually.

---

## Examples

### Example 01 — Debugging Basics

Demonstrates:

* Runtime errors
* `DivideByZeroException`
* Logic errors
* Using the debugger to inspect values

---

### Example 02 — Visual Studio Debugging

Demonstrates:

* Breakpoints
* Step Over
* Step Into
* Step Out
* Locals
* Watch
* Call Stack
* Immediate Window

---

### Example 03 — Basic Tracing

Introduces:

```csharp
Trace.WriteLine()
```

Trace messages can be viewed in:

**Visual Studio → Output → Debug**

---

### Example 04 — Debug vs Trace

Compares:

```csharp
Debug.WriteLine()
Trace.WriteLine()
```

The example is also tested using both **Debug** and **Release** builds.

---

### Example 05 — Debug and Trace Members

Demonstrates:

```csharp
Write()
WriteLine()
WriteIf()
WriteLineIf()
Indent()
Unindent()
```

---

### Example 06 — Debug.Assert

Uses:

```csharp
Debug.Assert()
```

to check an assumption while debugging.

---

### Example 07 — Conditional Debug

Introduces:

```csharp
[Conditional("DEBUG")]
```

The conditional method runs in a **Debug** build but is ignored in a **Release** build.

---

### Example 08 — Custom Conditional Logging

Creates a custom:

```csharp
LogDebug()
```

method using:

```csharp
[Conditional("DEBUG")]
```

---

### Example 09 — Console Trace Listener

Uses:

```csharp
ConsoleTraceListener
```

to send `Trace.WriteLine()` messages directly to the console.

---

### Example 10 — File Trace Listener

Uses:

```csharp
TextWriterTraceListener
```

to write trace messages to:

```text
app-log.txt
```

---

### Example 11 — Trace Configuration

Explores the older `.NET Framework`:

```text
App.config
```

tracing configuration.

The example configuration is stored as:

```text
App.config.example
```

because this project uses modern .NET.

---

### Example 12 — log4net

Introduces the `log4net` NuGet package.

Logging is configured using:

```text
log4net.config
```

and written to:

* Console
* `application.log`

---

### Example 13 — Logging Levels

Demonstrates the log4net levels:

```text
DEBUG
INFO
WARN
ERROR
FATAL
```

---

### Example 14 — Complete Debugging and Tracing Example

Combines:

* `Debug.WriteLine()`
* `Debug.Assert()`
* `Trace.WriteLine()`
* `ConsoleTraceListener`
* `TextWriterTraceListener`
* `Trace.AutoFlush`
* Exception handling
* `DivideByZeroException`
* File tracing

The trace output is also written to:

```text
trace-log.txt
```

---

# 🐞 Visual Studio Debugging — Quick Guide

## 1. Add a breakpoint

* Click beside the line number where you want the program to pause.
* On my keyboard: **Fn + F9** toggles the breakpoint.

A red dot indicates an active breakpoint:

```text
🔴
```

---

## 2. Run in Debug mode

Press:

```text
F5
```

The program will run until it reaches the breakpoint.

---

## 3. Look for the yellow line 🟨

When the debugger pauses, Visual Studio highlights a line in yellow.

The yellow line shows the **next line that will be executed**.

---

## 4. Step through the code

### Step Over

```text
Fn + F10
```

Runs the current line and moves to the next line.

### Step Into

```text
Fn + F11
```

Goes inside a method being called.

### Step Out

```text
Shift + Fn + F11
```

Finishes the current method and returns to where it was called.

### Continue

```text
F5
```

Continues running normally until another breakpoint is reached.

---

## 5. Check variable values

Go to:

**Debug → Windows → Locals**

The **Locals** window shows the current values of local variables while the program is paused.

For example:

```text
total    10
count     0
age      18
```

---

## 6. Watch a specific variable

Right-click a variable and select:

**Add Watch**

The **Watch** window allows a specific variable or expression to be monitored while stepping through the program.

---

## Quick Reminder

```text
🔴 Breakpoint
      ↓
F5 Run
      ↓
🟨 Pause
      ↓
Fn + F10 Step Over
or
Fn + F11 Step Into
      ↓
Check Locals / Watch
      ↓
F5 Continue
```

---

# Debug vs Release

Visual Studio can build the application using different configurations.

The configuration can be changed using the dropdown at the top of Visual Studio:

```text
Debug | Any CPU
```

or:

```text
Release | Any CPU
```

## Debug

Use **Debug** while developing and testing the application.

In this project, Debug mode allows development-only diagnostics such as:

```csharp
Debug.WriteLine()
```

and methods using:

```csharp
[Conditional("DEBUG")]
```

to run.

Example:

```csharp
[Conditional("DEBUG")]
static void LogDebug(string message)
{
    Console.WriteLine($"[DEBUG] {message}");
}
```

In a Debug build:

```text
[DEBUG] Application started
```

is displayed.

---

## Release

Release builds are intended for the finished application and use compiler optimisations.

Before changing from Debug to Release, stop the current debugging session:

```text
Shift + F5
```

Then change:

```text
Debug
```

to:

```text
Release
```

and run again with:

```text
F5
```

Visual Studio may display a **Just My Code Warning** when debugging a Release build.

For these examples, choose:

**Continue Debugging**

In Release mode, calls using:

```csharp
Debug.WriteLine()
```

or:

```csharp
[Conditional("DEBUG")]
```

will not run because the `DEBUG` symbol is not defined.

For example:

```text
DEBUG BUILD

Debug message        ✅
Trace message        ✅


RELEASE BUILD

Debug message        ❌
Trace message        ✅
```

After testing Release behaviour:

1. Stop debugging with `Shift + F5`
2. Change **Release** back to **Debug**

---

# Running the Project

Run the application from Visual Studio and select an example from the console menu:

```text
==========================================
       C# DEBUGGING AND TRACING
==========================================

Choose an example:

1.  Debugging Basics
2.  Visual Studio Debugging
3.  Basic Tracing
4.  Debug vs Trace
5.  Debug and Trace Members
6.  Debug.Assert
7.  Conditional Debug
8.  Custom Conditional Logging
9.  Console Trace Listener
10. File Trace Listener
11. Trace Configuration
12. log4net
13. Logging Levels
14. Complete Debugging and Tracing Example

0. Exit
```

---

## Generated Files

Some examples generate diagnostic files such as:

```text
app-log.txt
trace-log.txt
application.log
```

These are generated while the application runs and are excluded from GitHub using `.gitignore`.
